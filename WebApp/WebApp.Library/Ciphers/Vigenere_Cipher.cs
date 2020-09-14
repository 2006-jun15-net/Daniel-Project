using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Library.Ciphers
{

    public class Vigenere_Cipher
    {
        public string printableCharacters = " !" + '"' + "#$%&'()*+,-./0123456789" +
            ":;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[" + "\\" + "]^_`" +
            "abcdefghijklmnopqrstuvwxyz{|}~";

        public string Encode(string x, string key)
        {
            int arrLength = x.Length;

            int keyLength = key.Length;
            int printLength = printableCharacters.Length;

            int[] letterNumbers = new int[arrLength];
            int[] numberCode = new int[keyLength];

            //each letter in string is given a number
            //note that this method is also used in Shift_Cipher.ShiftBy
            //separate into another class in the future
            for (int i = 0; i < arrLength; i++)
            {
                for (int k = 0; k < printLength; k++)
                {
                    if (x[i] == printableCharacters[k])
                    {
                        letterNumbers[i] = k;
                    }

                    //todo: add error logic for no match
                }
            }

            //each letter in key is given a number
            //note that this method is also used in Shift_Cipher.ShiftBy
            //separate into another class in the future
            for (int i = 0; i < keyLength; i++)
            {
                for (int k = 0; k < printLength; k++)
                {
                    if (key[i] == printableCharacters[k])
                    {
                        numberCode[i] = k;
                    }

                    //todo: add error logic for no match
                }
            }

            string result = "";

            //shift letter according to numberCode
            for (int i = 0; i < arrLength; i++)
            {
                int index = letterNumbers[i] + numberCode[i % keyLength];

                if (index < 0)
                {
                    index = printLength - Math.Abs(index % printLength);
                }


                index %= printLength;

                result += printableCharacters[index];
            }

            return result;
        }

        public string Decode(string x, string key)
        {
            int arrLength = x.Length;

            int keyLength = key.Length;
            int printLength = printableCharacters.Length;

            int[] letterNumbers = new int[arrLength];
            int[] numberCode = new int[keyLength];

            //each letter in string is given a number
            //note that this method is also used in Shift_Cipher.ShiftBy
            //separate into another class in the future
            for (int i = 0; i < arrLength; i++)
            {
                for (int k = 0; k < printLength; k++)
                {
                    if (x[i] == printableCharacters[k])
                    {
                        letterNumbers[i] = k;
                    }

                    //todo: add error logic for no match
                }
            }

            //each letter in key is given a number
            //note that this method is also used in Shift_Cipher.ShiftBy
            //separate into another class in the future
            for (int i = 0; i < keyLength; i++)
            {
                for (int k = 0; k < printLength; k++)
                {
                    if (key[i] == printableCharacters[k])
                    {
                        numberCode[i] = k;
                    }

                    //todo: add error logic for no match
                }
            }

            string result = "";

            //shift letter according to numberCode
            for (int i = 0; i < arrLength; i++)
            {
                int index = letterNumbers[i] + (numberCode[i % keyLength] *(-1));

                if (index < 0)
                {
                    index = printLength - Math.Abs(index % printLength);
                }

                index %= printLength;

                result += printableCharacters[index];
            }
            return result;
        }
    }
}
