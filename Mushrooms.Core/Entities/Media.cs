using System.Collections.Generic;

namespace Mushrooms.Core
{
    public class Media
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Ext { get; set; }

        public string Md5 { get; set; }

        public long Size { get; set; }

        public string Path { get; set; }

        public string PreviewPath { get; set; }

        public string StoragePath { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
