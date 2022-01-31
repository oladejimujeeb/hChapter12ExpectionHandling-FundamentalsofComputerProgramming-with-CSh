namespace Chapter12ExpectionHandling;

public class Question12
{
    public static void Solution()
    {
        Console.Write("Enter the directory of the file:");
        string path = Console.ReadLine();
        Question12.ReadFile(path);
    }
    private static void ReadFile(string path)
    {
        string text ="";
        try
        {
            text = System.IO.File.ReadAllText(path);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine($"The specified path is invalid!: {e.Message}");
        }
        catch (IOException e)
        {
            Console.WriteLine($"Invalid syntax!{e.Message}");
        }
        finally
        {
            Console.WriteLine(text);
        }
       
    }
}