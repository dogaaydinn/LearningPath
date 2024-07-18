namespace LearnProgramming.Operator;

public class TypeOfOperator
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    /*
     * Verilen türün/değerin typeını/değerini döndürür.
     * ileri düzey programlamada reflection ile birlikte kullanılır.
     */
    
    public void TypeOfOperatorExample()
    {
        int a = 5;
       // Console.WriteLine(typeof(a)); // System.Int32
        Console.WriteLine(typeof(int)); // System.Int32
        Console.WriteLine(typeof(TypeOfOperator)); // LearnProgramming.Operator.TypeOfOperator
    }


}