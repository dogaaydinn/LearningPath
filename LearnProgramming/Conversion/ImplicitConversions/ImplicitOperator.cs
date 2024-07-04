namespace LearnProgramming.Conversion.ImplicitConversions;

public class ImplicitOperator
{
    // Interview Question
    
    /*
     * I have been given a sample statement:
       
       MyClass myclass = 3;
       How is it possible to make this a valid statement? What code do I need to include in MyClass to support the implicit conversion from an int?
     */
    
    // Aralarında  ilişki olmayan sınıflar arasında Implicit ve Explicit Conversion yapmak isteniyorsa:
    // 1- Sınıfın içerisinde bir operator overload yazılır.
    // 2- Bu operator overload static olmalıdır.
    
    
    //Koordinat sınıfını Lokasyon’a implicit çevir,

    
    public class Koordinat
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static implicit operator Lokasyon(Koordinat koordinat)
        {
            return new Lokasyon { X = koordinat.X, Y = koordinat.Y };
        }
    }

    public class Lokasyon
    {
        public double X { get; set; }
        public double Y { get; set; }
        public static implicit operator Lokasyon(Koordinat koordinat)
        {
            return new Lokasyon { X = koordinat.X, Y = koordinat.Y };
        }
       
    }
    
    //Lokasyon sınıfını hem Koorinat’a hem de double tipine implicit çevir,
    class Lokasyon2
        {
            public double X { get; set; }
            public double Y { get; set; }
            public static implicit operator Koordinat(Lokasyon2 lokasyon2)
                {
                    return new Koordinat { X = (int)lokasyon2.X, Y = (int)lokasyon2.Y };
                }

            public static implicit operator double (Lokasyon2 lokasyon2)
            {
                return lokasyon2.X;
            }
        }
    public class Koordinat2
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    
    
    
    public static void Main()
    {
        
        Koordinat koordinat = new Koordinat { X = 3, Y = 4 };
        Lokasyon lokasyon = koordinat; // Implicitly converts Koordinat to Lokasyon using the X and Y values

        // Lokasyon2 and Koordinat2 do not have a conversion path defined between them
        // Therefore, we cannot directly convert Koordinat2 to Lokasyon2 or vice versa without defining such a conversion

        Lokasyon2 lokasyon2 = new Lokasyon2 { X = 5.0, Y = 10.0 };
        double i = lokasyon2; // Implicitly converts Lokasyon2 to double using the X value
    }
}