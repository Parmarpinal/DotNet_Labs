// See https://aka.ms/new-console-template for more information

using Lab4;

Console.WriteLine("Enter program no which you want to run :");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1)
{
    Problem1 p1 = new Problem1();
    p1.sum(10, 20);
    p1.sum(12.3f, 45.6f);
}
else if (n == 2)
{
    Problem2 p2 = new Problem2();
    p2.area(3.5);
    p2.area(3.5, 2.471);
}
else if (n == 3)
{
    RBI r = new RBI();
    r.calculateInterest(10000, 2.5, 3.6);
    ICICI i = new ICICI();
    i.calculateInterest(10000, 3.5, 4.60);
}
else if (n == 4)
{
    Hospital h = new Hospital();
    h.hospitalDetails();
    Wockhardt w = new Wockhardt();
    w.hospitalDetails();
}
else if (n == 5)
{
    Problem5 p5 = new Problem5();
    p5.area(10);
    p5.area(10.5);
    p5.area(36, 10);
}
else if (n == 6)
{
    BankAccount account = new BankAccount(500, "John Doe");

    account.Deposit(100);
    account.Deposit(150, "CHK123");

    account.Withdraw(50);
    account.Withdraw(200, "CHK456");
}
else
{
    Console.WriteLine("=============== Not valid input ===================");
}

