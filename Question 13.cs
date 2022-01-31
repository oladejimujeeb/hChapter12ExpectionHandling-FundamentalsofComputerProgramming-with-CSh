using System.Net;
namespace Chapter12ExpectionHandling;

public class Question_13
{
    public static void Solution()
    {
        WebClient web = new WebClient();

        try 
        {
            web.DownloadFile("https://github.com/oladejimujeeb/Chapter11-Creatig-Object-FundamentalsofComputerProgramming-with-CSharp/blob/main/Program.cs", @"C:\Users\User\Desktop\code learners hub\Assignment\Program.cs");            
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (WebException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}