namespace LearnProgramming.Variable;

public class ExplicitVariable
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    
    /*
     Açıkça ve ayrıntılı olarak belirtilmiş, kafa karışıklığına veya şüpheye yer bırakmayan.
     */
    
    /*
     Explicit: 
       List<int> lstIntegers = new List<int>();
       
       Implicit: 
       var lstIntegers = new List<int>();
     */
    
    /*
     Explicit 
       List<MyContactObjects> lstObjects = GetContractContactInfo();
       
       Implicit 
       var lstObjects = GetContractContactInfo();
     */
    public void ExplicitVariableMethod()
    {
        int a = 10;
        int b = 20;
        (a, b) = (b, a);
        Console.WriteLine($"a: {a}, b: {b}");
        
    }
}