namespace LearnProgramming.Variable;

public class DeepCopy
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    
    /*
     * Deep copy sonucunda eldeki veri çoğalır.
     * Yani, yeni bir bellek alanı oluşturulur ve bu alana kopyalanan veri yazılır.
     * Bu işlem sonucunda, orijinal veri ile kopyalanan veri birbirinden bağımsız hale gelir.
     * Bu işlem sonucunda, orijinal veri değişse bile kopyalanan veri değişmez.
     * Bu işlem sonucunda, kopyalanan veri değişse bile orijinal veri değişmez.
     * Bu işlem sonucunda, orijinal veri ve kopyalanan veri birbirinden bağımsızdır.
     */
    
    /*
     * Value type ve Reference type veri tipleri için deep copy işlemi farklıdır.
     * Value type veri tipleri birbirlerine assign edilirken default olarak deep copy kullanırlalr.
     */
    
    public static void DeepCopyMethod()
    {
        int number = 10;
        int copyNumber = number;
        
        Console.WriteLine($"number: {number}, copyNumber: {copyNumber}");
        
        number = 20;
        
        Console.WriteLine($"number: {number}, copyNumber: {copyNumber}");
    }
    
}

public class Person :ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}

