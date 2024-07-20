namespace LearnProgramming.Expressions.Pattern.C_9;

public class RelationalPattern
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    //https://blog.jetbrains.com/dotnet/2019/07/09/recursive-pattern-matching-look-new-language-features-c-8/
    
    //TODO:Mülakat sorusu: Switch ve if arasındaki farklar nelerdir? videoyu izle
    //https://www.youtube.com/watch?v=leTIFM4578Q&list=PLQVXoXFVVtp3e_urGZcMNAHx2Eo4Rm5Xk&index=170
    
    /*
     * Relational pattern, C# 9.0 ile tanıtılan ve ilişkisel operatörler kullanarak değerleri karşılaştırmak için kullanılan bir pattern matching özelliğidir.
     * Relational pattern, is ifadesi ve switch ifadeleri ile kullanılabilir
     * ==, !=, <, <=, > ve >= gibi operatörleri destekler.
     */
    
    //örnek 1- is İfadesi ile Relational Pattern
    public void RelationalPatternExample1()
    {
        int number = 42;

        if (number is > 0 and < 100)
        {
            Console.WriteLine("Number is between 0 and 100.");
        }
        else
        {
            Console.WriteLine("Number is not between 0 and 100.");
        }

    }
    
    //örnek 2- Switch İfadesi ile Relational Pattern

    public void RelationalPatternExample2()
    {
        int temperature = 25;

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

    public void RelationalPatternExample3()
    {
        int age = 25;

        string ageCategory = age switch
        {
            <= 12 => "Child",
            > 12 and < 20 => "Teenager",
            >= 20 and <= 64 => "Adult",
            >= 65 => "Senior"
        };

        Console.WriteLine($"The person is an {ageCategory}.");

    }
    
}