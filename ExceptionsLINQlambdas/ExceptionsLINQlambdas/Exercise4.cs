using System;
public class Exercise4
{
	public static void Ex4()
	{
        Console.Write("Enter a file name: ");
        string file = Console.ReadLine();
        try
        {
            FileInfo fileInfo = new FileInfo(file);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            {
                if (!fileInfo.Exists)
                {
                    Console.WriteLine("Tha file does not exist");
                }
                else if (fileInfo.Length == 0)
                {
                    Console.WriteLine("The file is empty");
                }
                Console.Write("Enter some text to write to the file:");
                string text = Console.ReadLine();
                File.WriteAllText(file, text);
            }
            Console.WriteLine("File contents: ");
            Console.Write(File.ReadAllText(file));
            Console.WriteLine(" ");
        }
        catch (IOException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        
    }
}



