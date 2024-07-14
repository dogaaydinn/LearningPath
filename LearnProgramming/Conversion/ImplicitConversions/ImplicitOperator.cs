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
       
    }
    
    //Lokasyon sınıfını hem Koorinat’a hem de double tipine implicit çevir,
    class Lokasyon2
        {
            public double X { get; set; }
            public double Y { get; set; }
            public static implicit operator Koordinat2(Lokasyon2 lokasyon2)
                {
                    return new Koordinat2 { X = (int)lokasyon2.X, Y = (int)lokasyon2.Y };
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
    
    public class Koordinat3
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static implicit operator double (Koordinat3 koordinat3)
        {
            return koordinat3.X * koordinat3.Y;
        }
    }

    class Lokasyon3
        {
            public double X { get; set; }
            public double Y { get; set; }
            
            public static implicit operator bool(Lokasyon3 lokasyon3)
            {
                return true;
            }
        }
    
    public static void Main()
    {
        Lokasyon lokasyon = new Koordinat();
        
        Koordinat2 koordinat2 = new Lokasyon2();
        double i = new Lokasyon2();

        double d = new Koordinat3();
        bool b = new Lokasyon3();
        
    }
}