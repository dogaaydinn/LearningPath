namespace LearnProgramming.Operator;

public class AsOperator
{
    /*
     * As operatörü, birbirleriyle uyumlu referans türleri veya nullable türler arasında dönüşüm yapar.
     */


    public static void Main()
    {
        object[] values = { 1, "2", null, new AsOperator() };
        foreach (var value in values)
        {
            string s = value as string;
            System.Console.WriteLine(s == null ? "null" : s);
        }
        // Output:
        // 1
        // 2
        // null
        // null
        
    }
}

