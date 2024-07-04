namespace LearnProgramming.Variable;

public class StaticVariable
{
    /*
     * You must be careful when you use Static variables.
     * They are stored on the Managed Heap, not the Stack when the type is first referenced.
     * And everyone can access them.
     * 
     */
    
    
    /*
     * Static variables always live on a heap,
     * and there's only ever a single heap block that holds the value of the variable.
     * This makes sense when you think what static variables are:
     * -there's a single object that the variable refers to which needs to outlive the method in which it was declared.
     * However, notice I said a heap, not the heap;
     * there are in-fact multiple heaps and it's possible that a static variable may not be allocated on "the heap" (i.e. the managed heap).
     */
    
    public static void Main()
    {
        int number = 10;
        MyNumber = 20;
        var @static = "Static";
        Console.WriteLine(number);

        number = 20;
        Console.WriteLine(number);

        Console.WriteLine(MyNumber);

        Console.WriteLine(@static);
    }

    public static int MyNumber { get; set; }
}