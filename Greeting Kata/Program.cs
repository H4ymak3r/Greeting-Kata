using Greeting_Kata;

GreetingKata greetingKata = new GreetingKata();

Console.Write("Inserisci il/i nome/i: ");
string name = Console.ReadLine();
greetingKata.greet(name);


/*

## Requirement 7

If any entries in `name` are a string containing a comma, split it as its own input. For example, when `name` is `["Bob", "Charlie, Dianne"]`, then the method should return the string `"Hello, Bob, Charlie, and Dianne."`.

## Requirement 8

Allow the input to escape intentional commas introduced by Requirement 7. These can be escaped in the same manner that CSV is, with double quotes surrounding the entry. For example, when `name` is `["Bob", "\"Charlie, Dianne\""]`, then the method should return the string `"Hello, Bob and Charlie, Dianne."`. */