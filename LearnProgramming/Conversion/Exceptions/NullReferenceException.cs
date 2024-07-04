namespace LearnProgramming.Conversion.Exceptions;

public class NullReferenceException
{
    /*
     Null olan bir türdeki bir üyeye (yöntem veya özellik gibi) erişilmeye çalışıldığında oluşur. 
     Bu, tür dönüştürme başarısız olduğunda ve düzgün şekilde kontrol edilmediğinde meydana gelebilir.
     */
    public static void Main()
    {
        object obj = null;
        string str = obj as string;
        Console.WriteLine(str);
        // Output:
        // Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
    }
}