namespace LearnProgramming.OOP.ClassMembers;

public class Property
{
 /*
  * nesne kendi içerisinde özellik/property sağlar
  * property aslında bir metottur.
  * fiziksel olarak metotlardan farkı vardır.
  * fark: parametre almaz, içinde get ve set taşır
  * propertyler void olamaz.
  */

 /*
  * property ne zmn kullanılır?
  * developerlar nesne içerisindeki fieldlara direkt erişilmesini istemez
  * bir kontrol mekanizması istenir
  * fieldlardaki verileri kontrollü bir şekilde dışarıya açmak isteriz
  * bu durumu property üzerinde yaparız
  */

 /*
  * property yapıları özünde nesne içerisindeki bir field'ın dışarıya kontrollü şekilde açılmasını ve kontrollü şekilde dışarıdan değer almasını sağlayan yapılardır.
  * propertylerin bu işevine Encapsulation(kapsülleme/sarmalama) denir
  */

 /* PROPERTY İMZALARI
  1- FULL PROPERTY
  2- PROP PROPERTY
  3- AUTO PROPERTY INITILIZER
  4- REF READONLY RETURNS
  5- COMPUTED(HESAPLANMIŞ) PROPERTIES
  6- EXPRESSION-BODIED PROPERTY
  -READ ONLY PROPERTY
  7- INIT ONLY PROPERTIES VE INIT ACCESSOR
  */

 //1-FULL PROPERTY
 /*
  * en sade property yapılanmasıdır
  * içerisinde get ve set tanımlanmalıdır
  */
 #region Full property
 
 public class Person
 {
  // Özel alan  
  private string _name;
  private int _age;

  // Full property - Name  
  public string Name
  {
   get { return _name; } // Değeri okuma yöntemi  
   set
   {
    // Set yöntemi, burada bir kontrol yapılabilir  
    if (string.IsNullOrWhiteSpace(value))
    {
     throw new ArgumentException("Name cannot be empty.");
    }

    _name = value; // Değeri ayarlama  
   }
  }

  // Full property - Age  
  public int Age
  {
   get { return _age; } // Değeri okuma yöntemi  
   set
   {
    if (value < 0)
    {
     throw new ArgumentOutOfRangeException("Age cannot be negative.");
    }

    _age = value; // Değeri ayarlama  
   }
  }
 }

// Kullanım örneği  
 class Program
 {
  static void Main(string[] args)
  {
   Person person = new Person();

   // Özelliklerle değer atama  
   person.Name = "John Doe";
   person.Age = 30;

   // Özelliklerle değer okuma  
   Console.WriteLine($"Name: {person.Name}");
   Console.WriteLine($"Age: {person.Age}");

   // Hatalı değer atama örneği  
   try
   {
    person.Name = ""; // Bu bir hata üretecektir.  
   }
   catch (ArgumentException ex)
   {
    Console.WriteLine(ex.Message);
   }
  }
 }
 #endregion
//2-Prop property
/*
 * prop propertyler compile edildikleri arka planda kendi fieldlarını oluştururlar.
 * dolayısıyla bir field tanımlamaya gerek yoktur.
 */
 #region Prop property

 public class Person2
 {
  // Prop property - Name  
  public string Name { get; set; }

  // Prop property - Age  
  public int Age { get; set; }
 }
 #endregion
//  3- AUTO PROPERTY INITILIZER
/*
 * C# 6.0 ile gelen özelliktir.
 * Sınıf içerisinde kullandığımız Property değişken yapılarına ilk değeri verme özelliğidir.
 * read only yapan bir özelliktir.
 * write işlemi yapılamaz.
 */

 #region AUTO PROPERTY INITILIZER
 public class Person3
 {
  // Auto property initializer  
  public string Name { get; set; } = "John Doe";
  public int Age { get; set; } = 30;
 }
  
 #endregion
//  4- REF READONLY RETURNS
/*
 * C# 7.2 ile gelen özelliktir.
 * https://www.gencayyildiz.com/blog/c-7-2-ref-readonly-returns/
 */
 #region REF READONLY RETURNS
public class Person4
{
 // Ref readonly returns  
 public string Name { get; } = "John Doe";
 public int Age { get; } = 30;
}

 #endregion
//  5- COMPUTED(HESAPLANMIŞ) PROPERTIES
/*
 *
 */
 #region COMPUTED(HESAPLANMIŞ) PROPERTIES

 public class Person5
 {
  // Computed properties  
  public string Name { get; set; }
  public int Age { get; set; }

  // Computed property - FullName  
  public string FullName
  {
   get { return $"{Name} Doe"; }
  }
 }
 
 #endregion
//  6- EXPRESSION-BODIED PROPERTY
/*
 * tanımlanmış bir propertynin get ve set metodlarını expression-bodied member ile tanımlamak
 * lambda expression ile tanımlamak
 * read only yapan bir özelliktir.
 */
 #region EXPRESSION-BODIED PROPERTY
 public class Person6
 {
  // Expression-bodied property  
  public string Name { get; set; }
  public int Age { get; set; }

  // Expression-bodied property - FullName  
  public string FullName => $"{Name} Doe";
 }

 #endregion
 //  7- INIT ONLY PROPERTIES VE INIT ACCESSOR
/*
 * C# 9.0 ile gelen özelliktir.
 * https://www.gencayyildiz.com/blog/c-9-0-init-only-properties-ve-init-accessor/
 */
}

