using PalindromeExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace PalindromeExerciseTests
{
    public class Wordsmith_test
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("pizza", false)]
        [InlineData("taco", false)]
        public void IsAPalindrome_test(string word, bool expected)
        {

          var ws = new Wordsmith();

          var actual = ws.IsAPalindrome(word);

            Assert.Equal(expected, actual);


        }

    }
}
