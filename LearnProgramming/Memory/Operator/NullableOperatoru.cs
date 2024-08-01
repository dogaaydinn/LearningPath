namespace LearnProgramming.Operator;

public class NullableOperatoru
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    
    /*
 1-değer türlü değişkenler----- not NULLABLE  örnek: int a=null; diyemeyiz
 2- referans türlü değişkenler----- NULLABLE
 */
    
    /*
     Değer türlü değişkenler normal şartlarda null olamaz.
      Ama nullable değişkenler null olabilir. Bu tür değişkenler için ? işareti kullanılır.
     */

    public void NullableOperatorExample()
    {
        int? nullableInt = null;  // nullableInt değişkenine null değer atadık.
        nullableInt = 10;  // nullableInt değişkenine int değer atadık.

        int a = nullableInt?? 0;  // nullableInt değeri null ise 0 değeri, değilse nullableInt değerini atadık.

        System.Console.WriteLine(a);  // Output: 10
    }
}