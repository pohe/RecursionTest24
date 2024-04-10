// See https://aka.ms/new-console-template for more information
using RecursionTest24;

Console.WriteLine("RecursionTest24!");


RecursionEx r = new RecursionEx();

r.PrintHello(3);
Console.WriteLine("Print hello FOR");
r.PrintHelloItFor(3);

Console.WriteLine("Print hello While");
r.PrintHelloItWhile(3);

Console.WriteLine("Adnumbersiterativt");
Console.WriteLine(r.AddNumbersIterativt(3));

Console.WriteLine("AddNumbersRecursive");
Console.WriteLine(r.AddNumbersRecursive(3));

Console.WriteLine("FactorialRekursivt");
Console.WriteLine(r.Factorial(5));

Console.WriteLine("Fibonacci");
Console.WriteLine(r.Fibonacci(9));

Console.WriteLine("Towers of Hanoi");

string pegA = "pegA";
string pegB = "pegB";
string pegC = "pegC";
r.TowersOfHanoi(pegA, pegB, pegC, 16);