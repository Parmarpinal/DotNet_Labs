// See https://aka.ms/new-console-template for more information
using Lab3;

Console.WriteLine("Enter which program you want to run?");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1)
{
    Problem1 p1 = new Problem1();
    p1.zeroDivision();
}
else if (n == 2)
{
    Problem2 p2 = new Problem2();
    p2.indexOutOfRange();
}
else if (n == 3)
{
    Calculate c = new Calculate();
    c.sumOfTwo(34, 78);
    c.sumOfThree(10, 100, 1000);
}
else if (n == 4)
{
    Result r = new Result();
    r.addition();
    r.subtraction();
}
else if (n == 5)
{
    Problem5 p5 = new Problem5();
    p5.useOfStringMethods();
}
else if (n == 6)
{
    Problem6 p6 = new Problem6();
    p6.lowerUpper();
}
else if (n == 7)
{
    ShapeDemo p7 = new ShapeDemo();
    p7.circle(10);
    p7.triangle(10.5, 20.2);
    p7.square(2.5);
}
else if (n == 8)
{
    Problem8 p8 = new Problem8();
    p8.notEvenNumber();
}
else if (n == 9)
{
    Problem9 p9 = new Problem9();
    p9.longestString();
}
else if (n == 10)
{
    Problem10 p10 = new Problem10();
    p10.changeCase();
}
else
{
    Console.WriteLine("================= Not valid input ======================");
}
