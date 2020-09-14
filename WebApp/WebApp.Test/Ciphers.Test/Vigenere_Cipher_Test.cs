using System;
using WebApp.Library.Ciphers;
using Xunit;

namespace WebApp.Test.Ciphers.Test
{
    public class Vigenere_Cipher_Test
    {
        //ASCII: 32-126
        [Fact]
        public void Encode_smallKey()
        {
            string input = "Walking";
            // a 0, 1, 2 pattern
            string key = " !" + '"';

            string expected = "Wbnkjpg";

            var cipher = new Vigenere_Cipher();

            Assert.Equal(expected, cipher.Encode(input, key));
        }

        [Fact]
        public void Encode_bigKey()
        {
            string input = "Walking";
            string key = "The man Went for a walk";

            string expected = ",JRkWPV";

            var cipher = new Vigenere_Cipher();

            Assert.Equal(expected, cipher.Encode(input, key));
        }

        [Fact]
        public void Decode_smallKey()
        {
            string input = "Wbnkjpg";
            // a 0, 1, 2 pattern
            string key = " !" + '"';

            string expected = "Walking";

            var cipher = new Vigenere_Cipher();

            Assert.Equal(expected, cipher.Decode(input, key));
        }

    }
}
