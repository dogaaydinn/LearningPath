namespace LearnProgramming.Variable;

public class Boxing
{
    
    /*
     * Object türdeki bir değişkene herhangi bir türdeki değeri göndermek Boxing olarak nitelendirilir.
     */

    //Boxing and Unboxing
    //Boxing: Process of taking value type, placing it in new object on heap, storing ref to it on stack
    //Unboxing: Takes item from heap, returns value that contains value from heap
    public static void BoxingAndUnboxing()
    {
        
        //Boxing and Unboxing Method:
        BoxingAndUnboxing();
        
        //Boxing int value:
        int i = 42;
        object o = i;
        Console.WriteLine("Boxed: {0}", o);

        //Unboxing int value
        int x = (int)o;
        Console.WriteLine("Unboxed: {0}", x);
    }

}