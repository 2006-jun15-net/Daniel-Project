using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Library.Ciphers
{
    public class Sub_FakeData_Cipher
    {
        public string printableCharacters = " !" + '"' + "#$%&'()*+,-./0123456789" +
            ":;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[" + "\\" + "]^_`" +
            "abcdefghijklmnopqrstuvwxyz{|}~";

        public string Encode(string x, int a, int b)
        {
            int printLength = printableCharacters.Length;
            int inputLength = x.Length;
            int c = (int)Math.Pow(b, a);

            int amountOfFakeData = (int)((inputLength / a) + (inputLength / c));

            int total = inputLength + amountOfFakeData;

            char[] letters = new char[total];

            int count = 0;
            bool toggle = false;
            int index = 0;

            for (int i = 0; i < inputLength; i++)
            {
                letters[count] = x[i];


                count++;

                if (((i+1) % a) == 0)
                {
                    if (toggle == false)
                    {
                        index += (a * b);
                        index %= printLength;
                        letters[count] = printableCharacters[index];
                    }
                    if (toggle == true)
                    {
                        index += b;
                        index %= printLength;
                        letters[count] = printableCharacters[index];
                    }
                    count++;
                    toggle = !toggle;
                }
                if (((i+1) % c) == 0){
                    if (toggle == false)
                    {
                        index += (a * b);
                        index %= printLength;
                        letters[count] = printableCharacters[index];
                    }
                    if (toggle == true)
                    {
                        index += b;
                        index %= printLength;
                        letters[count] = printableCharacters[index];
                    }
                    count++;
                    toggle = !toggle;
                }
            }



            string result = "";

            foreach(char i in letters)
            {
                result += i;
            }

            return result;
        }

        public string Decode(string x, int a, int b)
        {
            int inputLength = x.Length;
            int c = (int)Math.Pow(b, a);

            char[] letters = new char[inputLength];

            int count = 0;

            for (int i = 0; i < inputLength; i++)
            {
                if(count >= inputLength)
                {
                    break;
                }
                letters[i] = x[count];


                count++;

                if (((i + 1) % a) == 0)
                {
                    count++;
                }
                if (((i + 1) % c) == 0)
                {
                    count++;
                }
            }



            string result = "";

            foreach (char i in letters)
            {
                if(i == '\0')
                {
                    break;
                }
                result += i;
            }

            return result;
        }
    }
}
