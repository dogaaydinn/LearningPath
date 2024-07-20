namespace LearnProgramming.Expressions.Pattern.C_8;

public class RecursivePattern
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    //https://www.borakasmer.com/c-9-0-ile-gelen-yeni-ozellikler%3Fwt.mc_id%3Ddop-mvp-5001703
    
    
    /*
     * Recursive pattern birden fazla pattern'ın bir araya gelmiş halidir.
     * switch-case yapısını geliştirmekte yardımcı olmuştur.(C#7 ye kadar switch içerisinde sadece değer türlü değişkenleri kontrol edebiliyorduk artık gelen özellikle beraber referans tipli değişkenleri de kontrol edebiliyoruz. Bu özellik geliştirme gibi gözükse de aslında switch case için özel bir pattern oluşmasını sağladı.
     * bu pattern yapısında birden fazla pattern bulunabilir mesela;
     - type pattern(referansların gösterdikleri nesnelerin tiplerini belirlediğimiz için)
     - case içerisinde null olup olmadığını kontrol edebilmesinden dolayı constant pattern(null kontrolü sağladığımız için)
     */
    
    //örnek 1
    
    static void X(ICloneable instance)
    {
        
        switch (instance) // referans tipli değişken switch-case yapısında kullanılabilmektedir.
        {
            case Person p when p.Age > 18:
                Console.WriteLine("18 yaş üstü");
                break;
            case Person p when p.Age < 18:
                Console.WriteLine("18 yaş altı");
                break;
            case Person p:
                Console.WriteLine("18 yaş");
                break;
            case null: //constant pattern
                Console.WriteLine("Null");
                break;
        }
    }
    
    //TODO:referans tipli değişkenler anlatıldıktan sonra tekrar edilecek
    //örnek 2
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }

    public static void Main()
    {
        var person = new Person
        {
            Name = "John",
            Age = 30,
            Address = new Address
            {
                City = "New York",
                Street = "5th Avenue"
            }
        };

        if (person is { Address: { City: "New York" } })
        {
            Console.WriteLine("Person lives in New York.");
        }
        else
        {
            Console.WriteLine("Person does not live in New York.");
        }
    }
    //örnek 3
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }

    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public void Deconstruct(out Point topLeft, out Point bottomRight)
        {
            topLeft = TopLeft;
            bottomRight = BottomRight;
        }
    }

    public static void Main1()
    {
        var rectangle = new Rectangle
        {
            TopLeft = new Point { X = 0, Y = 10 },
            BottomRight = new Point { X = 10, Y = 0 }
        };

        if (rectangle is { TopLeft: (0, 10), BottomRight: (10, 0) })
        {
            Console.WriteLine("Rectangle matches the specified points.");
        }
        else
        {
            Console.WriteLine("Rectangle does not match the specified points.");
        }
    }

}