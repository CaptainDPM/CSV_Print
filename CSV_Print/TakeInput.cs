using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TakeInput
{
    public void Input()
    {
        string path = @"C:\addresses.csv";

        Console.WriteLine("Please enter first name.");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please enter last name.");
        string lastName = Console.ReadLine();
        Console.WriteLine("Please enter street address.");
        string streetAddress = Console.ReadLine();
        Console.WriteLine("Please enter city.");
        string city = Console.ReadLine();
        Console.WriteLine("Please enter state.");
        string state = Console.ReadLine();
        Console.WriteLine("Please enter a random number.");
        string lastNumber = Console.ReadLine();

        string[] data = { firstName, lastName, streetAddress, city, state, lastNumber };

        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine(string.Join(",", data));
        }

        Console.WriteLine("Data successfully written.");

    }
}