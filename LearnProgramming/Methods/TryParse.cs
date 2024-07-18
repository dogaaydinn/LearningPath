namespace LearnProgramming.Methods;

public class TryParse
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    
    /*
     * TryParse yöntemi int, double ve DateTime gibi temel veri türleri için dizeleri dönüştürmenin güvenli bir yoludur.
     * Dönüştürmenin başarılı olup olmadığını belirten bir bool döndürür ve başarılı olması durumunda dönüştürülen değeri çıktı olarak verir.
     */
    /*
Note:
    A.Implicit conversions:
        1.No syntax required
        2.type safe conversions (No data will be lost)
        3.Example :
            a.conversions from smaller to larger integral types :(int -> double)
            b.Conversions from derived classes to base classe


    B.Explicit conversions (Cast):
        1.Syntax required
        2.NOT type safe conversions (data loss might occur)
        3.Example :
            a.conversions from larger to smaller integral types :(Double -> int)
            b.Conversions from base classe to derived classes

    C.Parse / TryParse

    D.Convert.To_X

*/
    
    public void TryParseExample()
        {
            string s = "123";
            int result;
            bool success = int.TryParse(s, out result);
            System.Console.WriteLine($"Success: {success}, Result: {result}");
            // Output:
            // Success: True, Result: 123
        }
    
    // C. Parse / TryParse

         static string strName = "Doğa";
         static string strId = "0200";

        bool Result = int.TryParse(strName, out int converted_strName);  //bool:TryParse(string,Int) : Check possibility of converting digits-OnString -> int and return boolean
        int converted_strId = int.Parse(strId); // int.Parse(string) : Convert String -> int

}