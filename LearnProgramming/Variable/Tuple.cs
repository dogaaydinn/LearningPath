namespace LearnProgramming.Variable;

public class Tuple
{
    //Tuple nedir?
    //Bir nesneyi birden fazla değişkenle tanımlamak için kullanılır.
    (string name, int age) tuple = ("John", 30);
    
    public static void main(string[] args)
    {
        int a = 10;
        int b = 20;
        (a, b) = (b, a);
        Console.WriteLine($"a: {a}, b: {b}");
        
    }
}