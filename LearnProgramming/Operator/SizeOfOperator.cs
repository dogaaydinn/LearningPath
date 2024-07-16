namespace LearnProgramming.Operator;

public class SizeOfOperator
{
    /*
     * Verilen türün bellekte kaç byte yer kapladığını integer olarak gösterir.
     */

    public void ExampleSizeOfOperator()
    {
        Console.WriteLine(sizeof(int)); // Output: 4
        Console.WriteLine(sizeof(double)); // Output: 8
       // Console.WriteLine(sizeof(string)); // Output: 24 (string tipindeki her karakter 2 byte)
        Console.WriteLine(sizeof(char)); // Output: 2
    }
}