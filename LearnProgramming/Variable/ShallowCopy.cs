namespace LearnProgramming.Variable;

public class ShallowCopy
{
    /*
     * Shallow Copy
     * Referans tipli değişkenlerin değer atamalarında değeri çoğaltmak yerine, var olan değeri birden fazla referansla işaretleyerek kopyalama yapılır.
     * Bellekte birden fazla referansın aynı değeri işaret etmesi durumudur.
     */
    
    public static void ShallowCopyMethod()
    {
        int[] numbers = {1, 2, 3, 4, 5};
        int[] copyNumbers = numbers;
        
        Console.WriteLine("numbers:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        
        Console.WriteLine("copyNumbers:");
        foreach (var number in copyNumbers)
        {
            Console.WriteLine(number);
        }
        
        numbers[0] = 10;
        
        Console.WriteLine("numbers:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        
        Console.WriteLine("copyNumbers:");
        foreach (var number in copyNumbers)
        {
            Console.WriteLine(number);
        }
    }
    
}