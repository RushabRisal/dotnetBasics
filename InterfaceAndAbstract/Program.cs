

using System.Reflection.Metadata.Ecma335;

namespace InterfaceAndAbstract;

interface ISample
{
    void DisplayHello();
}
public class Test : ISample
{

    void ISample.DisplayHello()
    {
        Console.WriteLine("hello world");
    }
}
public class Dog: ISample
{
    void ISample.DisplayHello()
    {
        Console.WriteLine("Hello I am dog");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        ISample world = new Test();
        ISample dog = new Dog();
        world.DisplayHello();
        dog.DisplayHello();
    }
}