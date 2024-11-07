using Lab5;

Console.WriteLine("Enter which program you want to run?");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1)
{
    Problem1 s1 = new Problem1();
    s1.studentNames();
}
else if (n == 2)
{
    Problem2 s2 = new Problem2();
    s2.listGenericOperations();
}
else if (n == 3)
{
    Problem3 s3 = new Problem3();
    s3.stackOperations();
}
else if (n == 4)
{
    Problem4 s4 = new Problem4();
    s4.queueOperations();
}
else if (n == 5)
{
    Problem5 s5 = new Problem5();   
    s5.dictionaryMethods();
}
else if (n == 6)
{
    Problem6 s6 = new Problem6();
    s6.hashMapMethod();
}
else
{
    Console.WriteLine("================ Not valid input =================");
}