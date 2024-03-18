using REA_OOP;
using System.Linq.Expressions;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("PRz-11 Bazhin Dmitrii, Variant 2");

Money a1 = new Money();
Money a2 = new Money(123, 206);
Money a3 = new Money(123, 123);
Money a4 = new Money(11);
Money a5 = new Money(0, 2);
Console.WriteLine("a2 = " + a2.ToString());
a2 = a2 + (-10);
Console.WriteLine("a2 = " + a2.ToString());
a2++;
a2++;
a2++;
a2++;
Console.WriteLine("a2 = " + a2.ToString());
a2 = a2 + 10;
Console.WriteLine("a2 = " + a2.ToString());
Console.WriteLine("a1 = " + a1.ToString());
a1.Rubles = 1001;
a1.Kopeks = 111;
Console.WriteLine("a1 = " + a1.ToString());
Console.WriteLine("a3 = " + a3.ToString());
Console.WriteLine("a4 = " + a4.ToString());
a4--;
Console.WriteLine("a4 = " + a4.ToString());
a4++;
Console.WriteLine("a4 = " + a4.ToString());
Console.WriteLine("a5 = " + a5.ToString());
a5--;   
Console.WriteLine("a5 = " + a5.ToString());
a5--;
Console.WriteLine("a5 = " + a5.ToString());
a5--;
Console.WriteLine("a5 = " + a5.ToString());
a5--;
Console.WriteLine("a5 = " + a5.ToString());
a1.Rubles = 95;
a1.Kopeks = 95;
a2.Rubles = 10;
a2.Rubles = 10;
Console.WriteLine("a1 = " + a1.ToString());
Console.WriteLine("a2 = " + a2.ToString());
Console.WriteLine("a1+a2 = " + (a1 + a2).ToString());
Console.WriteLine("a2+a1 = " + (a2 + a1).ToString());
Console.WriteLine("a1-a2 = " + (a1 - a2).ToString());
Console.WriteLine("a2-a1 = " + (a2 - a1).ToString());
Console.WriteLine("a1-10 = " + (a1 - 10).ToString());
Console.WriteLine("a1+10 = " + (a1 + 10).ToString());
Money a6 = new Money(0, 7);
Console.WriteLine("a6 = " + a6.ToString());
Console.WriteLine("10+a6 = " + (10 + a6).ToString());
Console.WriteLine("10-a6 = " + (10 - a6).ToString());
Console.WriteLine("5-a6 = " + (5 - a6).ToString());
Console.WriteLine("123+a6 = " + (123 + a6).ToString());
Console.WriteLine("(int)a1 = " + (int)a1);
Console.WriteLine("(double)a1 = " + (double)a1);
Console.WriteLine("Object count: " + Money.Counter);

Console.WriteLine("Array testing");
MoneyArray ma1 = new MoneyArray();
Console.WriteLine("ma1.Length = " + ma1.Lenght);
Console.Write("Введите длину массива, в котором значения будут сгенерированы случайным образом: ");
MoneyArray ma2 = new MoneyArray(Convert.ToInt32(Console.ReadLine()), random:true);
Console.WriteLine("ma2.Length = " + ma2.Lenght);
for (int i = 0;  i < ma2.Lenght; i++)
{
    Console.WriteLine("Elem " + i + ": " + ma2[i]);
}
Console.WriteLine("Min in ma2: " + ma2.Min());
Console.Write("Введите длину массива, в котором значения будут вводится руками: ");
MoneyArray ma3 = new MoneyArray(Convert.ToInt32(Console.ReadLine()), random:false);
Console.WriteLine("ma3.Length = " + ma3.Lenght);
for (int i = 0; i < ma3.Lenght; i++)
{
    Console.WriteLine("Elem " + i + ": " + ma3[i]);
}
Console.WriteLine("Min in ma3: " + ma3.Min());