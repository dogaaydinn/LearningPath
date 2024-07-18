namespace LearnProgramming.Operator;

public class AsOperator
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    
    /*
     * As operatörü, birbirleriyle uyumlu referans türleri veya nullable türler arasında dönüşüm yapar.
     */
    
    //cast operatorün Unboxing işlemine alternatif olarak üretilmiştir.
    
    
    /*
     * !!as işleci, bir ifadenin sonucunu verilen bir başvuruya veya nullable değer türüne açıkça dönüştürür. Dönüştürme mümkün değilse, as işleci null döndürür.
     * !!!Cast ifadesinin aksine, as işleci hiçbir zaman bir istisna atmaz.
     */
    
    //dönüştürmenin başarılı olup olmadığını kontrol etmek için as ifadesinin sonucunu null ile karşılaştırmanız gerekir.

    //TODO: gençay yıldız 121. videoyu izle

    public void AsOperatorExample()
    {
        object[] values = { 1, "2", null, new AsOperator() };
        foreach (var value in values)
        {
            string s = value as string;
            System.Console.WriteLine(s == null ? "null" : s);
        }
        // Output:
        // 1
        // 2
        // null
        // null
        
    }
}

