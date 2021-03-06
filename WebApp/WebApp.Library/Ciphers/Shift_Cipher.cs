﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Library.Ciphers
{
    public class Shift_Cipher
    {
        public string printableCharacters = " !" + '"' + "#$%&'()*+,-./0123456789" +
            ":;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[" + "\\" + "]^_`" + 
            "abcdefghijklmnopqrstuvwxyz{|}~";

        public string Encode(string x, int num)
        {
            int arrLength = x.Length;
            int printLength = printableCharacters.Length;
            int[] letterNumbers = new int[arrLength];

            //each letter in string is given a number
            //note that this method is also used in Vigenere_Cipher.Encode
            //separate into another class in the future
            for (int i = 0; i < arrLength; i++)
            {
                for(int k = 0; k < printLength; k++)
                {
                    if(x[i] == printableCharacters[k])
                    {
                        letterNumbers[i] = k;
                    }

                    //todo: add error logic for no match
                }
            }

            string result = "";

            //shift letter number by num, and reconstruct string
            for (int i = 0; i < arrLength; i++)
            {
                int index = letterNumbers[i] + num;
                
                if (index < 0)
                {
                    index = printLength - Math.Abs(index % printLength);
                }


                index %= printLength;

                result += printableCharacters[index];
            }

            return result;
        }

        public string Decode(string x, int num)
        {
            int temp = num * (-1);

            return Encode(x, temp); ;
        }
    }
}
