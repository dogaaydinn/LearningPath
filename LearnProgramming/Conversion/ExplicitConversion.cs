using LearnProgramming.Conversion.ImplicitConversions;

namespace LearnProgramming.Conversion;

public class ExplicitConversion
{
    /*
     * An explicit numeric conversion might result in data loss or throw an exception, typically an OverflowException.
     */
    
    /*
     * Bir ondalık değeri bir integral türüne dönüştürdüğünüzde, bu değer sıfıra doğru en yakın integral değerine yuvarlanır. Elde edilen integral değer hedef türün aralığının dışındaysa, bir OverflowException iletisi atılır.
     * Bir double veya float değerini bir integral türüne dönüştürdüğünüzde, bu değer sıfıra doğru en yakın integral değerine yuvarlanır. Elde edilen integral değer hedef türün aralığının dışındaysa, sonuç taşma denetimi bağlamına bağlıdır. Kontrol edilen bir bağlamda, bir OverflowException fırlatılırken, kontrol edilmeyen bir bağlamda sonuç, hedef türün belirtilmemiş bir değeridir.
     */
    
    
    public void ExplicitConversionExample()
    {
        double x = 1234.7;
        int a;
        // Cast double to int.
        a = (int)x;
        System.Console.WriteLine(a);
        
        int y = 123;
        long b = y;      // implicit conversion from int to long
        int c = (int) b; // explicit conversion from long to int
    }

    // B2.Explicit conversions   (BaseClass -> DrivedClass)
    static ClassBase Ba = new ClassBase();
    ClassDerived De= (ClassDerived)Ba;

}