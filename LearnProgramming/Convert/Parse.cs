namespace LearnProgramming.Convert;

public class Parse
{
    /*
     Parse methodu, string türündeki bir değeri, belirtilen türe dönüştürür.
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
    public void ParseMethod()
    {
        string strNumber = "123";
        int intNumber = int.Parse(strNumber);
        Console.WriteLine(intNumber);
        
        string strName = "Doğa";
        string strId = "001";

        bool Result = int.TryParse(strName, out int converted_strName);  //bool:TryParse(string,Int) : Check possibility of converting digits-OnString -> int and retrun boolean
        int converted_strId = int.Parse(strId); // int.Parse(string) : Convert String -> int
    }
}