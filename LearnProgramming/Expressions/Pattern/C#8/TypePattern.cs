namespace LearnProgramming.Expressions.Pattern.C_8;

public class TypePattern
{
    /*
     - Type Pattern (Tür Denetimi (Type Checking))
       *Type patterns permit you to match on the type of the object.
     */
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    //linki izle
    //https://www.youtube.com/watch?v=qXRUfpIVtwc&list=PLQVXoXFVVtp3e_urGZcMNAHx2Eo4Rm5Xk&index=166
    /*
     * Type patterns, bir nesnenin türüne göre eşleşmenizi sağlar.
     * is operatorü ile  belirtilen türün direkt dönüşümünü sağlar.
     */
    
    //clasical way - örnek 1
    public void TypePatternExample()
    {
        object obj = "Merhaba Dünya!";

        if (obj is string)
        {
            //cast işlemi ile stringe dönüştürüyoruz.
            string str = (string)obj;
            Console.WriteLine(str.ToUpper());
        }
    }
    
    //C# 8.0 ile gelen özellik - örnek 2

    public void TypePatternExample2()
    {
        object obj = "Merhaba Dünya!";

        if (obj is string str)
        {
            //Tür denetimi ile stringe dönüştüyoruz.
            Console.WriteLine(str.ToUpper());
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
            default:
                Console.WriteLine("Unknown animal");
                break;
        }
    }

    public void Main()
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        ProcessAnimal(myDog);
        ProcessAnimal(myCat);
    }
    //Bu örnekte type pattern kullanımı, MakeSound metodunda switch expression (switch ifadesi) içinde gerçekleştirilmiştir.
    //Type pattern, animal nesnesinin türüne göre bir eylem gerçekleştirir.
    
    //Kritik - Örnek 4
    public void TypePatternExample3()
    {
        object obj = "Doğa";
        
        if (obj is string str)
        {
            Console.WriteLine(str);
        }else if (obj is int number) //aynı isimle tanımlamadık, tanımlasaydık hata verirdi, çünkü aynı scope içerisinde aynı isimli değişken tanımlanamaz.
        {
            Console.WriteLine(number);
        }
        //değişkenin null olma ihtimali vardır; bu yüzden nullsa değişkeni çağıramayız, üzerinden de değişken çağıramayız, değerini de çağıramayız, sadece ona değer atayabiliriz.
        //neden null olma ihtimali var? ya string değilse obj, obj' nin değerini str'ye cast edemeyiz, dolu veya boş olduğuna emin olamayız.
        //scope içerisinde kullanabiliyoruz fakat scope dışında kullanamıyoruz.

        //scope içinde tanımlandığı için hata vermedi
        str = "Sevim";
        Console.WriteLine(str);
    }
}