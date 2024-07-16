namespace LearnProgramming.Methods;

public class ImplicitlyTypedLocalVariables
{
    /*
     * Var keyword kullanımı
     * Var keywordu local değişkenlerde kullanılır.
     * !!!var can only be used when a local variable is declared and initialized in the same statement
     * !!!var sadece bir local değişken tanımlandığında ve aynı ifadede başlatıldığında kullanılabilir
     * !!!var, local değişkenlerde kullanıldığında, değişkenin türünü belirlerken, değişkenin türünü belirtmek için kullanılan tür adını belirtmez.
     *  the variable cannot be initialized to null
     */

    /*
      Bir değişkeni var ile bildirdiğinizde(declare), değişkenin türü compiler tarafından  sağ tarafına göre initilaziation yapılır.
       Ancak compilerın türü çıkarabilmesi için, değişkenin kendisine referans vermeyen bir ifadeyle başlatılması gerekir.
       Bunun nedeni, başlatma işlemi tamamlanana kadar değişkenin türünün bilinmemesidir.
     */

    /*
     !!!!!!!!  var, türü bilmesi için bir iniziliation ifadesi gerektirdiğinden ve alan(field)  initializations yöntem derlemelerinden önce işleneceği garanti edilmediğinden, C# derleyicisi bu paradoksu önlemek için alanlar ve özellikler için var'a izin vermez.
     */
    
    
    /*
     !!!! dinamik yerlerde var kullanılamaz
     */

    // int i = (i = 20);

    // var i = (i = 20); // Error: Cannot assign void to an implicitly-typed local variable

    // var ivalue = 20, a = 30; : // Error: not allowed to declare multiple var in a single statement
    // var ivalue; // Error: Implicitly-typed local variables must be initialized

    public void ImplicitlyTypedLocalVariablesExample()
     {
         // Implicitly typed local variables
         var value = 10; // int
         var strValue = "Hello"; // string
         var booleanValue = true; // bool
         var nullableValue = new int?(); // int?

         // Explicitly typed local variables
         int explicitValue = 10; // int
         string explicitStrValue = "Hello"; // string
         bool explicitBooleanValue = true; // bool
         int? explicitNullableValue = new int?(); // int?

         // Anonymous types
         var anonymousType = new { Id = 1, Name = "John" }; // Anonymous type
         Console.WriteLine($"Anonymous type: {anonymousType.Id}, {anonymousType.Name}");
     }

}