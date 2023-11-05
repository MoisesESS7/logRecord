using Log.Entities;

Console.Write("Enter file full path: ");
string? path = Console.ReadLine();

HashSet<LogRecord>? users = new HashSet<LogRecord>();

try
{
    using(StreamReader sr = File.OpenText(path))
    {
        while(!sr.EndOfStream)
        {
            string? line = sr.ReadLine();
            users.Add(new LogRecord(line));
        }
        Console.WriteLine("Total users: " + users.Count);
    }
}
catch(IOException e)
{
    Console.WriteLine(e.Message);
}
