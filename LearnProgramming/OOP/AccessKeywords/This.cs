namespace LearnProgramming.OOP.AccessKeywords;

public class This
{
    /*
     * 1.sınıfın nesnesini temsil eder.
     * 2.aynı isimde field ile metot parametrelerini ayırmak için kullanılır.
     * 3.bir constructor içerisinde başka bir constructor'ı çağırmak için kullanılır.
     */
    
    //https://medium.com/@ayaz.me/c-this-anahtar-kelimesi-767030d5c3e8

    #region 1. Alan (Field) ile Parametreyi Ayırma
    
    //1. Alan (Field) ile Parametreyi Ayırma
    //Sınıfın bir alanı (field) ve bir yöntemin (method) parametresi aynı ada sahipse, "this" keywordu kullanarak hangi değişkene atıfta bulunulduğu belirtilir.
    public class Person
    {
        private string name;

        public void SetName(string name)
        {
            this.name = name; // this.name sınıfın alanını ifade eder, name ise yöntemin parametresi.
        }
    }
    #endregion

    #region 2. Nesneye Erişim
    
    //2. Nesneye Erişim
    //"this" keywordu, bir nesne içerisindeki diğer yöntemlere veya özelliklere (properties) erişmek için kullanılır.
    public class Person2
    {
        private string name;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine(this.name); // this.name sınıfın alanını ifade eder.
        }
    }

    #endregion
    #region 3. Constructor'ı Çağırma
    //Bir constructor içerisinden aynı sınıfın başka bir constructor'ını çağırmak için "this" keywordu kullanılır.
    public class Person3
    {
        private string name;
        private int age;

        public Person3() : this("Unknown", 0)
        {
        }

        public Person3(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    #endregion

    #region 4. Geçerli Nesneyi Döndürme
//Bir nesnenin kendisini döndürmesi gerektiğinde "this" keywordu kullanılır.
    
    public class Person4
    {
        private string name;

        public Person4 SetName(string name)
        {
            this.name = name;
            return this; // Mevcut nesneyi döndür.
        }
    }

    #endregion
}