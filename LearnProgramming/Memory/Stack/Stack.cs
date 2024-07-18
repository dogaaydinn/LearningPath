namespace LearnProgramming.Memory.Stack;

public class Stack
{
 
    /*
     * The stack data structure
     * A stack is a data structure that follows the Last In First Out (LIFO) principle.
     * The last element added to the stack is the first one to be removed.
     */
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    /*
     * the stack stores local variables
     */
    
    /*
     * Stack Data Structure
     * There are two different levels to explaining the stack:
     * 1. generic stack data structure
     * 2. call stack, which is intrinsic to the C# runtime.
     */
    
    /*
     * The call stack
     * has 2 main functions:
     * 1. şu anda yürütülen method tamamlandığında kontrolün geri dönmesi gereken yöntemi takip etmek,
     * ----bir metot çalışmayı bitirdiğinde, karşılık gelen yığın çerçevesi(stack frame) yığından(stack) çıkarılır,
     * 2.local değişkenlerin değerlerini tutmak (yani, içerdikleri yöntem yürütüldükten sonra artık gerekli olmayan değişkenler).
     */
    
    /*
     * local değişkenler scope içerisinde declare edildiğinde, stack üzerine itilirler
     * bir methoda argüman veya değişkenleri declare ettiğimizde, stack üzerine itilirler.
     * aynı methoda ait olan değişkenler aynı stack frame içerisinde tutulur.
     * method çağrıldığında, stack frame oluşturulur ve method çağrıldığında stack frame üzerine itilir.
     * method çalışmayı bitirdiğinde, stack frame yığından(stack) çıkarılır.
     */
    
    public void StackExample()
    {
     int num = 5;
     int num2 = num++ * 4;
     Console.WriteLine(num2); // Output: 20

    }
}