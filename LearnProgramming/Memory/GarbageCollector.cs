namespace LearnProgramming.Memory;

public class GarbageCollector
{
    /*
     * The garbage collector (GC) is a program that manages the objects on the heap,
     * it allocates objects and reclaims objects that are no longer being used
     * - freeing memory for future allocations.
     */
    
    /*
     * The GC is a part of the runtime environment, it is not a part of the language.
     * The GC is responsible for managing the memory of the managed code.
     */

    public void GarbageCollectorExample()
    {
        // The garbage collector is responsible for managing the memory of the managed code
        object obj = new object();
        obj = null;
        
        // The garbage collector will reclaim the memory occupied by obj
        
        // The garbage collector will run automatically when the memory is needed
        // The garbage collector can also be forced to run using GC.Collect()
    }
}