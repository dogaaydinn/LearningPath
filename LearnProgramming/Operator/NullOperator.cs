namespace LearnProgramming.Operator;

public class NullOperator
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    
    //bir değişkenin türünün null olp olup olmadığını kontrol etmek için kullanılır.
    
    //!!!! bu operatorü sadece null olabilen türlerde kullanabiliriz.
    /*
     1-değer türlü değişkenler----- not NULLABLE  örnek: int a=null; diyemeyiz
     2- referans türlü değişkenler----- NULLABLE
     */

    public void NullOperatorExample()
    {
        string name = null;
        System.Console.WriteLine(name); // null
        System.Console.WriteLine(name ?? "Name is null"); // Name is null
    }
}