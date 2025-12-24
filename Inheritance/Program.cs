using Inheritance.LivingStorage;
namespace Inheritance;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Human Data:");
        Console.WriteLine("--------------------------");
        HumanBeing rushab = new("Rushab Risal", 24,"9808721469","Mammal","Carnivorous","Land");
        rushab.Display();
        Console.WriteLine("-------------------------");
        Console.WriteLine("Plant Data");
        Console.WriteLine("-------------------------");
        Plants rose = new("Plant","Rose","Plants","Herbivorous","Land");
        rose.Display();
    }
}