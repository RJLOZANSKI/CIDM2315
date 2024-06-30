namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Q1
        int inputNum1, inputNum2;
        GetNumbersTwo(out inputNum1, out inputNum2);
        Console.WriteLine($"a = {inputNum1}; b = {inputNum2}");
        int _LargestOfTwo = GetLargestOfTwo(inputNum1, inputNum2);
        Console.WriteLine($"The largest number is: {_LargestOfTwo}");

        //Q2
        int inputNum3, inputNum4, inputNum5, inputNum6;
        GetNumbersFour(out inputNum3, out inputNum4, out inputNum5, out inputNum6);
        Console.WriteLine($"a = {inputNum3}; b = {inputNum4}; c = {inputNum5}; d = {inputNum6}");
        int _LargestOfFour = GetLargestOfFour(inputNum3, inputNum4, inputNum5, inputNum6);
        Console.WriteLine($"The largest number is: {_LargestOfFour}");

        //Q3
        createAccount();
    }

    //Q1 Method1
    static void GetNumbersTwo(out int num1, out int num2)
    {
        Console.WriteLine("Please input two integers: ");
        num1 = Convert.ToInt16(Console.ReadLine());
        num2 = Convert.ToInt16(Console.ReadLine());
    }

    //Q2 Method1
    static void GetNumbersFour(out int num3, out int num4, out int num5, out int num6)
    {
        Console.WriteLine("Please input four integers: ");
        num3 = Convert.ToInt16(Console.ReadLine());
        num4 = Convert.ToInt16(Console.ReadLine());
        num5 = Convert.ToInt16(Console.ReadLine());
        num6 = Convert.ToInt16(Console.ReadLine());
    }

    //Q1 Method2
    static int GetLargestOfTwo(int num1, int num2)
    {
        return num1 > num2 ? num1 : num2;
    }

    //Q2 Method2
    static int GetLargestOfFour(int a, int b, int c, int d)
    {
        int max1 = GetLargestOfTwo(a , b);
        int max2 = GetLargestOfTwo(c, d);
        return GetLargestOfTwo(max1, max2);
    }

    //Q3 Method1
    static bool checkAge(int birth_year)
    {
        int age = 2022 - birth_year;
        return age >= 18;
    }

    //Q3 Method2
    static void createAccount()
    {
        Console.WriteLine("Enter Your Username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter Your Password: ");
        string password = Console.ReadLine();

        Console.WriteLine("Enter Your Password Again: ");
        string password2 = Console.ReadLine();

        Console.WriteLine("Enter Your Birthyear: ");
        int birth_year = Convert.ToInt16(Console.ReadLine());

        if(checkAge(birth_year))
        {
            if (password == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account.");
        }
    }
}

