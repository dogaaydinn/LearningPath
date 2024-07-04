namespace LearnProgramming.Conversion.Exceptions;

public class Try_Catch
{
    /*
     * Try-Catch is a way to handle exceptions in C#.
     */
    public static void Main()
    
    {
        string input = "1234";
        int number = 0;
        try
        {
            number = int.Parse(input);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Input is not a number");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred");
        }
        Console.WriteLine(number);
    }
}