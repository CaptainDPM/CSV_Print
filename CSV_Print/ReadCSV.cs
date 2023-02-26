public class ReadCSV
{
    public void Read()
    {
        //Use a CSV file to print to console//

        string path = @"C:\addresses.csv";

        List<string[]> data = new List<string[]>();

        using (StreamReader streamReader = new StreamReader(path))
        {
            while (!streamReader.EndOfStream)
            {
                string[] line = streamReader.ReadLine().Split(',');
                data.Add(line);
            }
        }
        foreach (string[] field in data)
        {
            foreach (string value in field)
            {
                Console.Write(value + "\t");
            }
            Console.WriteLine();
        }

    }
}