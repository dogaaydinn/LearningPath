namespace LearnProgramming.Variable;

public class Verbatim
{
 /*
  * Verbatim nedir?
  * Verbatim stringler, stringlerin başına @ işareti koyularak oluşturulan stringlerdir.
  * Verbatim stringlerde kaçış dizileri işlenmez.
  */

 public static void Main()
 {
  string verbatimString = @"Hello, \nWorld!";
  Console.WriteLine(verbatimString);

  // Output: Hello, \nWorld!
 }
}