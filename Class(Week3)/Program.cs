// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//1.First class and method ToString()
//using System;

//public class ClassW3
//{
//    public static void Main(string[] args)
//    {
//        Person[] persons = new Person[3];

//        for (int i = 0; i < 3; i++)
//        {
//            persons[i] = new Person()
//            {
//                Name = Console.ReadLine()
//            };
//        }

//        for (int i = 0; i < 3; i++)
//        {
//            Console.WriteLine(persons[i].ToString());
//        }

//        Console.ReadLine();
//    }

//    public class Person
//    {
//        public string Name { get; set; }

//        public override string ToString()
//        {
//            return "Hello! My name is " + Name;
//        }
//    }
//}
//2.Create a C# program that prompts the user for three names of people and stores them in an
//array of Person-type objects. To do this, first create a Person class that has a Name property of
//type string, a constructor that receives the name as a parameter, a destructor that assigns the
//name to empty and overwrites the ToString () method.
//End the program by reading the people and executing the ToString () method on screen.

//using System;
//public class ClassW3
//{
//    public static void Main(string[] args)
//    {
//        Person[] persons = new Person[3];

//        for (int i = 0; i < 3; i++)
//        {
//            persons[i] = new Person(Console.ReadLine());
//        }

//        for (int i = 0; i < 3; i++)
//        {
//            Console.WriteLine(persons[i].ToString());
//        }
//    }

//    public class Person
//    {
//        public string Name { get; set; }

//        public Person(string name)
//        {
//            Name = name;
//        }

//        public override string ToString()
//        {
//            return "Hello! My name is " + Name;
//        }

//        ~Person()
//        {
//            Name = string.Empty;
//        }
//    }
//}
//3.Class person, student and teacher
//using System;

//public class ClassW3
//{
//    public static void Main()
//    {
//        Person myPerson = new Person();
//        myPerson.Greet();

//        Student myStudent = new Student();
//        myStudent.SetAge(24);
//        myStudent.Greet();
//        myStudent.ShowAge();
//        myStudent.Study();

//        Teacher myTeacher = new Teacher();
//        myTeacher.SetAge(30);
//        myTeacher.Greet();
//        myTeacher.Explain();
//    }
//}

//public class Person
//{
//    protected int age;

//    public void Greet()
//    {
//        Console.WriteLine("Hello!");
//    }

//    public void SetAge(int n)
//    {
//        age = n;
//    }
//}

//public class Student : Person
//{
//    public void Study()
//    {
//        Console.WriteLine("I'm studying");
//    }

//    public void ShowAge()
//    {
//        Console.WriteLine("My age is {0} years old", age);
//    }
//}
//public class Teacher : Person
//{
//    public void Explain()
//    {
//        Console.WriteLine("I'm explaining");
//    }
//}
//4.Photo book class
//using System;

//public class ClassW3
//{
//    public static void Main()
//    {
//        PhotoBook myAlbum1 = new PhotoBook();
//        Console.WriteLine(myAlbum1.GetNumberPages());

//        PhotoBook myAlbum2 = new PhotoBook(24);
//        Console.WriteLine(myAlbum2.GetNumberPages());

//        SuperPhotoBook myBigPhotoAlbum1 = new SuperPhotoBook();
//        Console.WriteLine(myBigPhotoAlbum1.GetNumberPages());
//    }
//}

//public class PhotoBook
//{
//    protected int numPages;

//    public PhotoBook()
//    {
//        numPages = 16;
//    }

//    public PhotoBook(int numPages)
//    {
//        this.numPages = numPages;
//    }

//    public int GetNumberPages()
//    {
//        return numPages;
//    }
//}

//public class SuperPhotoBook : PhotoBook
//{
//    public SuperPhotoBook()
//    {
//        numPages = 64;
//    }
//}
//5.Inheritance of objects
//using System;

//public class ClassW3
//{
//    public static void Main(string[] args)
//    {
//        Person[] persons = new Person[3];

//        for (int i = 0; i < 3; i++)
//        {
//            if (i == 0)
//            {
//                persons[i] = new Teacher(Console.ReadLine());
//            }
//            else
//            {
//                persons[i] = new Student(Console.ReadLine());
//            }
//        }

//        for (int i = 0; i < 3; i++)
//        {
//            if (i == 0)
//            {
//                ((Teacher)persons[i]).Explain();

//            }
//            else
//            {
//                ((Student)persons[i]).Study();
//            }
//        }
//    }

//    public class Person
//    {
//        protected string Name { get; set; }

//        public Person(string name)
//        {
//            Name = name;
//        }

//        public override string ToString()
//        {
//            return "Hello! My name is " + Name;
//        }

//        ~Person()
//        {
//            Name = string.Empty;
//        }
//    }
//    public class Teacher : Person
//    {
//        public Teacher(string name) : base(name)
//        {
//            Name = name;
//        }

//        public void Explain()
//        {
//            Console.WriteLine("Explain");
//        }
//    }
//    public class Student : Person
//    {
//        public Student(string name) : base(name)
//        {
//            Name = name;
//        }

//        public void Study()
//        {
//            Console.WriteLine("Study");
//        }
//    }




