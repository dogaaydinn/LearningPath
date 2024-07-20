namespace LearnProgramming.Expressions.Pattern.C_9;

public class SimpleTypePattern
{
    /*
     * Bir değişkenin belirli bir türde olup olmadığını hızlı bir şekilde kontrol etmemizi sağlayan desendir.
     */
    
    //C#9 öncesi tür kontrolü yapılırken 2 şekilde type kontrolü yapılıyordu.
    //1- değişken adı tanımlaması
    //2- discard ifadesi kullanılması
    
    //örnek 1- c#9 öncesi
    public void BeforeC_9()
    {
        object obj = new object();
        switch (obj)
        {
            case object o: //değişken adı tanımlaması
                Console.WriteLine("object");
                break;
        }
        
    }
    
    //örnek 2- artık değişkene atama yapılmayacaksa değişkeni tanımlama zorunluluğu yok.
    public void AfterC_9()
    {
        object obj = new object();
        switch (obj)
        {
            case object: //değişken adı tanımlaması zorunlu değil. Atama yapılsaydı zorunlu olurdu.
                Console.WriteLine("object");
                break;
        }
    }
    
    //örnek 3- discard ifadesi kullanımı C#9 öncesi
    public void BeforeC_9_2()
    {
        string GetTypeName(object obj) => obj switch
        {
            int _ => "int", //discard ifadesi
            string _ => "string",
            object _ => "object",
            _ => "unknown"
        };
    }
    
    //örnek 4- discard ifadesi kullanımı C#9 sonrası

    public void AfterC_9_2()
    {
        string GetTypeName(object obj) => obj switch
        {
            int  => "int", //discard ifadesi yok
            string  => "string",
        };
    }
}