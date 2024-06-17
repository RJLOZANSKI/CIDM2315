namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade:");
        string grade = Console.ReadLine();

        switch (grade)
        {
            case "A":
                Console.WriteLine("GPA point: 4");
                break;
            case "B":
                Console.WriteLine("GPA point: 3");
                break;
            case "C":
                Console.WriteLine("GPA point: 2");
                break;
            case "D":
                Console.WriteLine("GPA point: 1");
                break;
            case "F":
                Console.WriteLine("GPA point: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;                    
        }

        Console.WriteLine("Please input the first num:");
        string num1_string = Console.ReadLine();
        int num1 = Convert.ToInt16(num1_string);

        Console.WriteLine("Please input the second num:");
        string num2_string = Console.ReadLine();
        int num2 = Convert.ToInt16(num2_string);

        Console.WriteLine("Please input the third num:");
        string num3_string = Console.ReadLine();
        int num3 = Convert.ToInt16(num3_string);

        if(num1<num2){
            if(num1<num3){
                Console.WriteLine($"The smallest value is: {num1}");
            }
            else{
                Console.WriteLine($"The smallest value is: {num3}");
            }
        }
        else{
            if(num2<num3){
                Console.WriteLine($"The smallest value is: {num2}");
            }
            else{
                Console.WriteLine($"The smallest value is: {num3}");
            }
        }

        Console.WriteLine("Please input a year :");
        string year_string = Console.ReadLine();
        int year = Convert.ToInt16(year_string);

        if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
            Console.WriteLine($"{year} is a Leap Year.");
        }
        else{
            Console.WriteLine($"{year} is not a Leap Year.");
        }
    }
}
