namespace LearnProgramming.Convert;

public class Convert
{
   /*
    * Convert sınıfı, farklı temel türler arasında güvenli bir şekilde dönüştürme yapmak için çeşitli yöntemler sağlar.
    * İstisnaları dahili olarak ele alır ve dönüştürme mümkün değilse bir türün varsayılan değerini döndürür.
    */
    
   //  Herhangi bir değişkeni hatta nesneyi string türüne dönüştürebilirsiniz.
   
   // Int olan bir değişkeni her zaman string türüne dönüştürebilirsiniz.
   
   // Int olan bir değişkenin değeri 0 veya 1 ise bool türüne dönüştürebilirsiniz.
   
   // String olan bir değişken sadece sayısal bir değer içeriyorsa int türüne dönüştürebilirsiniz.
   
   // String olan bir değişkenin değeri "True" veya "False" veya 0,1  ise bool türüne dönüştürebilirsiniz.
   
   // Bool olan bir türü , int türüne dönüştürürseniz true ise 1 , false ise 0 olarak dönüştürür.
   
   // Datetime olan bir türü string türüne dönüştürebilirsiniz.
   
   // Datetime olan bir türü string haricinde bir türe dönüştürmek isterseniz, önce string türüne dönüştürüp daha sonra diğer türe dönüştürebilirsiniz.
   
   // Object olan bir türe bütün değişken türlerini dönüştürebilirsiniz.
   
   /*
    
    //TODO: İngilizce ekle,türkçe ekle
    
Note:
    A.Implicit conversions:
        1.No syntax required
        2.type safe conversions (No data will be lost)
        3.Example :
            a.conversions from smaller to larger integral types :(int -> double)
            b.Conversions from derived classes to base classe


    B.Explicit conversions (Cast):
        1.Syntax required
        2.NOT type safe conversions (data loss might occur)
        3.Example :
            a.conversions from larger to smaller integral types :(Double -> int)
            b.Conversions from base classe to derived classes

    C.Parse / TryParse

    D.Convert.To_X

*/

   private void ConvertExample()
   {
      int number = 10;
      string stringNumber = number.ToString();

      bool boolNumber = number == 1;

      string stringBool = boolNumber.ToString();

      int intBool = Convert.ToInt32(boolNumber);

      string stringDateTime = DateTime.Now.ToString();

      DateTime dateTime = DateTime.Parse(stringDateTime);

      object objectNumber = number;

      int intObject = (int)objectNumber;
     
   }

   private static int ToInt32(bool boolNumber)
   {
      throw new NotImplementedException();
   }
}
