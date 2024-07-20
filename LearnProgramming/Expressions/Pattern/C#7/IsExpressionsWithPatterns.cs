namespace LearnProgramming.Expressions.Pattern.C_7;

public class IsExpressionsWithPatterns
{
    /*
     * is ifadesi;
     -bir nesnenin belirli bir türe sahip olup olmadığını kontrol etmek 
     - aynı zamanda o türde bir değişkene atamak için kullanılır.
     */
    
    //Örnek 1
    public void IsExpression()
    {
        object obj = "Merhaba, Dünya!";

        if (obj is string str)
        {
            Console.WriteLine($"Nesne bir string ve değeri: {str}");
        }
        else
        {
            Console.WriteLine("Nesne bir string değil.");
        }

    }
}