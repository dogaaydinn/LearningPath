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
    
    public void ImplicitVariableExample()
    {
        //Implicit Variable
        var i = 5;
        var s = "Hello";
        var d = 1.0;
        var numbers = new[] {0, 1, 2, 3, 4, 5};
        
        Console.WriteLine("i: {0}", i);
        Console.WriteLine("s: {0}", s);
        Console.WriteLine("d: {0}", d);
        
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

}