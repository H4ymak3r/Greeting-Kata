using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting_Kata
{
    internal class GreetingKata
    {
        public string greet(string name)
        {
            if (name == null) {
                return "Hello, my friend.";
            }
            else { 
                return $"Hello, {name}";
            }
            if (name == name.ToUpper())
            {
                return $"HELLO, {name.ToUpper()}";
            }
        }
    }
}
