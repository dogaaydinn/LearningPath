namespace LearnProgramming.Expressions.Operators;
using System;

public class UserDefinedExplicitAndImplicitConversionOperators
    {
        
        /*
         * User-defined conversions aren't considered by the is and as operators. Use a cast expression to invoke a user-defined explicit conversion.
         * you can define checked explicit conversion operators(go aritmetic operato)
         * You also use the operator keyword to overload a predefined C# operator.
         */
        public readonly struct CustomNumber
        {
            private readonly byte number;

            public CustomNumber(byte number)
            {
                if (number > 7)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), "Number cannot be greater than seven.");
                }
                this.number = number;
            }

            public static implicit operator byte(CustomNumber cn) => cn.number;
            public static explicit operator CustomNumber(byte b) => new CustomNumber(b);

            public override string ToString() => $"Number: {number}";
        }

        public static class CustomConversions
        {
            public static void Main()
            {
                var customNum = new CustomNumber(5);

                byte numValue = customNum;
                Console.WriteLine(numValue);  // output: 5

                CustomNumber newCustomNum = (CustomNumber)3;
                Console.WriteLine(newCustomNum);  // output: Number: 3
            }
        }

}
