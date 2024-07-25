using System;
public class Person
{
    //Fields
    private string name;
    private int age;

    //constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    //properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age= value; }
    }

    //Methods
    public void DisplayInfo()
    {
        Console.WriteLine($"Name:{name} , Age:{age}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Creating an object of the persons class
        Person person1 = new Person("Mathew",20);

        //Accessing properties
        Console.WriteLine(person1.Name); //Output: Mathew
        person1.Age = 31;
    }
}