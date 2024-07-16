namespace LearnProgramming.Operator;

public class CastOperator
{
    /*
     1-unboxing
     2-explicit
     3-char türünün sayısal türlere cast edilmesi(ASCII kullanılarak)
     */
    
    public void ExampleCastOperator()
    {
        int a = 10;
        double b = a;
        Console.WriteLine(b);
        
        // Explicit Casting
        
        double c = 10.5;
        int d = (int) c;
        Console.WriteLine(d);
        
        // Unboxing
        
        object obj = 10;
        int e = (int) obj;
        Console.WriteLine(e);
        
        // Char to int
        
        char f = 'A';
        int g = f;
        Console.WriteLine(g);
    
        // ASCII to char
        
        int h = 65;
        char i = (char) h;
        Console.WriteLine(i);
    
        // Invalid Casting

        int j = 10;
        string k = j.ToString();
        Console.WriteLine(k);
        
    }
    
}