namespace LearnProgramming.Statements;

public class CheckedUnchecked
{
    
    /*
    -Varsayılan olarak, integral değerler (int, uint ve long gibi) taştıklarında bir istisna oluşturmazlar.
     - Bunun yerine "sararlar" -- ve bu da muhtemelen istediğimiz bir değer sonucunu vermez.
      -Ancak bu davranışı,  bir istisna(exceprion) fırlatılacak şekilde değiştirebiliriz.
     */
    
    /*
     * Varsayılandan çıkıp overflow veya underflow hatası alabileceğimiz kod bloklarında "checked" ifadesini kullanabiliriz.
     * Alternatif olarak, ayarlayabileceğimiz bir proje özelliği de vardır: CheckForOverflowUnderflow.
     * Overflow vs Underflow kontrollerini tüm projemiz boyunca uygulamak isteyebiliriz.
     * Tek tek "checked" ifadeleri kullanmak yerine, proje üzerinde bir özellik de ayarlayabiliriz: "CheckForOverflowUnderflow".
     * Not: Bu davranış, C#'ta integral türler olan "enum" ve "char" için de geçerlidir.
     */
    
    /*
     * Unchecked ifadesi
     * bir kod bloğu içerisinde, tam sayı işlemleri yapılırken overflow durumunda hata alınmamasını sağlar.
     * bu durumda program çalışmaya devam eder ve overflow durumunda hata alınmaz.
     * overflow durumu yaşanabilecek tamsayı aritmetiğini kullanan mevcut kodla uğraşırken, overflow veya underflow durumu ile karşılaşacağınızın farkında olup performans endişesi yaşamamak için "unchecked" bloğunu kullanabilirsiniz.
     * Bir işlem bir overflow underflow (yani, kullanılan veri türü tarafından temsil edilemeyecek kadar büyük veya küçük bir değer) üretirse, program bir istisna oluşturmaz ve bunun yerine ortaya çıkan değerle çalışmaya devam eder. Tam sayı ifadeleriyle uğraşırken bu default olan eylemdir.
     * Aslında program  devam eder overflow durumunda hata vermez bu durumda eylemin sonucundan haberdar olmak için "checked" bloğunu kullanabilirsiniz.
     */
    
    //TODO: https://www.youtube.com/watch?v=9mBZvDPyE0U
}