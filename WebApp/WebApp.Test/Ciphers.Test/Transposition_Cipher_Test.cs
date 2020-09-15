using System;
using WebApp.Library.Ciphers;
using Xunit;

namespace WebApp.Test.Ciphers.Test
{
    public class Transposition_Cipher_Test
    {
        [Fact]
        public void Encode_smallArray()
        {
            string input = "a person";
            int col = 2;

            string expected = "apro esn";
            var Transposition = new Transposition_Cipher();

            Assert.Equal(expected, Transposition.Encode(input, col));
        }

        [Fact]
        public void Encode_largeArray()
        {
            string input = "a person was walking a dog";
            int col = 5;

            string expected = "asal g oskapn i e wndrwago";
            var Transposition = new Transposition_Cipher();

            Assert.Equal(expected, Transposition.Encode(input, col));
        }

        [Fact]
        public void Decode_smallArray()
        {
            string input = "apro esn";
            int col = 2;

            string expected = "a person";
            var Transposition = new Transposition_Cipher();

            Assert.Equal(expected, Transposition.Decode(input, col));
        }

        [Fact]
        public void Decode_largeArray()
        {
            string input = "asal g oskapn i e wndrwago";
            int col = 5;

            string expected = "a person was walking a dog";
            var Transposition = new Transposition_Cipher();

            Assert.Equal(expected, Transposition.Decode(input, col));
        }
    }
}
