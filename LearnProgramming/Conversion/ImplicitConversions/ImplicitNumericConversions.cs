namespace LearnProgramming.Conversion.ImplicitConversions;
public class ImplicitNumericConversions
{
    /*
     * int, uint, long veya ulong'dan float'a ve long veya ulong'dan double'a dönüşümlerde hassasiyet kaybolabilir ancak büyüklük kaybolmaz.
     *
     * There are no implicit conversions to the char type.
       
       There are no implicit conversions between floating-point types and the decimal type.
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
}
  
class ClassBase { }
class ClassDerived : ClassBase { }


        //Converting between different types
        //4 Ways of conversion: 
        //1) Implicit conversions, 2) explicit conversions, 3) User-Defined conversions and 4) Conversion with helper class



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
  