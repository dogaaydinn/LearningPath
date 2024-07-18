namespace LearnProgramming.Conversion;

public class UsingConstructor
{
    /*
     When we want to perform conversions between types that don’t represent the same concept, we should not do it by overloading the explicit and implicit operators. Instead, we should use a method to do it. 
     1- constructor Person instance ı aldığını varsayarsak; constructor içerisine veya constructor parametreleri içerisinde Person instance ı alarak bu instance ın property lerini kullanabiliriz.
     2- static method kullanarak da Person instance ı alabiliriz.
     */
    //TODO: Türkçe ekle
    
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public class Student : Person
    {
        public int StudentID { get; set; }
        public string Major { get; set; }

        // Constructor that takes a Person instance and additional Student-specific parameters
        public Student(Person person, int studentID, string major) : base(person.Name, person.Age)
        {
            StudentID = studentID;
            Major = major;
        }
        
        private Student(string name, int age, int studentID, string major) : base(name, age)
        {
            StudentID = studentID;
            Major = major;
        }

        public static Student FromPerson(Person person, int studentID, string major)
        {
            return new Student(person.Name, person.Age, studentID, major);
        }

        static Person doğa = new Person("Doğa", 24);
        
        Student student = new Student(doğa, 123, "Software Engineering");
    }
}