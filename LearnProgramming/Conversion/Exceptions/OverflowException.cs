namespace LearnProgramming.Conversion.Exceptions;

public class OverflowException : Exception
{
    /*
     Bir dönüştürme işlemi hedef veri türünün aralığı dışında bir değerle sonuçlandığında oluşur.
     */

    public void OverflowExceptionExample()
    {
        int number = int.MaxValue;
        try
        {
            number++;
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Value is too large");
        }
        Console.WriteLine(number);
    }
}