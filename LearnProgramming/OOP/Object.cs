namespace LearnProgramming.OOP;

public class Object
{
 /*
  * C#'ta bir nesne, bir türün özelliklerini ve davranışlarını tanımlayan bir plan veya şablon olan bir sınıfın örneğidir.
  * Nesneler sınıflardan oluşturulur ve hem verileri (nitelikler veya özellikler) hem de yöntemleri (işlevler veya davranışlar) kapsar. 
  */
 //https://medium.com/@CodeCrack/what-is-an-object-in-c-with-examples-e98d59749d69
    /*
     * Nesne bir class ürünüdür.
     * nesneler içlerinde veri tutabilecek alanlar(field) barındırırlar.
     * nesnelerin oluşturulabilmesi için modellenmesi gerekir, nesneler class ile modellenir.
     * nesneler referans türlüdürler.
     */
    //Bir nesne temel olarak plana göre tahsis edilmiş ve yapılandırılmış bir bellek bloğudur.
    
    /*
     * Object türü tüm tür ve değişken tiplerini karşılayabilen bir türdür ve referans türlü bir değişkendir.
     * Aslında işi zaten derinlemesine incelediğimiz de ise tüm türler zaten object türünden türerler.
     */
    
    /*
     * Ram tarafında nasıl tutulduğunu ise kısaca özetlemek gerekirse object türünde tutulur fakat kendi öz türünü de içerisinde saklar buna da boxing ismi verilmektedir.
     * Bu şekilde object içerisinde ki veriyi kendi türünde tekrar elde edebilme imkanı ederiz buna da unboxing işlemi denmektedir.
     */
    public static void Main(string[] args){
     object num= 5; //boxing
     int toplam1 = num + 2; // Yanlış Kullanım
     int toplam2 = (int)num + 2; // Doğru kullanım
      
    }
    //Yani kısacası Boxing işleminde olan değişkenler ile işlem yapamayız unboxing ederek işlem yapmalıyız.
    
    
    /*
     * C#'da "object" türü, tüm diğer türlerin üst türü olarak tanımlanır. Yani, tüm C# sınıfları ve değer türleri "object" türünden türetilmiştir. "Boxing" işlemi, bir değer türünün "object" türüne dönüştürülmesini ifade ederken, "unboxing" ise bu işlemin tersidir; yani bir "object" türünü değer türüne geri döndürmeyi içerir. Bu dönüşümler sırasında dikkatli olunmalı, çünkü hatalı bir unboxing işlemi "invalid cast" hatasına yol açabilir.
     */
}