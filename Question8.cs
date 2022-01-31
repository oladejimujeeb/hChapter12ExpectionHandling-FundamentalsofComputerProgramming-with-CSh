namespace Chapter12ExpectionHandling;

public class Question8
{
    public static void Solution()
    {
        Console.Write("Enter Start number:");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter End number:");
        int end = Convert.ToInt32(Console.ReadLine());
        Question8.ReadNumber(start,end);
    }
    public static void ReadNumber(int start, int end)
    {
        int count = 1;
        while (count<=10 )
        {
            Console.Write($"Enter number{count}: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= end || number <= start)
            {
                Console.WriteLine("Number not in range");
            }
        
            else
            {
                start = number;
            }
            count++;
        }
    }
}