using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Library.Ciphers
{
    public class Transposition_Cipher
    {
        public string Encode(string x, int col)
        {
            int stringLength = x.Length;
            int rows = stringLength / col;
            int remainder = stringLength % col;
            bool check = false;
            if (remainder > 0)
            {
                rows++;
                check = true;
            }


            char[,] table = new char[rows, col];

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < col; k++)
                {
                    table[i, k] = x[count];
                    if (count == (stringLength - 1))
                    {
                        break;
                    }
                    count++;
                }
            }

            string result = "";
            count = 1;

            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < rows; k++)
                {
                    if (check == true)
                    {
                        if((count % rows) == 0)
                        {
                            if (remainder == 0)
                            {
                                count++;
                                continue;
                            }
                            remainder--;
                        }
                    }
                    result += table[k, i];
                    count++;
                }
            }

            return result;
        }

        public string Decode(string x, int col)
        {
            int stringLength = x.Length;
            int rows = stringLength / col;
            int remainder = stringLength % col;
            bool check = false;
            if (remainder > 0)
            {
                rows++;
                check = true;
            }


            char[,] table = new char[rows, col];
            string result = "";
            int count = 1;
            int counter = 0;

            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < rows; k++)
                {
                    if (check == true)
                    {
                        if ((count % rows) == 0)
                        {
                            if (remainder == 0)
                            {
                                count++;
                                continue;
                            }
                            remainder--;
                        }
                    }
                    table[k, i] = x[counter];
                    counter++;
                    count++;
                }
            }

            count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < col; k++)
                {
                    result += table[i, k];
                    if (count == (stringLength - 1))
                    {
                        break;
                    }
                    count++;
                }
            }

            return result;
        }
    }
}
