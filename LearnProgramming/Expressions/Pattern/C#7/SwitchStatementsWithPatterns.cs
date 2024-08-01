namespace LearnProgramming.Expressions.Pattern.C_7;

public class SwitchStatementsWithPatterns
{
    /*
     * switch ifadesi;
     -bir değeri farklı durumlara göre kontrol etmek 
     - sonuç olarak bir değer döndürmek için kullanılır.
     */
    
    /*
     * switch Statements with Pattern
     - switch ifadelerinde switch case bloğuna pattern yazabiliriz.
     - switch ifadeleri, pattern matching kullanarak daha güçlü ve esnek kontroller yapılmasını sağlar.
     -Bu, özellikle iç içe geçmiş nesnelerin özelliklerini kontrol etmek için kullanışlıdır.
     */
    
    //Örnek 1
    public void SwitchStatement()
    {
        int dayOfWeek = 3;

        var dayName = dayOfWeek switch
        {
            1 => "Pazartesi",
            2 => "Salı",
            3 => "Çarşamba",
            4 => "Perşembe",
            5 => "Cuma",
            6 => "Cumartesi",
            7 => "Pazar",
            _ => "Geçersiz gün"
        };

        Console.WriteLine($"Haftanın günü: {dayName}");

    }
    
    //Örnek 2
    public abstract class Shape { }
    public class Circle : Shape 
    {
        public double Radius { get; set; }
    }
    public class Rectangle : Shape 
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public static void PrintShapeInfo(Shape shape)
    {
        switch (shape)
        {
            case Circle c:
                Console.WriteLine($"Bir daire, yarıçapı: {c.Radius}");
                break;
            case Rectangle r:
                Console.WriteLine($"Bir dikdörtgen, genişliği: {r.Width}, yüksekliği: {r.Height}");
                break;
            default:
                Console.WriteLine("Bilinmeyen şekil");
                break;
        }
    }

    public static void Main()
    {
        Shape circle = new Circle { Radius = 5.0 };
        Shape rectangle = new Rectangle { Width = 4.0, Height = 3.0 };

        PrintShapeInfo(circle);    // Bir daire, yarıçapı: 5
        PrintShapeInfo(rectangle); // Bir dikdörtgen, genişliği: 4, yüksekliği: 3
    }

}