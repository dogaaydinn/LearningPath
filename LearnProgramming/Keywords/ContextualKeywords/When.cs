namespace LearnProgramming.Keywords.ContextualKeywords;

public class When
{
    
    //TODO: OOP sonrası okunacak.
    // https://medium.com/@alexandre.malavasi/quick-tip-when-can-i-use-when-in-c-aabdb449f62c
    //https://code-maze.com/csharp-when-keyword-handling-exceptions/
    // https://stackify.com/csharp-exception-handling-best-practices/
    
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    /*
     -Catch Clause Tests:
       
       After a catch clause with different variations (empty, with exception type, with exception variable, etc.).
       Ensure the "when" keyword is recommended correctly after these variations.
       Ensure the "when" keyword is not recommended in other inappropriate contexts within try-catch blocks.
       
      - Switch Case Tests:
       
       After a case label in switch statements with various expressions.
       Ensure the "when" keyword is recommended correctly after these expressions.
       Ensure the "when" keyword is not recommended in inappropriate contexts within switch statements (e.g., after incomplete expressions, inside expressions, after "case", "default", or "when" labels).
       
       -Semantic Checks:
       
       Tests to ensure that the "when" keyword is recommended based on semantic analysis.
       Includes cases with predefined types, generic types, custom types, type aliases, local constants, and unknown names.
       Ensures that the recommender does not suggest the "when" keyword in invalid contexts such as after "var", type alias of "var", or local constants named "var".
     */
    
    public static void TestWhen()
    {
        try
        {
            throw new Exception();
        }
        catch (Exception ex) when (ex.Message == "Test")
        {
            Console.WriteLine("Caught exception with message 'Test'");
        }
        
        catch (Exception ex) when (ex.Message == "Test")
        {
            Console.WriteLine("Caught exception with message 'Test'");
        }
        
    }

    public static void TestWhen2()
    {
        // Recommended usage
        switch (true)
        {
            case 1 > 0 when true:
                Console.WriteLine("Condition met");
                break;
            default:
                Console.WriteLine("Condition not met");
                break;
        }

        // Incorrect usage
       /* switch (true)
        {
            case 1 > 0:
                Console.WriteLine("Condition met");
                break;
            case true when 1 > 0:
                Console.WriteLine("Condition met");
                break;
            default:
                Console.WriteLine("Condition not met");
                break;
        }
       
    */
    }
}