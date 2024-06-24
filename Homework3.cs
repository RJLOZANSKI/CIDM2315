namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Question 1
        Console.WriteLine("Input an integer: ");
        int N1 = Convert.ToInt16(Console.ReadLine());
        int i;

        for(i = 2; i < N1; i++)
        {
            if (N1 % i == 0)
            {
                Console.WriteLine("N is non-prime");
                break;
            }
            
        }
        if (i == N1)
        {
            Console.WriteLine("N is prime");
        }   

        //Question 2
        Console.WriteLine("Assign an int value to N: ");
        int N2 = Convert.ToInt16(Console.ReadLine());

        for(int row = 0; row < N2; row++){
            for(int col = 0; col < N2; col++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }

        //Question 3
        Console.WriteLine("Assign an int value to N: ");
        int N3 = Convert.ToInt16(Console.ReadLine());

        for(int row = 0; row < N3; row++){
            for(int col = 0; col < N3; col++)
            {
                if(row>=col)
                    Console.Write("*");
            }
            Console.WriteLine("");
        }

        //Bonus Question
        Console.WriteLine("Assign an int value to N: ");
        int N4 = Convert.ToInt16(Console.ReadLine());

        for (int x = 1; x <= N4; x++)
            {
                for (int row = 0; row < N4 - x; row++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col < x; col++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
    }   
}
