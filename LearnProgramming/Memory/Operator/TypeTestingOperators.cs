namespace LearnProgramming.Operator;

public class TypeTestingOperators
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    
    /*
     * Verilen türlerin denetimini veya dönüşümünü yapar.
     */
    
    /*
     * is işleci, bir ifadenin çalışma zamanı türünün belirli bir türle uyumlu olup olmadığını denetler.
     * as işleci, çalışma zamanı türü verilen türle uyumluysa bir ifadeyi açıkça verilen türe dönüştürür. 
     */

    public void Example()
    {
        object obj = "Hello World";

        // is operatörü ile obj'nin string türünü kontrol ediyoruz.
        if (obj is string)
        {
            // obj'nin string türünde olduğunu varsayıyoruz ve string türünde işlem yapıyoruz.
            Console.WriteLine("obj is string");
        }

        // as operatörü ile obj'nin string türünde olduğunu varsayıyoruz ve string türünde obj'nin değerini alıyoruz.
        string str = obj as string;
        if (str!= null)
        {
            Console.WriteLine("str is string and its value is: " + str);
        }
        
        // as operatörü ile obj'nin string türünde olmadığını varsayıyoruz ve string türünde obj'nin değerini alıyoruz.
         str = obj as string;
         if (str == null)
         {
             Console.WriteLine("obj is not string");
         }
         
    }
}