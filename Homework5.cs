namespace Homework5;


class Customer
{
    private int cus_id;
    public string cus_name { get; set;}
    public int cus_age { get; set;}

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer ID: {cus_id}, name: {cus_name}, age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer)
    {
        if (cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{cus_name} is older");
        }
        else
        {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(110, "Alice", 28);
        Customer cus2 = new Customer(111, "Bob", 30);

        cus1.PrintCusInfo();
        cus2.PrintCusInfo();

        cus1.ChangeID(220);
        cus2.ChangeID(221);

        cus1.PrintCusInfo();
        cus2.PrintCusInfo();

        cus1.CompareAge(cus2);
    }
}
