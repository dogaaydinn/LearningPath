namespace LearnProgramming.Expressions.Pattern.C_8;

public class VarPattern
{
    /*
      - Var pattern
       * herhangi bir ifadeyi eşleştirmek ve ardından bunu bildirilen yeni bir değişkene atamak için kullanılabilir.
       * Her zaman eşleştiği için diğer kalıplardan farklıdır.
       * Dolayısıyla, var kalıbının amacı, bir kalıp için bir ifadeyi test etmek yerine, bir ifadeyi bir değişkene atamaktır.
       kullanım durumu:
       - Diğer kalıplar eşleşiyorsa özellik değerlerini bir değişkende saklamak istiyorsanız
       - veya hesaplamalar sırasında ara değerleri geçici bir değişkende saklamak istiyorsanız
     */
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    
    //type pattern'ın daha hızlandırılmış hali -geliştirilmiş türüdür.
    
    
    //ÖNEMLİ!! var pattern vs var keywordü arasındaki fark:
    //var keywordü: derleme zamanında türü belirler.
    //var pattern: derleme zamanında türü belirlemiyor, çalışma zamanında türü belirliyor.
    
    //Örnek 1-basic
    public void VarPatternExample1()
    {
        object obj = "Hello, World!";

        if (obj is var value)
        {
            Console.WriteLine($"The value is: {value}");
        }

    }
    
    //Örnek 2- switch İfadesi ile var Pattern Kullanımı
    public void VarPatternExample2()
    {
        object[] items = { "Hello, World!", 42, 3.14, true };

        foreach (var item in items)
        {
            switch (item)
            {
                case var value:
                    Console.WriteLine($"The value is: {value}");
                    break;
            }
        }

    }
    
    //Örnek 3
    public class Animal { }
    public class Dog : Animal 
    {
        public void Bark() => Console.WriteLine("Woof!");
    }
    public class Cat : Animal 
    {
        public void Meow() => Console.WriteLine("Meow!");
    }

    public void ProcessAnimal(Animal animal)
    {
        switch (animal)
        {
            case Dog dog:
                dog.Bark();
                break;
            case Cat cat:
                cat.Meow();
                break;
            case var value:
                Console.WriteLine("Unknown animal: " + value);
                break;
        }
    }

    public void Main()
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();
        Animal unknownAnimal = new Animal();

        ProcessAnimal(myDog);
        ProcessAnimal(myCat);
        ProcessAnimal(unknownAnimal);
    }
    
    //Örnek 4-var Pattern ile Nullable Türler
    public void VarPatternExample4()
    {
        int? nullableInt = 42;

        if (nullableInt is var value)
        {
            Console.WriteLine($"The value is: {value}");
        }

    }
    
    //Örnek 5
    //Listeler veya koleksiyonlar ile var pattern kullanımı:

    public void VarPatternExample5()
    {
        var list = new List<object> { "Hello", 123, 45.67 };

        foreach (var item in list)
        {
            if (item is var value)
            {
                Console.WriteLine($"Item value is: {value}");
            }
        }

    }

}