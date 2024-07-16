namespace LearnProgramming.Operator;

public class IncrementDecrement
{
    /*
     * Artırma ve azaltma operatörleri
     i++;  -------> öncelikle i değerini döndürür, sonra i'yi 1 artırır.
     ++i;  -------> öncelikle i'yi 1 artırır, sonra i değerini döndürür.
     her ikisinde de stack i'yi 1 artırır.
     */
    
    
    public void Increment()
    {
        int number = 10;
        int number2 = ++number * 4; 
        Console.WriteLine(number2); // Output: 44

        int number3 = 10;
        int number4 = number3++ * 4; 
        Console.WriteLine(number3); // Output: 10
    }
}

