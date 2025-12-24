namespace Inheritance.LivingStorage;

//defining parent class that holds a comman attributes of living being
public class LivingBeing(string LivingType,string ComsumingType,string Habitats)
{
    protected string LivingType {get;} = LivingType;//plants or acquitic or mammal or reptile
    protected string ComsumingType {get;} = ComsumingType;
    protected string Habitats {get;} = Habitats;
}
public class HumanBeing(string name, int age, string contacts, string LivingType, string ComsumingType,string Habitats) : LivingBeing(LivingType,ComsumingType,Habitats)
{
    private string Name {get;} = name;
    private int Age {get;} = (age >= 18) 
        ? age 
        : throw new ArgumentException("Under Age"); 
    private string Contacts {get;} = (contacts.Length == 10)
        ? contacts
        : throw new ArgumentException("The lenght of Number should be exactly 10");
    public void Display()
    {
        Console.WriteLine($"Name: {Name}\nAge: {Age}\nContacts: {Contacts}\nLiving type: {LivingType}\nComsumer type: {ComsumingType}\nHabitats: {Habitats}");
    }
}
public class Plants(string Species, string PlantName,string LivingType, string ComsumingType,string Habitats)
    : LivingBeing(LivingType, ComsumingType, Habitats)
{
    private string Species {get;} = Species;
    private string PlantName {get;} = PlantName;
    public void Display()
    {
        Console.WriteLine($"Species: {Species}\nName: {PlantName}\nLiving type: {LivingType}\nComsumer type: {ComsumingType}\nHabitats: {Habitats}");
    }
}