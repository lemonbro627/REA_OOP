using REA_OOP;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Money a1 = new Money();
Money a2 = new Money(123, 206);
Money a3 = new Money(123, 123);
Money a4 = new Money(999);
Console.WriteLine(Money.Counter);
Console.WriteLine(a2.ToString());
a2 = a2 + (-10);
Console.WriteLine(a2.ToString());
a1.Kopeks = 99;
a1.Rubles = 1000;
Console.WriteLine(a1.ToString());
Console.WriteLine(a3.ToString());
Console.WriteLine(a4.ToString());