using Microsoft.Extensions.Primitives;
using Mushrooms.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Mushrooms.Core.Models
{
    public class QueryStandart
    {
        private Dictionary<string, PropertyInfo> _properties;
        private IEnumerator<KeyValuePair<string, StringValues>> _filter;
        private string _sortArgs = "";
        private Dictionary<string, bool> _sortColumns = new(StringComparer.OrdinalIgnoreCase);

        public string Sort
        {
            get => _sortArgs;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    return;

                _sortArgs = value;
                string[] columns = Sort.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in columns)
                {
                    string colName = item;
                    bool desc = colName[0] == '-';

                    if (desc)
                    {
                        colName = colName[1..];
                    }

                    _sortColumns[colName] = desc;
                }
            }
        }

        public Dictionary<string, string> Dynamic { get; set; }

        public IEnumerator<KeyValuePair<string, StringValues>> Filter // id.eq=1&name.gt=434342
        {
            set
            {
                _filter = value;
            }
        }

        public void Build<T>()
        {
            var t = typeof(T);
            var dict = new Dictionary<string, PropertyInfo>(StringComparer.OrdinalIgnoreCase);

            PropertyInfo[] properies = t.GetProperties();

            foreach (var item in properies)
            {
                dict[item.Name] = item;
            }

            _properties = dict;
        }

        public void ValidateSort<T>(params string[] customFields)
        {
            if (_sortColumns.Count == 0) return;
            PropertyInfo[] properies = typeof(T).GetProperties();
            var set = new HashSet<string>(customFields, StringComparer.OrdinalIgnoreCase);

            foreach (var item in properies)
            {
                set.Add(item.Name);
            }

            foreach (var name in _sortColumns.Keys)
            {
                if (!set.Contains(name))
                {
                    throw new BadRequestException($"Invalid sort param '{name}'");
                }
            }
        }

        public Dictionary<string, bool> SortArgs<T>()
        {
            var res = new Dictionary<string, bool>();
            PropertyInfo[] properies = typeof(T).GetProperties();

            foreach (var item in properies)
            {
                if (_sortColumns.TryGetValue(item.Name, out bool desc))
                {
                    res[item.Name] = desc;
                }
            }

            return res;
        }

        public List<(string key, string op, string val)> FilterArgs(
            out Dictionary<string, PropertyInfo> propertys)
        {
            propertys = _properties;

            var list = new List<(string key, string op, string val)>();

            while (_filter.MoveNext())
            {
                var item = _filter.Current;
                string key = item.Key;
                if (key.Equals("sort", StringComparison.OrdinalIgnoreCase) // &sort=-id,name
                    || key.Equals("limit", StringComparison.OrdinalIgnoreCase)
                    || key.Equals("offset", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                string[] items = key.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                if (items.Length == 2)
                {
                    list.Add((items[0].ToUpper(), items[1].ToUpper(), item.Value[0]));
                }
            }

            return list;
        }
    }
}
