namespace LearnProgramming.Conversion.ExplicitConversions;

public class ExplicitOperator
{
    /*
     * Koordinat sınıfını Lokasyon’a explicit çevir,
     */
    
    /*
     * !!!Bir sınıf içerisinde aynı işleve sahip hem implicit hem de explicit metot bulunamaz…
     */
    
    //TODO: İngilizce ekle
    
    public class Koordinat
    {
        public int X { get; set; }
        public int Y { get; set; }

        
        public static explicit operator Lokasyon(Koordinat koordinat)
        {
            return new Lokasyon { X = koordinat.X, Y = koordinat.Y };
        }
        
    }
    public class Lokasyon
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    
    public class Lokasyon2
    {
        public double X { get; set; }
        public double Y { get; set; }
        public static explicit operator Koordinat2(Lokasyon2 lokasyon2)
        {
            return new Koordinat2 { X = (int)lokasyon2.X, Y = (int)lokasyon2.Y };
        }
        public static explicit operator double (Lokasyon2 lokasyon2)
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
        
        public static explicit operator double (Koordinat3 koordinat3)
        {
            return koordinat3.X * koordinat3.Y;
        }
    }
    
    class Lokasyon3
    {
        public double X { get; set; }
        public double Y { get; set; }
        
        public static explicit operator bool(Lokasyon3 lokasyon3)
        {
            return true;
        }
    }
    
    public void ExplicitOperatorExample()
    {
        Lokasyon lokasyon = (Lokasyon)new Koordinat();
        
        Koordinat2 koordinat2 = (Koordinat2)new Lokasyon2();
        double i = (double)new Lokasyon2();
        
        double d = (double)new Koordinat3();
        bool b = (bool)new Lokasyon3();
    }
}