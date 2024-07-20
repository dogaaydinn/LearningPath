namespace LearnProgramming.Expressions.Pattern.C_9;

public class Keywords
{
    //https://pvs-studio.com/en/blog/posts/csharp/0860/
    //https://www.borakasmer.com/c-9-0-ile-gelen-yeni-ozellikler%3Fwt.mc_id%3Ddop-mvp-5001703
    
    /*       Pattern Matching Enhancements
       1-Type patterns match a variable is a kind
       2-Parenthesized patterns emphasize or stress the precedence of combinations of patterns
       3-Conjunctive and patterns need both the patterns for the match
       4-Disjunctive or patterns need anyone patterns for matching
       5-Negated not patterns need that a pattern does not match
       6-Relational patterns need the input to be lesser, greater, or greater than, or equal less than or equal to the given
     */

    //örnek 1-  Type patterns match a variable is a kind
    
    public void TypePatterns()
    {
        object obj = new object();
        switch (obj)
        {
            case object o:
                Console.WriteLine("object");
                break;
        }
    }
    
    //örnek 2- Parenthesized patterns emphasize or stress the precedence of combinations of patterns
    
    public void ParenthesizedPatterns()
    {
        object obj = new object();
        switch (obj)
        {
            case (object o):
                Console.WriteLine("object");
                break;
        }
    }
    
    //örnek 3- Conjunctive and patterns need both the patterns for the match

    public void ConjunctivePatterns()
    {
        object obj = new object();
        switch (obj)
        {
            case object o when o is string:
                Console.WriteLine("object is a string");
                break;
        }
    }
    
    //örnek 4- Disjunctive or patterns need anyone patterns for matching
    
    public void DisjunctivePatterns()
    {
        object obj = new object();
        switch (obj)
        {
            case object o when o is string:
                Console.WriteLine("object is a string");
                break;
            case object o when o is int:
                Console.WriteLine("object is an int");
                break;
        }
    }
    
    //örnek 5- Negated not patterns need that a pattern does not match
    
    public void NegatedPatterns()
    {
        object obj = new object();
        switch (obj)
        {
            case object o when !(o is string):
                Console.WriteLine("object is not a string");
                break;
        }
    }
    
    //örnek 6- Relational patterns need the input to be lesser, greater, or greater than, or equal less than or equal to the given
    
    public void RelationalPatterns()
    {
        int number = 42;
        switch (number)
        {
            case > 0 and < 100:
                Console.WriteLine("Number is between 0 and 100.");
                break;
        }
    }
    
}