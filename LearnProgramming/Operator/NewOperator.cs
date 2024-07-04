namespace LearnProgramming.Operator;

public class NewOperator
{
    /*
     C# dilindeki "new" anahtar kelimesinin ve değer tiplerinin (value types) varsayılan değerlerinin nasıl çalıştığı anlatılmak istenmiştir. İşte ana noktalar:
       
       "new" anahtar kelimesi: C#'ta "new" kelimesi genellikle bir nesne oluşturmak için kullanılır, ancak değer tipleri için de kullanılabilir.
       Değer tiplerinin başlatılması: Değer tipleri (int, bool, float gibi) "new" ile başlatıldığında, varsayılan değerlerini alırlar.
       Örnekler:
       "int a = new int();" ifadesi, 'a' değişkenine varsayılan int değeri olan 0'ı atar.
       "bool b = new bool();" ifadesi, 'b' değişkenine varsayılan bool değeri olan false'u atar.
       
     */
    
    
    /*
     * The new operator creates a new instance of a type.
     * New can use for 2 different purposes:
     * You can also use the new keyword as a member declaration modifier or a generic type constraint.
     */
    
    public static void Main()
    {
        int a = new int();
        bool b = new bool();
        Console.WriteLine($"Default value of int: {a}");
        Console.WriteLine($"Default value of bool: {b}");
    }
}