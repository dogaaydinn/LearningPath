namespace LearnProgramming.Expressions;

public class TuplePattern
{
    /*
     Switch yapılanmasını Tuple nesnelerini kontrol edebilecek şekilde hem standart hem de yeni yapılanma ile kullanabiliriz.
     */
    
    public void TuplePatternExample()
    {
        string name = "Doğa";
        int age = 23;
        
        string message = (name, age) switch
        {
            ("Doğa", 23) => "Doğa 23 yaşında",
            ("Ahmet", 25) => "Ahmet 25 yaşında",
            _ => "Bilinmeyen"
        
            // eğer tuple'nin değerleri değişkenler olarak kullanılacaksa, tuple'in değerlerini parantez içine yazıyoruz ve parantezlerin içinde değişkenler yazılır.
            // (string n, int a) => "Doğa " + a + " yaşında"
        };
            
        Console.WriteLine(message);
        
    }


    public void TuplePatternExample2()
    {
        //using when
        
        (string name, int age) = ("Doğa", 23);
        
        string message = (name, age) switch
            
        {
            ("Doğa", 23) when age > 20 => "Doğa 23 yaşında",
            ("Ahmet", 25) => "Ahmet 25 yaşında",
            _ => "Bilinmeyen"
        
        };
            
        Console.WriteLine(message);
                
    }
}