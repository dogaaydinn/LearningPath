namespace LearnProgramming.Variable;

public class Tuple
{
    //Tuple nedir?
    //Bir nesneyi birden fazla değişkenle tanımlamak için kullanılır.

//TODO: OOP sonrası okunacak.
    //https://www.buraksenyurt.com/post/tek-fotoluk-ipucu-155-c-7-0-tuple-iyilestirmeleri
    //https://www.buraksenyurt.com/post/tek-fotoluk-ipucu-154-c-7-0-out-iyilestirmesi
    //https://medium.com/@lexitrainerph/c-tuples-journeying-from-basics-to-mastery-9dff7ae8f92d



    public void TupleExample()
    {
        var tuple = (1, "Ahmet", 25.5);
        Console.WriteLine(tuple.Item1);
        Console.WriteLine(tuple.Item2);
        Console.WriteLine(tuple.Item3);

        // Değerleri değiştirmek
        tuple.Item1 = 2;
        tuple.Item2 = "Mehmet";
        tuple.Item3 = 30.5;

        Console.WriteLine(tuple.Item1);
        Console.WriteLine(tuple.Item2);
        Console.WriteLine(tuple.Item3);

        // Değerleri tuple'a atmak
        var (id, name, age) = tuple;

        Console.WriteLine(id);
        Console.WriteLine(name);
        Console.WriteLine(age);

        // Değerleri yeni bir tuple'a atmak
        var newTuple = (id, name, age);

        Console.WriteLine(newTuple.Item1);
        Console.WriteLine(newTuple.Item2);
        Console.WriteLine(newTuple.Item3);

        // Değerleri değiştirmek

        newTuple.Item1 = 3;
        newTuple.Item2 = "Ali";
        newTuple.Item3 = 35.5;

        Console.WriteLine(newTuple.Item1);
        Console.WriteLine(newTuple.Item2);
        Console.WriteLine(newTuple.Item3);

    }

}

