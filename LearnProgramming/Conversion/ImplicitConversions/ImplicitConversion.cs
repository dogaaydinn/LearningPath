namespace LearnProgramming.Conversion.ImplicitConversions;


public class ImplicitConversion
{
    /*
     * Bir sayısal değer kendi türünden daha büyük değer aralığına sahip olan diğer türlere dönüştürülürken, burada herhangi bir işlem yapmamıza gerek kalmayacağı için bu dönüşüme implicit conversion(bilinçsiz tür dönüşümü) denir.
     * Bir sayısal değer kendi türündendaha küçük değer aralığına sahip olan diğer türlere dönüştürülürken, hedef türün ilgili veriyi karşılayamama riskinden dolayı burada herhangi bir işlem yapmamız gerekeceği için bu dönüşüme explicit conversion(bilinçli tür dönüşümü) denir.
     */

    /*
     * There are no implicit conversions to the byte and sbyte types. There are no implicit conversions from the double and decimal types.

       There are no implicit conversions between the decimal type and the float or double types.
     */

    /*
     * !!!!!!By eliminating unnecessary casts, implicit conversions can improve source code readability. However, because implicit conversions can occur without the programmer's specifying them, care must be taken to prevent unpleasant surprises. In general, implicit conversion operators should never throw exceptions and never lose information so that they can be used safely without the programmer's awareness. If a conversion operator cannot meet those criteria, it should be marked explicit.
     */
    /*
     *
       int, uint, long veya ulong'dan float'a ve long veya ulong'dan double'a dönüşümler hassasiyet kaybına neden olabilir, ancak asla büyüklük kaybına neden olmaz. Diğer örtük sayısal dönüşümler hiçbir zaman bilgi kaybına neden olmaz.

       Char türüne önceden tanımlanmış örtük dönüştürmeler yoktur, bu nedenle diğer integral türlerinin değerleri otomatik olarak char türüne dönüştürülmez.


       1-Identity conversions
       2-Implicit numeric conversions
       3-Implicit enumeration conversions
       Implicit interpolated string conversions
       Implicit reference conversions
       Boxing conversions
       Implicit dynamic conversions
       Implicit type parameter conversions
       Implicit constant expression conversions
       User-defined implicit conversions
       Anonymous function conversions
       Method group conversions
       Null literal conversions
       Implicit nullable conversions
       Implicit tuple conversions
       Lifted user-defined implicit conversions
       Default literal conversions
       Implicit throw conversion


     */
    public static void Main()
    {
        // Implicit conversion. A long can
        // hold any value an int can hold, and more!
        long l = 1234567890123456789;
        int i = (int)l;
        Console.WriteLine(i); // Output: 1234567890123456789
        
        // A1. Implicit conversions  (Smaller -> Larger)
        int x = 100;
        double y = x;

        // A2.Implicit conversions  (DrivedClass -> BaseClass)
        ClassDerived D = new ClassDerived();
        ClassBase B = D;
    }
    
}