namespace LearnProgramming.Operator;

public class NullCoalescingOperators
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    
    /*Null Coalescing Operator (??)
     * Değişkenin değerinin null olma iihtimaline karşı farklı bir değer atamak için kullanılır.
     */
    /*
     * Null Coalescing Operator (??=)
     * Null Coalescing Operator (??) ile aynı işlevi görür. Fakat Null Coalescing Operator (??) ile atanan değer null ise Null Coalescing Assignment Operator (??=) ile atanan değer atanır.
     */

    public void NullCoalescingOperator()
    {
        int? nullableInt = null;
        int defaultInt = 10;

        // Null Coalescing Operator
        int coalescedInt = nullableInt?? defaultInt;

        // Null Coalescing Operator with Null Coalescing Assignment Operator
        nullableInt??= defaultInt;

        Console.WriteLine(coalescedInt);  // Output: 10
        Console.WriteLine(nullableInt);  // Output: 10
    }
}