namespace LearnProgramming;

public class Compiler
{
    /*
     * Compiler nedir?
     * Derleyici, programlama dilindeki kodların makine tarafından okunabilir ve işlenebilir hale getirilmesi sürecidir.
     * Derleyici, yazılan kodu derleme işlemi sonucunda çalıştırılabilir bir çıktı oluşturur.
     */
    /*Önemli!
     * Programlama dillerinde derleme süreci, yazılan kodun bilgisayar tarafından anlaşılabilir hale getirilmesini sağlar. Derleme sonucunda bilgisayarın kodu anlayabilme yeteneği artar, bu da iletişimi kolaylaştırır.
     * Kodların derlenmesi, kodların çalıştırılabilir hale getirilmesi sürecidir. Derleme işlemi, editörler tarafından otomatik olarak yapılır, bu nedenle kullanıcının doğrudan ilgilenmesi gerekmez.
     */
    
    /*
     * Derleme işlemi nasıl yapılır?
     * Derleme işlemi, yazılan kodun derleyici tarafından okunması ve işlenmesi sürecidir.
     * Derleyici, yazılan kodu okur ve işler. Ardından, kodun çalıştırılabilir bir çıktı oluşturur.
     * Derleme işlemi, yazılan kodun hatalarını tespit eder ve düzeltir.
     * Derleme işlemi sonucunda, çalıştırılabilir bir dosya oluşturulur.
     */
    /*Derleyicinin programlama dilindeki kodları makine diline nasıl dönüştürdüğünü açıklayabilir misiniz?
     *Tokenizasyon (Tokenization): Öncelikle derleyici programlama dilindeki kodu tokenlara bölerek parçalarına ayırır. Tokenler birer sembol, kelime veya anlam birimi gibi işlev görür.
     * Ayrıştırma (Parsing): Tokenler, dilin sözdizimi (syntax) kurallarına uygun bir yapı oluşturacak şekilde ayrıştırılır. Bu adımda programlama dilinin kurallarına uygunluk kontrol edilir.
     * Sentaks Analizi (Syntax Analysis): Ayrıştırılan yapı, dilin sentaks kurallarına göre incelenir ve doğrulanır. Sentaks analizi, yapılan hataları tespit eder ve düzeltmeye yardımcı olur.
     * Semantik Analiz (Semantic Analysis): Derleyici, programın anlamını anlamak için semantik analiz yapar. Bu adımda değişkenlerin doğru tanımlanması, fonksiyonların uygun biçimde kullanılması gibi işlemler kontrol edilir.
     * Optimizasyon (Optimization): Derleyici, programın daha hızlı veya daha az bellek kullanarak çalışmasını sağlamak için kod üzerinde optimizasyon adımları uygular. Bu adımlar, kodun daha verimli hale gelmesini sağlar.
     * Kod Üretimi (Code Generation): Tüm kontroller yapıldıktan sonra derleyici, programlama dilinde yazılmış olan kodu makine diline çevirir. Bu adımda, derlenmiş kod makine talimatları olarak oluşturulur ve çıktı olarak kullanıcıya sunulur.  
     */
    /*Derleyici çıktısının kullanıcının işletim sisteminde çalıştırılabilir hale gelmesi için neler yapılır?
     * Derlenen Programın Linklenmesi: Bir program genellikle birden fazla dosyadan oluşabilir. Derlenen kodun farklı dosyalardan geldiği durumlarda, bu dosyaları bir araya getirerek birleştirme işlemi yapılması gerekir. Bu işlem genellikle linkleme adı verilen bir süreçle gerçekleştirilir.
     * Hedef Platforma Uygun Olarak Derlenme: Derlenen programın hedeflenen işletim sistemi ve işlemci mimarisi gibi özelliklere uygun olarak derlenmesi gerekmektedir. Örneğin, Windows işletim sistemi için derlenmiş bir programın, macOS işletim sistemine kurulması mümkün olmayabilir.
     * İzinler ve Güvenlik Kontrolleri: İşletim sistemi genellikle işletilecek programın güvenliğini sağlamak için belirli izinler ve kontroller yapar. Derlenen programın bu izinleri alması ve gerekli güvenlik kontrollerinden geçmesi gerekir.
     * Yürütülebilir Dosya Oluşturma: Son adımda, derlenen ve linklenen programın yürütülebilir dosya formatına dönüştürülmesi gerekmektedir. Bu genellikle bir yürütülebilir dosya (executable) veya bir kitaplık (library) dosyası olarak olabilir.
     */
    
    /*Derleyici sürecinde oluşan farklı çıktılar nelerdir ve bunların kullanım alanları nelerdir? 
     * Makine Kodu (Executable Code): Derleyici, kaynak kodu makine diline dönüştürerek çalıştırılabilir bir dosya oluşturur. Bu dosya, bilgisayar tarafından doğrudan yürütülebilir ve programın istenilen işlevleri gerçekleştirmesini sağlar.
     * Nesne Dosyaları (Object Files): Derleyici, kaynak kodu derlerken her bir kaynak dosyadan nesne dosyaları oluşturabilir. Bu nesne dosyaları, genellikle bir sonraki adım olan bağlayıcı (linker) tarafından bir araya getirilerek çalıştırılabilir dosya oluşturulur.
     * Hata ve Uyarı Raporları: Derleyici çoğu zaman kodunuzu derlerken hata ve uyarı mesajları üretir. Bu mesajlar size kodunuzda potansiyel hataları veya iyileştirmeleri belirtir. Bu raporlar, kodunuzun güvenilirliğini ve performansını artırmak için kullanılabilir.
     */
    
    /*Derleyiciler kodumuzu bayt kodlarına göre çok iyi optimize eder ve bu nedenle tasarım ve prensipleri göz önünde bulundurarak kod yazmayı düşünmeliyiz ve elbette insan, kodu kendi kodu olarak belgelenmiş olarak anlayabilir.
     Herhangi bir aptal, bir bilgisayarın anlayabileceği kod yazabilir. İyi programcılar, insanların anlayabileceği kod yazarlar.(Martin Fowler)
     */
    
    /*
     * The key to coding for best performance is make the code maintainable and natural first. More often than not this will be optimised by your compiler into well performing code, because the compiler has been designed to recognize these normal structures and optimise them the best way it can.
     * Performance test your code when it is finished and look for a bottleneck. Then spend time reviewing this bottleneck to see if you can optimise it. This will give you the best performance improvement for your time. Don't waste time early on in the project trying to optimise little things until you know they have a big effect on performance.
     */
    
    /*Öneriler
     I always regarded the book Effective C#: 50 Specific Ways to Improve Your C# as a good book showing you how to write better code in C#; for example, it explains why you should use foreach instead of for when iterating over a collection.
     You asked for a book or article. One of the best books for best practices in .NET is
       
       Framework Design Guidelines: Conventions, Idioms, and Patterns for Reusable .NET
       The book is written by members of the .NET development team themselves.
       please see this book reference "Improving .NET Application Performance and Scalability": http://msdn.microsoft.com/en-us/library/ff649152.aspx
       
       This is very good tutorial which covers most part of .NET application
     */
}