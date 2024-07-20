namespace LearnProgramming.Expressions.Pattern.C_9;

public class LogicalPattern
{
    //TODO:Açıklama ve örnek ekle.
    
    /*
     * relational pattern ile uyumludur.
     * and, or ve not gibi mantıksal operatörler kullanılabilmektedir
     */
    
    //örnek 1-is İfadesi ile Relational Pattern

    public void Example1()
    {
        int age = 25;

        if (age is >= 18 and < 65)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are either a minor or a senior.");
        }
    }
    
    
    //örnek 2-switch İfadesi ile Relational Pattern

    public void Example2()
    {
        int temperature = 30;

        string weatherDescription = temperature switch
        {
            <= 0 => "Freezing",
            <= 10 => "Cold",
            <= 20 => "Cool",
            <= 30 => "Warm",
            _ => "Hot"
        };

        Console.WriteLine($"The weather is {weatherDescription}.");

    }
    
    //örnek 3-and ve or Operatörleri ile Relational Pattern

    public void Example3()
    {
        int number = 42;

        string numberCategory = number switch
        {
            < 0 => "Negative",
            >= 0 and < 10 => "Single digit",
            >= 10 and < 100 => "Double digits",
            _ => "Large number"
        };

        Console.WriteLine($"The number is categorized as: {numberCategory}.");

    }
    
}