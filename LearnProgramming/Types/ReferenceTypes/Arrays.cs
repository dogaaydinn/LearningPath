namespace LearnProgramming.Types.ReferenceTypes;

public class Arrays
{
    //TODO:Açıklama ve örnek ekle.
    //TODO: Türkçe ve İngilizce ekle.
    /*
     * aynı tipten çok sayıda değişken tanımlamak için kullanılır.
     * Bir dizideki elemanlar her zaman bitişik bir bellek bloğunda saklanır ve bu da yüksek verimli erişim sağlar.
     */
    //collection expression c# 12
    //https://medium.com/@nirajranasinghe/everything-you-need-to-know-about-c-12-collection-expressions-78b4897a676f
//https://www.bytehide.com/blog/array-csharp
// fonksiyonel array oluşturmak ne zmnkarşımıza çıkar
    public void Main()
    {
        Index first = 0;
        Index last = ^1;
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        char[] firstTwo = vowels[..2]; // 'a','e'
        char[] lastThree = vowels[2..]; // 'i','o','u'
    }
    
}