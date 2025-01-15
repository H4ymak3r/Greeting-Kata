using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace Greeting_Kata
{
    public class GreetingKata
    {
        public string greet(string name)
        {
            string[] names = name.Split(',').Select(n => n.Trim()).ToArray();

            if (names.Length == 0 || string.IsNullOrWhiteSpace(name))
            {
                return "Hello, my friend.";
            }
            string normalGreeting = "";
            string shoutedGreeting = "";

            foreach (var n in names)
            {
                if (n == n.ToUpper())
                {

                    if (string.IsNullOrEmpty(shoutedGreeting))
                    {
                        shoutedGreeting = $"AND HELLO {n}!";
                    }
                    else
                    {
                        shoutedGreeting += $" AND {n}";
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(normalGreeting))
                    {
                        normalGreeting = $"Hello, {n}";
                    }
                    else
                    {
                        normalGreeting += $", {n}";
                    }
                }
            }

            if (!string.IsNullOrEmpty(normalGreeting) && !string.IsNullOrEmpty(shoutedGreeting))
            {

                int lastCommaIndex = normalGreeting.LastIndexOf(',');
                if (lastCommaIndex != -1)
                {
                    normalGreeting = normalGreeting.Substring(0, lastCommaIndex) + " and" + normalGreeting.Substring(lastCommaIndex + 1);
                }
                return $"{normalGreeting}. {shoutedGreeting}";
            }

            return normalGreeting + shoutedGreeting;
        }
    }
}
