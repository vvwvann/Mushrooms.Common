using PhoneNumbers;

namespace Mushrooms.Core.Helpers
{
    public static class PhoneValidator
    {
        public static bool IsValid(string phone)
        {
            try
            {
                PhoneNumber phoneNumber = PhoneNumberUtil.GetInstance().Parse(phone, null);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
