namespace LearnProgramming.Statements.JumpStatements;

public class Goto
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    
    /*
     * Switch case yapılanmasında sadece eşitlik durumu inceleyebildiğimiz için mantıksal bir işlem gerçekleştiremeyiz.
     * Dolayısıyla bazen farklı değerlere eşit olma durumunda aynı operasyonu/kodu/akışı kullanaacağımız senaryolarla karşılaşabiliriz.
     * Bu durumda switch case yapısını kullanamayız. Bu gibi durumlarda goto yapısını kullanabiliriz.
     */


    public void GotoExample()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j == 3)
                {
                    goto EndLoop; // Hem iç hem dış döngüyü sonlandırır
                }
                Console.WriteLine($"i: {i}, j: {j}");
            }
        }
        EndLoop:
        Console.WriteLine("Döngü sonlandı.");
    }
}