namespace LearnProgramming.Variable;

public class CapturedVariables
{
 //TODO:Açıklama ve örnek ekle.
 //TODO: Türkçe ve İngilizce ekle.
 
    /*
     * Anonymous functions, which include lambda expressions, can capture variables from the outer scope.
     * When you declare an anonymous function, it has access to the local variables from the containing method,
     * ----these are called captured variables. 
     */
    
    /*
     * The compiler enables this by generating a class to hold any of the local variables from the containing method that the anonymous function uses,
     * it creates an instance of this class inside the containing method and copies the required local variables into fields on that object.
     */
    
    /*
     * The code inside the anonymous function then uses the fields on that class.
     * In other words, some variables that appear to be local variables (i.e. live on the stack) of anonymous functions are in fact fields of an object living on the heap.
     */
    
    /*
     * Exceptions:
     * 1.This can also be true of local functions (methods defined in other methods).
     * If you define a delegate that refers to a local function, the compiler will capture the variables from the containing method in the same way.
     * 2.Asynchronous methods and iterators
     * Asynchronous methods return before completing to allow the calling method to continue executing whilst something time consuming takes place.
     * At some point the asynchronous methods resumes execution, which means the state inside the method at the point in time at which it returned needs to have been preserved, even though it returned.
     * Therefore the stack frame associated with an asynchronous method cannot be deallocated in the way I described when the method returns to work asynchronously; the compiler has to do some work to achieve this.
     * This also applies to iterators – iterators and async methods share similar implementation details.
     */

    public static void CapturedVariablesMethod()
    {
      int x = 5;
      Action<int> action = (y) => { Console.WriteLine(x + y); };
      action(3); // Prints 8
      x = 7;
      action(3); // Prints 10
      // Note: x is captured by value, not by reference.
      // In this case, when we change x inside the anonymous function, it does not affect the captured value of x in the outer scope.
      // If you wanted to capture x by reference, you would use the ref keyword:
      // Action<int> actionRef = (ref int y) => { Console.WriteLine(x + y); };
      // actionRef(3); // Prints 8
      // x = 7;
      // actionRef(3); // Prints 10
      // Now, when we change x inside the anonymous function, it does affect the captured value of x in the outer scope.
      // In this case, the compiler will generate a class to hold the captured variable,
      // and it will create an instance of this class inside the containing method and copy the required local variable into fields on that object.
      // The code inside the anonymous function then uses the fields on that class.
      // This is why you can capture variables from the outer scope when you declare an anonymous function.
      
    }
}