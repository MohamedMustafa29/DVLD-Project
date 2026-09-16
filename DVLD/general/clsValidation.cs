using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.general
{
    public class clsValidation
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsNumber(string Number)
        {
            return decimal.TryParse(Number, out decimal outDecimal);
        }

    }
}
