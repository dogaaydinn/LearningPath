namespace LearnProgramming.Conversion.ImplicitConversions;

public class ImplicitEnumerationConversions
{
    /*
     * Enum türünden int'e ve int'ten Enum türüne dönüşümler yapılabilir.
     */

    //TODO: İngilizce ekle

    public void ImplicitEnumerationConversionsMethod()
    {
        // Implicit conversion from Enum to int
        DayOfWeek day = DayOfWeek.Monday;
        int dayAsInt = (int)day; // Cast to int for explicit conversion

        // Implicit conversion from int to Enum
        int weekdayNumber = 2;
        DayOfWeek weekday = (DayOfWeek)weekdayNumber; // Cast from int to Enum for explicit conversion
    }

    public enum DayOfWeek
    {
        Monday  // Assigning explicit starting value
    }
    
}