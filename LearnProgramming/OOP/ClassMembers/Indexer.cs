namespace LearnProgramming.OOP.ClassMembers;

public class Indexer
{
    
    /*
     * property ile ayn özelliklere sahiptir.
     * 
     */
    
    public int this[int index]
    {
        get
        {
            return index;
        }
        set
        {
            index = value;
        }
    }
}