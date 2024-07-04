namespace LearnProgramming.Variable;

public class ImplicitVariable
{
    /*
     açıkça ifade edilmese de ima edilen.
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
    
    public static void main(string[] args)
    {
        Boxing.BoxingAndUnboxing();
        ImplicitVariable.main(args);
    }

}