namespace LearnProgramming.Conversion;
using System;
public class Conversions
{
    /*
     * Dönüştürme, bir ifadenin belirli bir türe dönüştürülmesine veya belirli bir türdeymiş gibi işlem görmesine neden olur; ilk durumda dönüştürme, gösterimde bir değişiklik içerebilir. 
     */
    
    /*
    Note:
        A.Implicit conversions:
            1.No syntax required
            2.type safe conversions (No data will be lost)
            3.Example :
                a.conversions from smaller to larger integral types :(int -> double)
                b.Conversions from derived classes to base classe


        B.Explicit conversions (Cast):
            1.Syntax required
            2.NOT type safe conversions (data loss might occur)
            3.Example :
                a.conversions from larger to smaller integral types :(Double -> int)
                b.Conversions from base classe to derived classes

        C.Parse / TryParse

        D.Convert.To_X

    */
    
    /*
     * //Conversions and casting
     * //Using Dynamic Types
     */
    
    //Converting between different types
    //4 Ways of conversion: 
    //1) Implicit conversions,
    //2) explicit conversions,
    //3) User-Defined conversions, 
    //4) Conversion with helper class
    public void ConversionsExample()
    {
        // 1) Implicit conversions: When conversion is legal, allowed
        int i = 42;
        double d = i;

        Console.WriteLine("Implicit conversion(int to double): {0}", d);

        // 2) Explicit conversions: when conversion is not allowed, needs to be casted
        double d2 = 42.7;
        int i2 = (int)d2;
            
        Console.WriteLine("Explicit conversion(double to int): {0}", i2);

        // 3) User-Defined conversions: When working with own types, you use both Impplicit- and Explicit conversions
        var money = new Money(12.99M);
        money.Amount = 12.99M;

        // 4) Conversions with Helper class(BitConverter- and Converter class from System namespace)

        //Convert class
        int value1 = Convert.ToInt32("42");
        Console.WriteLine("Convert.ToInt32 value: {0}", value1);

        //Parse class
        int value2 = int.Parse("42");
        Console.WriteLine("int.Parse value: {0}", value2);

        //TryParse(returns value and true/false)
        bool success = int.TryParse("42", out int value3);
        Console.WriteLine("Convertion succesfull: {0}, Value: {1}", success, value3);


    }
    class Money
    {
        //Amount
        public decimal Amount { get; set; }

        //Parameterized constructor
        public Money(decimal amount)
        {
            Amount = amount;
        }

        //Implicit operator
        public static implicit operator decimal(Money money)
        {
            Console.WriteLine("Implicit operator: {0}", money.Amount);
            return money.Amount;
        }

        //Explicit operator
        public static explicit operator int(Money money)
        {
            Console.WriteLine("Explicit operator: {0}", (int)money.Amount);
            return (int)money.Amount;
        }
    }  

}