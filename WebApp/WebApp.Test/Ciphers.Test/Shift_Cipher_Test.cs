using System;
using WebApp.Library.Ciphers;
using Xunit;

namespace WebApp.Test.Ciphers.Test
{
    public class Shift_Cipher_Test
    {

        //ASCII: 32-126
        [Fact]
        public void ShiftBy_smallNumber()
        {
            string input = "dog";
            string expected = "grj";
            int shiftAmount = 3;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.ShiftBy(input, shiftAmount));
        }

        [Fact]
        public void ShiftBy_positiveEdgeNumber()
        {
            string input = "~}|";
            string expected = "! ~";
            int shiftAmount = 2;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.ShiftBy(input, shiftAmount));
        }

        [Fact]
        public void Shiftby_bigPositiveNumber()
        {
            string input = "a person goes for a WALK";
            string expected = "=[LANOKJ[CKAO[BKN[=[3|('";
            int shiftAmount = 1104;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.ShiftBy(input, shiftAmount));
        }

        [Fact]
        public void Shiftby_smallNegativeNumber()
        {
            string input = "person";
            string expected = "mboplk";
            int shiftAmount = -3;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.ShiftBy(input, shiftAmount));
        }

        [Fact]
        public void ShiftBy_negativeEdgeNumber()
        {
            string input = "! ~";
            string expected = "~}|";
            int shiftAmount = -2;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.ShiftBy(input, shiftAmount));
        }


        [Fact]
        public void Shiftby_bigNegativeNumber()
        {
            string input = "person";
            string expected = "aVcd`_";
            int shiftAmount = -300;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.ShiftBy(input, shiftAmount));
        }

        [Fact]
        public void Undo_Shiftby_smallNumber()
        {
            string input = "grj";
            string expected = "dog";
            int shiftAmount = 3;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.Undo_ShiftBy(input, shiftAmount));
        }

    }
}
