namespace LearnProgramming.Statements.JumpStatements;

public class Break
{
    //döngülerde (for, foreach, while, do-while) ve switch ifadelerinde kullanılır. 
    
    //örnek 1- for Döngüsünde break
    public void BreakExample1()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break; // Döngüyü sonlandır
            }
            Console.WriteLine(i);
        }

    }
    
    //örnek 2- while Döngüsünde break
    public void BreakExample2()
    {
        int j = 0;
        while (j < 10)
        {
            if (j == 5)
            {
                break; // Döngüyü sonlandır
            }
            Console.WriteLine(j);
            j++;
        }

    }
    
    //örnek 3- foreach ifadesinde break
    public void BreakExample3()
    {
        string[] names = { "Alice", "Bob", "Charlie", "David" };
        foreach (var name in names)
        {
            if (name == "Charlie")
            {
                break; // Döngüyü sonlandır
            }
            Console.WriteLine(name);
        }

    }
    
    //örnek 4- do-while Döngüsünde break

    public void BreakExample4()
    {
        int k = 0;
        do
        {
            if (k == 5)
            {
                break; // Döngüyü sonlandır
            }
            Console.WriteLine(k);
            k++;
        } while (k < 10);

    }
    
    //örnek 5- switch ifadesinde break

    public void BreakExample5()
    {
        int number = 2;
        switch (number)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            default:
                Console.WriteLine("Other");
                break;
        }

    }
}