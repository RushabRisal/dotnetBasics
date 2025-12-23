using System.Diagnostics.CodeAnalysis;

namespace ReferenceTypes;
public class Person
{
    protected string Name {get;set;}
    protected int Age {get;set;}
    public Person(string Name, int Age) => (this.Name, this.Age) = (Name,Age);
}

public class Student : Person
{
    public string Major {get;set;} 
    public Student(string Name,int Age,string major) : base(Name, Age)
    {
        SetMajor(major);
    }
    public void Display()
    {
        Console.WriteLine($"Name: {base.Name}\nAge: {base.Age}\nMajor: {Major}");
    }
    [MemberNotNull(nameof(Major))]
    private void SetMajor(string? major)
    {
        Major = major ?? "Undefined";
    }
    public static void Main(string[] args)
    {
        string name = Console.ReadLine() ?? "Undefined";
        Student student = new(name,24,"software Engineer");
        student.Display();
    }
}