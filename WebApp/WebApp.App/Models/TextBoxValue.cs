using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.App.Models
{
    public class TextBoxValue
    {
        public string CipherID { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public string Key { get; set; }

        public string Num1 { get; set; }

        public string Num2 { get; set; }

        public string EncodeKey { get; set; }

        public string Cipher (string x)
        {
            char type = 'A';
            char num = '0';
            foreach (char i in x)
            {
                if (Char.IsDigit(i) == false)
                {

                    type = i;

                }
                if (Char.IsDigit(i) == true)
                {
                    num = i;
                }
            }
            
            return type.ToString() + num.ToString();
        }

        public int Shift_Cipher_Number(string x)
        {
            string number = "";
            int num = 1;
            foreach (char i in x)
            {
                if(Char.IsDigit(i) == true)
                {
                    number += i;
                }
            }
            num = Int32.Parse(number);
            return num;
        }
    }
}
