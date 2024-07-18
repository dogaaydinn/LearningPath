namespace LearnProgramming.Conversion.Exceptions;
using System;
public class InvalidCastException
{
    /*
     * Uyumsuz türler arasında explicit cast yapılmaya çalışıldığında ortaya çıkar.
     * Bu istisna, geliştiriciler bir nesnenin belirli bir türde olduğunu uygun bir kontrol yapmadan varsaydıklarında yaygın olarak görülür.
     */
    
    //TODO: İngilizce ekle
    public void InvalidCastExceptionExample()
    {
        object obj = "1234";
        int number = (int)obj; // InvalidCastException
        
        Console.WriteLine(number);
        // Output: 1234
        
        int? nullableNumber = (int?)obj; // Valid conversion
        Console.WriteLine(nullableNumber);
        // Output: 1234
        
        Console.WriteLine(nullableNumber.HasValue);
        // Output: True
        
        Console.WriteLine(nullableNumber.Value);
        // Output: 1234
        
        int nonNullableNumber = Convert.ToInt32(obj); // No exception thrown
        Console.WriteLine(nonNullableNumber);
        // Output: 1234
        
        try
        {
            int nonNullableNumber2 = Convert.ToInt32(null); // Throws ArgumentNullException
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("Input is null");
        }
        // Output: Input is null
        int nonNullableNumber3 = int.Parse(obj.ToString()); // No exception thrown
        Console.WriteLine(nonNullableNumber3);
        // Output: 1234
        
        bool success = int.TryParse(obj.ToString(), out nonNullableNumber); // Correctly returns true
        Console.WriteLine(success);
        // Output: True
        Console.WriteLine(nonNullableNumber);
        // Output: 1234
        
    }
}