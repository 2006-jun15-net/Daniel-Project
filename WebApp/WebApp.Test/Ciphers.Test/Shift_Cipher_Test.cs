using System;
using WebApp.Library.Ciphers;
using Xunit;

namespace WebApp.Test.Ciphers.Test
{
    public class Shift_Cipher_Test
    {

        //ASCII: 32-126
        [Fact]
        public void Encode_smallNumber()
        {
            string input = "dog";
            string expected = "grj";
            int shiftAmount = 3;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.Encode(input, shiftAmount));
        }

        [Fact]
        public void Encode_positiveEdgeNumber()
        {
            string input = "~}|";
            string expected = "! ~";
            int shiftAmount = 2;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.Encode(input, shiftAmount));
        }

        [Fact]
        public void Encode_bigPositiveNumber()
        {
            string input = "a person goes for a WALK";
            string expected = "=[LANOKJ[CKAO[BKN[=[3|('";
            int shiftAmount = 1104;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.Encode(input, shiftAmount));
        }

        [Fact]
        public void Encode_smallNegativeNumber()
        {
            string input = "person";
            string expected = "mboplk";
            int shiftAmount = -3;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.Encode(input, shiftAmount));
        }

        [Fact]
        public void Encode_negativeEdgeNumber()
        {
            string input = "! ~";
            string expected = "~}|";
            int shiftAmount = -2;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.Encode(input, shiftAmount));
        }


        [Fact]
        public void Encode_bigNegativeNumber()
        {
            string input = "person";
            string expected = "aVcd`_";
            int shiftAmount = -300;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.Encode(input, shiftAmount));
        }

        [Fact]
        public void Decode_smallNumber()
        {
            string input = "grj";
            string expected = "dog";
            int shiftAmount = 3;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.Decode(input, shiftAmount));
        }

    }
}
