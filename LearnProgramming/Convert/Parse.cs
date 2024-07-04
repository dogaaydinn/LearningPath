namespace LearnProgramming.Convert;

public class Parse
{
    /*
     Parse methodu, string türündeki bir değeri, belirtilen türe dönüştürür.
     */
    
    public void ParseMethod()
    {
        string strNumber = "123";
        int intNumber = int.Parse(strNumber);
        Console.WriteLine(intNumber);
    }
}