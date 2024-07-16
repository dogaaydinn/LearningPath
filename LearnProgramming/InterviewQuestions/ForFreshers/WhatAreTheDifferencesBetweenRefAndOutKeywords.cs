namespace LearnProgramming.InterviewQuestions.ForFreshers;

public class WhatAreTheDifferencesBetweenRefAndOutKeywords
{
    /*
     C# ref keywords pass arguments by reference and not value. To use the ‘ref’ keyword, you need to explicitly mention ‘ref’. 
     */


    public void Example()
    {
        void Method(ref int refArgument)
        {
            refArgument = refArgument + 10;
        }
        int number = 1;
        Method(ref number);
        Console.WriteLine(number);
// Output: 11
    }

    /*
     C# out keywords pass arguments within methods and functions. 
       ‘out’ keyword is used to pass arguments in a method as a reference to return multiple values. Although it is the same as the ref keyword, the ref keyword needs to be initialised before it is passed. Here, The out and ref keywords are useful when we want to return a value in the same variables that are passed as an argument. 
     */
    public static string GetNextFeature(ref int id)  
    {  
        string returnText = "Next-" + id.ToString();  
        id += 1;  
        return returnText;  
    }  
    public static string GetFeature(out int id)  
    {  
        id = 1;  
        string returnText = "Next-" + id.ToString();  
        return returnText;  
    }   

}