namespace LearnProgramming.Conversion.ImplicitConversions;


public class IdentityConversions
{
    /*
     * Bir kimlik dönüşümü, herhangi bir türden aynı türe veya çalışma zamanında eşdeğer olan bir türe dönüştürür.
     * Bu dönüşümün var olmasının bir nedeni, bir T türünün veya T türündeki bir ifadenin T'nin kendisine dönüştürülebilir olduğunun söylenebilmesidir.
     * Aşağıdaki özdeşlik dönüşümleri mevcuttur:
     * *T ve T arasında, herhangi bir T türü için.
      ** Nesne ve dinamik arasında.
       **Aynı arity'ye sahip tüm tuple tipleri ve karşılık gelen eleman tiplerinin her çifti arasında bir özdeşlik dönüşümü mevcut olduğunda, karşılık gelen inşa edilmiş ValueTuple<...> tipi arasında.
     * *Aynı genel(generic) tipten inşa edilen tipler arasında, karşılık gelen her bir tip argümanı arasında bir özdeşlik dönüşümü varsa.
     */
    
    //TODO: İngilizce ekle
    
    /*
     Identity conversion, C# dilinde, bir değerin aynı türe dönüştürülmesi anlamına gelir. Bu, genellikle derleyici tarafından otomatik olarak gerçekleştirilen ve herhangi bir çalışma zamanı maliyeti olmayan bir işlemdir. Örneğin, bir int türünden bir değişkeni yine int türüne dönüştürmek bir kimlik dönüşümüdür. Bu tür dönüşümler genellikle kodun okunabilirliğini artırmak veya belirli bir API'nin tür gereksinimlerini karşılamak için açıkça yapılır.
     */
    
    public void IdentityConversionsExample()
    {
     // Example 1: Converting between a variable and itself
     int number = 42;
     int sameNumber = (int)number;

// Example 2: Assigning a derived class instance to a base class type and back

/*class BaseClass { }
     class DerivedClass : BaseClass { }
     DerivedClass derivedInstance = new DerivedClass();
     BaseClass baseInstance = derivedInstance; // Upcasting, implicit identity conversion
     DerivedClass derivedAgain = (DerivedClass)baseInstance; // Downcasting, explicit identity conversion
*/
// Example 3: Converting nullable types
     int? nullableNumber = 5;
     int nonNullableNumber = (int)nullableNumber; // Assuming nullableNumber is not null

// Example 4: Using generic type parameters
     void GenericMethod<T>(T parameter)
     {
      T sameParameter = (T)parameter;
     }
     GenericMethod<int>(42);

// Example 5: Lambda expressions and delegate types
     Func<int, int> delegateInstance = x => x;
     Func<int, int> sameDelegateInstance = (Func<int, int>)delegateInstance;

     // Example 6: Using value tuples
     ValueTuple<int, string> tuple = (42, "Hello, World!");
     ValueTuple<int, string> sameTuple = (tuple.Item1, tuple.Item2);
    }
    }