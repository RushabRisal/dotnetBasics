using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace StudentRecordsProject.Records;

public class Student
{
    protected string StudentName {get;set;}
    protected int RollNo;
    protected int Semester;
    protected string Field{get;set;}
    protected string? Contact;
    protected string? Pronouce;
    public Student(string StudentName,int RollNo,int Semester,string Field,string Contact,string Pronouce)
    {
        SetStudent(StudentName);
        this.RollNo = RollNo;
        this.Semester = Semester;
        this.Field = Field;
        this.Contact = Contact;
        this.Pronouce = Pronouce;

    }
    public int Update(string StudentName,string? Contact,string? Pronouce)
    {
        if(StudentName == this.StudentName || Contact == this.Contact || Pronouce == this.Pronouce)
        {
            return 102;   
        }
        this.StudentName = StudentName;
        this.Contact = Contact;
        this.Pronouce = Pronouce;
        return 200;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {StudentName}\nRoll Number: {RollNo}\nSemester: {Semester}\nField: {Field}\nContact: {Contact}\nPronouce: {Pronouce}");
    }
    [MemberNotNull(nameof(StudentName))]
    private void SetStudent(string? StudentName = default)
    {
        this.StudentName = StudentName ?? "Undefined";
    }

}