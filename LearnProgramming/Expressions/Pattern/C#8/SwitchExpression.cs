namespace LearnProgramming.Expressions.Pattern.C_8;

public class SwitchExpression
{
    /*
     * Tek satırlık işlemler için maliyet düşürücü ve kullanışlı semantiklerdir.
     */
    
    // eskiden switch case olarak karşımıza çıkıyordu.
    
    /*
     -Switch yapılanması, bir değerin birden fazla değere karşılık eşitlik durumunu kontrol ettiğimiz
      ve neticede genellikle tek bir işlem yaptığımız bir kontrol yapısıdır.
     */
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.

    public void SwitchCaseExample()
    {
     string message = "";
     switch (DateTime.Now.DayOfWeek)
     {
      case DayOfWeek.Monday:
       message = "Today is Monday";
       break;
      case DayOfWeek.Tuesday:
       message = "Today is Tuesday";
       break;
      case DayOfWeek.Wednesday:
       message = "Today is Wednesday";
       break;
      case DayOfWeek.Thursday:
       message = "Today is Thursday";
       break;
      case DayOfWeek.Friday:
       message = "Today is Friday";
       break;
      case DayOfWeek.Saturday:
       message = "Today is Saturday";
       break;
      case DayOfWeek.Sunday:
       message = "Today is Sunday";
       break;
     }
     Console.WriteLine(message);
    }
    // önceden çok kalabalık ve karmaşık bir yapıydı. Switch expression ile bu karmaşıklık azaltılmış oldu.
    //C# 8.0 versiyonunda, switch – case yapısının bu dezavantajına müdahale edilmiş ve aşağıdaki gibi tek satırlık işlemler için her türlü maliyeti düşürücü ve daha kullanışlı yapılanma gelmiştir.

    public void SwitchExpressionExample()
    {
     string message = DateTime.Now.DayOfWeek switch
     {
      DayOfWeek.Monday => "Today is Monday",
      DayOfWeek.Tuesday => "Today is Tuesday",
      DayOfWeek.Wednesday => "Today is Wednesday",
      DayOfWeek.Thursday => "Today is Thursday",
      DayOfWeek.Friday => "Today is Friday",
      DayOfWeek.Saturday => "Today is Saturday",
      DayOfWeek.Sunday => "Today is Sunday"
     };
     Console.WriteLine(message);

     //Kontrolü yapılan değerin yazıldığı parantez sağ taraftan kaldırılmış ve switch keywordünün sol yanına yerleştirilmiştir.
     // Kontrol edilen tek bir değer olursa parantez kullanılmayabilir.
     //eğer birden fazla değer kontrol edilecekse "Tuple Pattern" yapısı kullanılır.

    }
}