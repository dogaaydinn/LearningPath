namespace LearnProgramming.Expressions.Pattern.C_7;

public class ConstantPattern
{
    /*
     - Constant Pattern
       *they check if the incoming value equals a constant value.
     */
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    
    //statik değerleri veya null durumunu kontrol etmek için kullanılır.
    
    //Örnek 1
    public void CheckConstantPattern()
    {
        object obj = 5;
        if (obj is 5)
        {
            Console.WriteLine("The value is 5");
        }
    }
    
    //Örnek 2-Kritik

    public void CheckConstantPattern2()
    {
        int a = 5;
        Console.WriteLine(a is int); // klasik is operator kullanımı
        
        //C# 7.0 ile gelen özellik
        Console.WriteLine(a is 5); // constant pattern kullanımı
        
        //eğer is operatorüyle bir değişkenin değerini == operatörüyle karşılaştırıyorsak, bu duruma constant pattern denir.
    }
}