using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal
{
    public List<Entry>_entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
           entry.Display(); 
        }
    }
    public void SaveToFile()
    {
        Console.WriteLine("Enter filename:");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entries)
            {
            writer.WriteLine(entry.GetFileFormat());
            }
        }
    } 
    public void LoadFromFile()
    {
        Console.WriteLine("Enter file name");
        string fileName = Console.ReadLine();
        using (StreamReader read = new StreamReader(fileName))
        {
            _entries.Clear();
            string line;
            while((line = read.ReadLine()) != null)
            {
              string [] parts = line.Split("|");
              Entry newEntry = new Entry();
              newEntry._date = parts[0];
              newEntry._promptText = parts[1];
              newEntry._entryText = parts[2];
              AddEntry(newEntry);
            }
            
        }
    }
    
}