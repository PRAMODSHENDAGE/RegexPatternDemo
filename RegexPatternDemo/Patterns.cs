using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexPatternDemo
{
    internal class Patterns
    {
        public static string REGEX_PINCODE = "^[1-9][0-9]{5}$";
        public static string REGEX_PHONENUMBER = @"^(((\+){1}91){1}) ?-?[6-9]{1}[0-9]{9}$";
        public static string REGEX_EMAIL = "^[0-9a-zA-Z]+[.]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public string REGEX_PASSWORD = "^[A-Z]{1}[a-z]{2}[!@#$]{1}[0-9]{4}$";
        public bool validatePinCode(string pincode) 
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }
        public bool validatePhoneNumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, REGEX_PHONENUMBER);
        }
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
