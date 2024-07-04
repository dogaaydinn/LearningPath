namespace LearnProgramming.Methods;

public class TryParse
{
    /*
     * TryParse yöntemi int, double ve DateTime gibi temel veri türleri için dizeleri dönüştürmenin güvenli bir yoludur.
     * Dönüştürmenin başarılı olup olmadığını belirten bir bool döndürür ve başarılı olması durumunda dönüştürülen değeri çıktı olarak verir.
     */
    
    public static void Main()
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