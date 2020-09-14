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
            int shiftby = 3;

            var shift = new Shift_Cipher();

            Assert.Equal(expected, shift.ShiftBy(input, shiftby));
        }

        [Fact]
        public void Shiftby_bigNumber()
        {

        }
    }
}
