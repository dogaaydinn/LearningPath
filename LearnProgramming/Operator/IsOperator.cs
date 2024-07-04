namespace LearnProgramming.Operator;

public class IsOperator
{
    /*
     * Explicit dönüşüm işlemine başlamadan önce, is operatörü ile bir nesnenin belirli bir türle uyumluluğunu kontrol etmek için kullanılabilir ve dönüştürme işlemini gerçekleştirmeden önce güvenliği sağlayabilirsiniz.
     */
    
    
    public void IsOperatorExample()
    {
        object[] values = { 1, "2", null, new AsOperator() };
        foreach (var value in values)
        {
            if (value is string)
            {
                System.Console.WriteLine(value);
            }
        }
        // Output:
        // 2
    }
}