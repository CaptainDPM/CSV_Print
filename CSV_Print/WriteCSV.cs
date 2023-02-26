//Write to the local CSV file//

public class WriteCSV
{
    public void Write()
    {
        string path = @"C:\addresses.csv";

        string[] data = { "First", "Last", "Address", "Address2", "State", "Last Number" };

        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine(string.Join(",", data));
        }

        Console.WriteLine("Data successfully written.");
    }
}

