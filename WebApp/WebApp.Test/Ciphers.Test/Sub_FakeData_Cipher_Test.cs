using System;
using WebApp.Library.Ciphers;
using Xunit;

namespace WebApp.Test.Ciphers.Test
{
    public class Sub_FakeData_Cipher_Test
    {
        [Fact]
        public void Encode_smallString()
        {
            string input = "walking";
            int a = 3;
            int b = 2;

            string expected = "wal&kin(g";

            var fakeData = new Sub_FakeData_Cipher();

            Assert.Equal(expected, fakeData.Encode(input, a, b));
        }

        [Fact]
        public void Encode_bigString()
        {
            string input = "a man walking his dog at the park";
            int a = 5;
            int b = 2;

            string expected = "a man* walk,ing h6is do8g at Bthe pDarNk";

            var fakeData = new Sub_FakeData_Cipher();

            Assert.Equal(expected, fakeData.Encode(input, a, b));
        }

        [Fact]
        public void Decode_bigString()
        {
            string input = "a man* walk,ing h6is do8g at Bthe pDarNk";
            int a = 5;
            int b = 2;

            string expected = "a man walking his dog at the park";

            var fakeData = new Sub_FakeData_Cipher();

            Assert.Equal(expected, fakeData.Decode(input, a, b));
        }

        [Fact]
        public void Decode_smallString()
        {
            string input = "wal&kin(g";
            int a = 3;
            int b = 2;

            string expected = "walking";

            var fakeData = new Sub_FakeData_Cipher();

            Assert.Equal(expected, fakeData.Decode(input, a, b));
        }
    }
}
