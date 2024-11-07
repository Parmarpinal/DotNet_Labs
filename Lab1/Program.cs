using Lab1;

Console.WriteLine("Enter which program you want to run ?");
int n = Convert.ToInt32(Console.ReadLine());
switch (n)
{
    case 1:
        {
            Console.WriteLine("Name = Pinal");
            Console.WriteLine("Address = Shraddha nagar-2, Aahir chowk");
            Console.WriteLine("Contact No. = 9999988888");
            Console.WriteLine("City = Rajkot");
            break;
        }
    case 2:
        {
            Console.WriteLine("Enter two numbers :");
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Entered numbers are " + a + " and " + b);
            break;
        }
    case 3:
        {
            Console.WriteLine("Enter your name and country name :");
            string name = Console.ReadLine();
            string country = Console.ReadLine();
            Console.WriteLine($"Hello {name} from country {country}");
            break;
        }
    case 4:
        {
            Console.WriteLine("Enter length and width in feet :");
            double l = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area = {l * b} sq. ft.");
            break;
        }
    case 5:
        {
            Console.WriteLine("Enter radius of circle :");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area of circle = {Math.PI * r * r}");
            Console.WriteLine("Enter length of square :");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area of square = {s * s}");
            Console.WriteLine("Enter length and width of rectangle :");
            double l = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area of rectangle = {l * b}");
            break;
        }
    case 6:
        {
            Temperature tp = new Temperature();
            tp.celciusToFerenhit();
            tp.ferenhitToCelcius();
            break;
        }
    case 7:
        {
            Interest interest = new Interest();
            interest.calculateInterest();
            break;
        }
    case 8:
        {
            Calculator calculator = new Calculator();
            calculator.perform();
            break;
        }
    case 9:
        {
            Console.WriteLine("Enter two numbers :");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"no1 = {a} and no2 = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swapping :");
            Console.WriteLine($"no1 = {a} and no2 = {b}");
            break;
        }
    case 10:
        {
            Console.WriteLine("Enter three numbers :");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
            Console.WriteLine("Maximum no = " + max);
            break;
        }
    default:
        {
            Console.WriteLine("================= Invalid input ===============");
            break;
        }
}

