using LearnProgramming.Conversion.ImplicitConversions;

namespace LearnProgramming.Conversion.ExplicitConversions;

public class ExplicitOperator
{
    /*
     * Koordinat sınıfını Lokasyon’a explicit çevir,
     */
    public class Lokasyon
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    
    public class Koordinat
    {
        public int X { get; set; }
        public int Y { get; set; }

        
        public static explicit operator Lokasyon(Koordinat koordinat)
        {
            return new Lokasyon { X = koordinat.X, Y = koordinat.Y };
        }
        
    }
    
    public static void Main()
    {
        Koordinat koordinat = new Koordinat { X = 3, Y = 4 };
        Lokasyon lokasyon = (Lokasyon)new Koordinat();
    }
}