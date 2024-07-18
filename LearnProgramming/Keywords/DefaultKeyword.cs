namespace LearnProgramming.Keywords;

public class DefaultKeyword
{
    /* Default Keyword
     * içerisine verilen türün varsayılan değerini verir.
     */
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    bool x =default;
    int y = default;
    
    public void DefaultKeywordExample()
    {
        DefaultKeyword defaultKeyword = new DefaultKeyword();
        Console.WriteLine($"Default value of bool: {defaultKeyword.x}");
        Console.WriteLine($"Default value of int: {defaultKeyword.y}");
    }
}