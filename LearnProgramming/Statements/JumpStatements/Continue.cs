namespace LearnProgramming.Statements.JumpStatements;

public class Continue
{
    //continue komutu döngüler dışında kullanılamaz.(for, foreach, while, do-while)
    
    //örnek 1- for Döngüsünde continue
    
    public void ContinueExample1()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0) // i çift ise
            {
                continue; // Bu döngü adımını atla
            }
            Console.WriteLine(i); // i tek ise yazdır
        }

    }
    
    //örnek 2- while Döngüsünde continue

    public void ContinueExample2()
    {
        int j = 0;
        while (j < 10)
        {
            j++;
            if (j % 2 == 0) // j çift ise
            {
                continue; // Bu döngü adımını atla
            }
            Console.WriteLine(j); // j tek ise yazdır
        }

    }
    
    //örnek 3 - foreach Döngüsünde continue

    public void ContinueExample3()
    {
        string[] names = { "Alice", "Bob", "Charlie", "David" };
        foreach (var name in names)
        {
            if (name.StartsWith("B")) // İsmi 'B' ile başlıyorsa
            {
                continue; // Bu döngü adımını atla
            }
            Console.WriteLine(name); // Diğer isimleri yazdır
        }

    }
    
    //örnek 4 - do-while Döngüsünde continue

    public void ContinueExample4()
    {
        int k = 0;
        do
        {
            k++;
            if (k % 2 == 0) // k çift ise
            {
                continue; // Bu döngü adımını atla
            }
            Console.WriteLine(k); // k tek ise yazdır
        } while (k < 10);

    }
}