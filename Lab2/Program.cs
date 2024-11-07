using Lab2;
using System.Diagnostics;

Console.WriteLine("Enter which program you want to run ?");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1)
{
    Candidate c = new Candidate();
    c.getCandidateDetails();
    c.displayCandidateDetails();
}
else if (n == 2)
{
    Staff[] s = new Staff[5];
    for (int i = 0; i < 5; i++)
    {
        s[i] = new Staff();
        s[i].getStaffDetails();
    }
    foreach (var item in s)
    {
        if (item.designation == "HOD")
        {
            item.displayStaffDetails();
        }
    }
}
else if (n == 3)
{
    Bank_Account b1 = new Bank_Account();
    b1.getAccountDetails();
    b1.displayAccountDetails();
}
else if (n == 4)
{
    Student s = new Student();
    s.displayStudentDetails();
}
else if (n == 5)
{
    Console.WriteLine("Enter width and height of rectangle :");
    double w = Convert.ToDouble(Console.ReadLine());
    double h = Convert.ToDouble(Console.ReadLine());
    Rectangle r = new Rectangle(w, h);
    r.displayArea();
}
else if (n == 6)
{
    Interest interest = new Interest();
    interest.displayInterest();
}
else if (n == 7)
{
    Salary1 s = new Salary1();
    s.displaySalary();
}
else if (n == 8)
{
    Distance d = new Distance();
    d.add();
}
else if (n == 9)
{
    Table t = new Table();
    t.display();
}
else if (n == 10)
{
    Salary s = new Salary();
    s.displaySalary();
}
else
{
    Console.WriteLine("Not valid input");
}