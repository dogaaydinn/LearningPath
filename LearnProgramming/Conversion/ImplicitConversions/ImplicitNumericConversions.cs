namespace LearnProgramming.Conversion.ImplicitConversions;
public class ImplicitNumericConversions
{
    /*
     * int, uint, long veya ulong'dan float'a ve long veya ulong'dan double'a dönüşümlerde hassasiyet kaybolabilir ancak büyüklük kaybolmaz.
     *
     * There are no implicit conversions to the char type.
       
       There are no implicit conversions between floating-point types and the decimal type.
     */
}
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
class ClassBase { }
class ClassDerived : ClassBase { }
class Program
{

    static void Main(string[] args)
    {
        // A1. Implicit conversions  (Smaller -> Larger)
        int x = 100;
        double y = x;

        // A2.Implicit conversions  (DrivedClass -> BaseClass)
        ClassDerived D = new ClassDerived();
        ClassBase B = D;

        //===================================================================

        // B1.Explicit conversions (Larger -> Smaller)
        double d = 123.4567;
        int nd = (int)d;   // Output: 123 

        // B2.Explicit conversions   (BaseClass -> DrivedClass)
        ClassBase Ba = new ClassBase();
        ClassDerived De= (ClassDerived)Ba;

        //===================================================================

        // C. Parse / TryParse

        string strName = "Reza";
        string strId = "0010";

        bool Result = int.TryParse(strName, out int converted_strName);  //bool:TryParse(string,Int) : Check possibility of converting digits-OnString -> int and retrun boolean
        int converted_strId = int.Parse(strId); // int.Parse(string) : Convert String -> int

        //===================================================================

        // D. Convert.To_X

        int I = 100;
        double J = Convert.ToDouble(I);

    }
}

        static void Main(string[] args)
        {
            //Boxing and Unboxing Method:
            BoxingAndUnboxing();

            //Conversions and casting
            Conversions();

            //Using Dynamic Types: Office Automation API's
            Console.WriteLine("Do you want to see how the Office Automation API for excel is used? Go check out the method declared in line 91(DisplayInExcel method).");
            //Create Excel object(records)
            //Add the following code to add reords to excel worksheet
            // var entities = new List<dynamic>
            //         {
            //                     new
            //                     {
            //                         ColumnA = 1,
            //                         ColumnB = "Foo"
            //                     },
            //                     new
            //                     {
            //                         ColumnA= 2,
            //                         ColumnB= "Bar"
            //                     }
            //         };

            // //Pass created object as parameter
            // DisplayInExcel(entities);
        }

        //Boxing and Unboxing
        //Boxing: Process of taking value type, placing it in new object on heap, storing ref to it on stack
        //Unboxing: Takes item from heap, returns value that contains value from heap
        public static void BoxingAndUnboxing()
        {
            //Boxing int value:
            int i = 42;
            object o = i;
            Console.WriteLine("Boxed: {0}", o);

            //Unboxing int value
            int x = (int)o;
            Console.WriteLine("Unboxed: {0}", x);
        }

        //Converting between different types
        //4 Ways of conversion: 
        //1) Implicit conversions, 2) explicit conversions, 3) User-Defined conversions and 4) Conversion with helper class
        public static void Conversions()
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

        //Dynamic Types: Excel worksheet
        static void DisplayInExcel(IEnumerable<dynamic> entities)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;

            excelApp.Workbooks.Add();

            dynamic workSheet = excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "Header A";
            workSheet.Cells[1, "B"] = "Header B";

            var row = 1;
            foreach (var entity in entities)
            {
                row++;
                workSheet.Cells[row, "A"] = entity.ColumnA;
                workSheet.Cells[row, "B"] = entity.ColumnB;
            }

            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
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
    