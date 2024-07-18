namespace LearnProgramming.Conversion.Exceptions;

public class FormatException : Exception
{
    /*
     Bir değerin biçimi, amaçlanan dönüştürme türü için geçersiz olduğunda oluşur.
      Bu, giriş dizesi uygun bir sayısal formatta olmadığında int.Parse gibi ayrıştırma yöntemlerinde yaygındır.
     */
    
    //TODO: İngilizce ekle
    public void FormatExceptionExample()
    {
        string input = "1234";
        int number = 0;
        try
        {
            number = int.Parse(input);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Input is not a number");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred");
        }
        Console.WriteLine(number);
    }
}