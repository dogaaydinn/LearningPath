namespace LearnProgramming.Keywords.Modifiers;

public class Const
{

    #region Const
    
    /*
     * Bir değişken tanımlaması sağlanır, fakat tanımlanan bu değişken daha sonra hiç bir şekilde değiştirilemez
     * const ifadesi de static bir ifadedir, fakat static ifadeler sonradan değişebiliyor iken const'lar sabittir ve sadece tanımlandığı yerde bir kez değer ataması yapılır.
     * !!!!! const ifadeler sadece primative(int, double,short) değerler ile birlikte kullanılır. Referans bazlı tanımlarla birlikte kullanılamazlar.
     */
    
    /*
     * const ifadeler compile time'da değer atanır ve bu değerler değiştirilemez.
     */
    
    /*
     * const ifadeleri referans tipleri string veya null olan değerler ile kullanılabilir.
     * onun haricinde stackte referans tipleri string ve null olan değerler ile kullanılabilir.
     */
    
    //Constants can be numbers, Boolean values, strings, or a null reference. 

    

    #endregion

    #region Interview Questions
    
    /*
     *  Bugün herkesin bildiği ama aslında aralarında farklar bulunan 3 keywordü inceleyeceğiz: const, readonly ve static.
     *  mülakatta bana sorulan readonly ile const arasındaki fark nedir sorusuydu.
     * Buna ek olarak bugün const olarak tanımladığım değişkeni değiştirmek istediğimde (.net core - vs - debug mode) kodu tekrardan derlememi istedi, değişkeni daha sonra readonly yaptığımda buna gerek kalmadığını gördüm.
     */
    #endregion
    
    
    /*
     * declaration nedir?
     * Bir değişkenin tanımlandığı yerdir.
     * 
     */
    
    /*
     * initialization nedir?
     * Bir değişkenin ilk değerinin atanmasıdır.
     *
     */
    
    /*
     * readonly nedir?
     * readonly değişkenler tanımlandıkları yerde veya sınıfın yapıcı metotlarında değer ataması yapılabilirler.
     * readonly class fieldında tanımlanır.
     * readonly kullanıldıktan sonra declare edildiği yerde inizilation yapılmadıysa sonra constructer içinde inizilation yapılabilir.
     * en büyük farkı runtime'da değer atanabilir olmasıdır.
     */
    
    /*
     * readonly can be used for run-time constants.
     * const can be used for compile-time constants.
     */
    
    public static void Main()
    {
        const int value = 10;
        // value = 20; // Error: A const field cannot be assigned to (except in a static constructor or a variable initializer)
        
        // const int value2; // Error: A const field requires a value to be provided
    }
}