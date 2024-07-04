namespace LearnProgramming.Keywords;

public class DefaultKeyword
{
    /* Default Keyword
     * içerisine verilen türün varsayılan değerini verir.
     */
    bool x =default;
    int y = default;
    
    public static void Main()
    {
        DefaultKeyword defaultKeyword = new DefaultKeyword();
        Console.WriteLine($"Default value of bool: {defaultKeyword.x}");
        Console.WriteLine($"Default value of int: {defaultKeyword.y}");
    }
}