namespace LearnProgramming.Operator;

public class DefaultOperator
{
    /*
     * belirtilen türün default değerini döndürür.
     */
    
    
    public void DefaultOperatorExample()
    {
        System.Console.WriteLine(default(int)); // 0
        System.Console.WriteLine(default(bool)); // False
        System.Console.WriteLine(default(string)); // null
    }
}