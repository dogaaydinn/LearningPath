using LearnProgramming.Conversion.ImplicitConversions;

namespace LearnProgramming.Conversion.ExplicitConversions;

public class ExplicitConversions
{
    public static void Main()
    {
        // Explicit conversions
        // 1) Implicit conversions, 2) explicit conversions, 3) User-Defined conversions and 4) Conversion with helper class
        // B1.Explicit conversions (Larger -> Smaller)
        double d = 123.4567;
        int nd = (int)d;   // Output: 123 

        // B2.Explicit conversions   (BaseClass -> DrivedClass)
        ClassBase Ba = new ClassBase();
        ClassDerived De= (ClassDerived)Ba;
    }
}