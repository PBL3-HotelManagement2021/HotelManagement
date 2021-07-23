using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.Extention
{
    public class PhoneNumber
    {
        private string Phone { get; set; }
        public PhoneNumber() { }
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        public static bool IsValidPhoneNumber(string phone)
        {
            if (phone.Length != 10) { return false; }
            if (!IsDigitsOnly(phone)) { return false; }
            return true;
        }
    }
}
