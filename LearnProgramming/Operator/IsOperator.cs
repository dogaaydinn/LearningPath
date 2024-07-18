namespace LearnProgramming.Operator;

public class IsOperator
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    
    /*
     * Explicit dönüşüm işlemine başlamadan önce, is operatörü ile bir nesnenin belirli bir türle uyumluluğunu kontrol etmek için kullanılabilir ve dönüştürme işlemini gerçekleştirmeden önce güvenliği sağlayabilirsiniz.
     */
    
    //boxinge tabi tutulan bir değerin türünü öğrenmek için kullanılır.
    //sonucunda true veya false döner.
    
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