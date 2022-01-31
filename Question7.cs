
namespace Chapter12ExpectionHandling;

public class Question7
{
    public static void Solution()
    {
        int integer = Int32.MinValue;
        Console.Write("Enter number: ");
        string input = Console.ReadLine();
        try
        {
            integer = Convert.ToInt32(input);
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Invalid number! {e.Message}");
        }
        finally
        {
            if (integer > 0)
            {
                Console.WriteLine(Math.Sqrt(integer));
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
        Console.WriteLine("Goodbye");
    }
}