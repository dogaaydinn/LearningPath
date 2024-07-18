namespace LearnProgramming.Variable;

public class Verbatim
{
 //TODO:Açıklama ve örnek ekle.
 //TODO: Türkçe ve İngilizce ekle.
 
 /*
  * Verbatim nedir?
  * Verbatim stringler, stringlerin başına @ işareti koyularak oluşturulan stringlerdir.
  * Verbatim stringlerde kaçış dizileri işlenmez.
  */

 public static void VerbatimMethod()
 {
  string verbatimString = @"Hello, \nWorld!";
  Console.WriteLine(verbatimString);

  // Output: Hello, \nWorld!
 }
}