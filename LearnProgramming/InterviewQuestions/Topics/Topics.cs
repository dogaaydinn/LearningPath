namespace LearnProgramming.InterviewQuestions.Topics;

public class Topics
{
 //TODO:OOP sonrası linkler okunacak.
 //TODO:Açıklama ve örnek ekle.
 //TODO: Türkçe ve İngilizce ekle.
 // !!!!https://www.simplilearn.com/tutorials/c-sharp-tutorial/c-sharp-interview-questions
 //https://www.amazon.com/System-Design-Interview-insiders-Second/dp/B08CMF2CQF
 
    /*
    - Covariance and Contravariance
    - Asynchronous Programming primitives, 
    - Concurrency primitives, 
    - Parallelism primitives
     -ConfigureAwait quirks
     -Parse a JSON string and aggregate the properties
    - Design a key-value store
     -build a hashtable based tree from scratch
    - How garbage collection works. How does the GC know what can be collected? What happens when something is collected? What is reference counting, how does it work? What kinds of things create “garbage”?
     -The differences between the stack and the heap. How does something end up on one vs the other? Which one offers better performance? Why does it offer better performance?
     -Understanding performance characteristics around containers. Many interviewees will memorize big O characteristics for the interview, but don't understand the memory footprint differences between containers, or they don't understand the performance difference between iterating over a List of structs versus a List of references, they don't understand what a cache miss is or vaguely understand a cache miss but not how to avoid it.
     -how core works. appsettings and secrets,
     -how does middleware work, 
     -dependency injection
     -why code to an interface?(this can lead to talks about abstractions, interface segregation, SOLID, unit testing, mocking, etc.)
     
     */
    
    /*
     Design Patterns
       
       SOLID Principles
       
       Async / Await, Parallelism in the BCL
       
       If your job is Web based, how ASP.NET Pipeline works. If client based, how WPF / WinForms works
       
       Data Structures, not only how they work but when you would use one or the other
       
       How LINQ works - what is an IEnumerable and what is deferred execution? Why is that important when using ORMs?
     */
    
    /*
     * syntactic sugar
     * async/await
       
       foreach
       
       yield return
       
       Are probably the most extreme versions of "syntactic sugar" in C#. And by that I mean, these are features added to the language that don't actually have an equivalent in .NET. So, to make this possible, they're lowered to .NET compatible code. Just like var or a using. Those things don't actually exist in .NET, just in the C# language.
       
       They're so easy to use. So they seem simple, but they're not. All the complexities lie a level below where we work. So they're hidden really well and a lot of people never really take the time to look.
     */
    
    /*
     What is the difference between a reference type and a value type?
       
       What is a singleton?
       
       What is the difference between an array and a List?
       
       What is a dictionary/map, and when would you use it?
       
       How does that differ from a hashset?
       
       How does a static field differ from a non-static field?
       
       How would you call a static method vs an instance method?
       
       What is boxing and unboxing?
       
       What is a namespace and what is its purpose?
       
       What are the access modifiers, and briefly describe how they differ.
       
       What is the using statement used for, and what interface is used to support it?
       
       What is the difference between abstract classes and interfaces and when would you use one over the other?
       
       How does async/await work, and what is its purpose.
       
       What is the yield keyword used for and what interface is it commonly used in conjunction with?
       
       What method would you use in a LINQ query to filter results?
       
       What method would you use in a LINQ query to project or convert?
       
       What method would you use in a LINQ query to sort results?
       
       How are IEnumerable and IQueryable similar? How are they different?
       
       What do the letters MVC stand for, and what are the responsibilities of each?
       
       What are the common return types for an MVC action?
       
       What is dependency injection, why is it important?
       
       What are the 3 scopes for DI, and describe the difference of each (Transient, Singleton, Scoped).
       
       Html/CSS:
       
       What is the difference between a div and a span, and how would you get one to act like the other? (block vs inline)
       
       What are the 5 levels of specificity in order of most to least priority? (!important, inline style, id, class, tag)
       
       Describe the CSS Box model, and list the major properties from outside in. (margin, border, padding, content)
       
       What are the common CSS selectors?
       
       What is flexbox, grid, and containers, and when would you use each.
       
       How many columns does bootstrap typically have? (12)
       
       How does bootstrap achieve it's responsiveness? (Looking for any mention of media queries here)
       
       Webforms:
       
       What is ViewState?
       
       What is the clientIdMode attribute, and what is its purpose?
       
       Databases:
       
       What is a primary key? (The primary column(s) which are unique)
       
       What are indexes used for? (speeding up queries and optionally enforcing unique constraints)
       
       What is a clustered index? (physical ordering on disk)
       
       Are primary keys clustered? (They are by default)
       
       Are they always? (No, they do not have to be)
       
       Describe how you would enforce that there can only be one record in a table with a specific value? (Looking for unique constraint here)
       
       How would you get SQL code to run when table data is modified? (trigger)
       
       What is the primary purpose of a database view?
       
       What is the difference between WHERE and HAVING clauses? (pre and post aggregation)
       
       What is the difference between a relational database and a document store and when would you use one over the other?
       
       When would you use a microservice architecture over a monolith?
       
       When would you use a monolith over a microservice architecture?
       
       General questions, like what source control systems have you used? Are you familiar with CI/CD concepts? What is a PR? What is a branch and when would you use one?
       
       Depending on what else, can ask about what is REST, how does that differ from a WebAPI, etc.
       
     */
}