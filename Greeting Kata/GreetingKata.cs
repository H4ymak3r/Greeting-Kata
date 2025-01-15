using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Greeting_Kata
{
    public class GreetingKata
    {
        public string greet(string name)
        {
            string[] names = name.Split(',');
            if (names.Length == 1)
            {
                if (name == null)
                {
                    return "Hello, my friend.";
                }
                else if (name == name.ToUpper())
                {
                    return $"HELLO, {name.ToUpper()}";
                }
                else
                {
                    return $"Hello, {name}";
                }
            }
            else 
            {
                string mixedGreeting = "Hello, ";
                for (int i = 0; i < names.Length - 1; i++)
                {
                    if (names[i] == names[i].ToUpper()) 
                    {
                        mixedGreeting = mixedGreeting + names[i].ToUpper();
                    }
                    else
                    {
                        mixedGreeting = mixedGreeting + names[i];
                    }
                    mixedGreeting = mixedGreeting + $"and {names[i + 1]}";
                }
                return mixedGreeting;
            }
        }
    }
}
