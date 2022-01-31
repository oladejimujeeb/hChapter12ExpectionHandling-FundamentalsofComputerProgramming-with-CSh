namespace Chapter12ExpectionHandling;
using System.IO;

public class Question9
{
    public static void Solution()
    {
        try
        {
            using (StreamReader read = new StreamReader("itro.txt"))
            {
                String line = read.ReadToEnd();
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException e) 
        {
            Console.WriteLine($"The file could not be read: {e.Message}");
        }
    }
}