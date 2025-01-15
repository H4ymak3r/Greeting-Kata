using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Greeting_Kata
{
    public class GreetingKataTests
    {
        private GreetingKata _greetingKata;

        [Fact]
        public void Setup()
        {
            _greetingKata = new GreetingKata();
        }

        [Fact]
        public void Test_Greet_WithNullName_ReturnsMyFriend()
        {
            string name = null;

            string result = _greetingKata.greet(name);

            Assert.Equal("Hello, my friend.", result);
        }

        [Fact]
        public void Test_Greet_WithNormalName_ReturnsNormalGreeting()
        {
            string name = "John";

            string result = _greetingKata.greet(name);

            Assert.Equal("Hello, John", result);
        }

        [Fact]
        public void Test_Greet_WithUpperCaseName_ReturnsUpperCaseGreeting()
        {
            string name = "JOHN";

            string result = _greetingKata.greet(name);

            Assert.Equal("HELLO, JOHN", result);
        }

        [Fact]
        public void Test_Greet_WithTwoNames_ReturnBothNamesInGreet()
        {
            string name = "John,Janette";

            string result = _greetingKata.greet(name);

            Assert.Equal("Hello, John and Janette", result);
        }

        [Fact]
        public void Test_Greet_WithMultipleNames_ReturnsAllNames()
        {
            string name = "John,Janette,Lucas";

            string result = _greetingKata.greet(name);

            Assert.Equal(result, "Hello, John, Janette and Lucas");
        }

        [Fact]
        public void Test_Greet_WithMixedNames_ReturnsMixedNames()
        {
            string name = "John,JANETTE,Lucas";

            string result = _greetingKata.greet(name);

            Assert.Equal(result, "Hello, John, and Lucas. HI JANETTE!");
        }
    }
}