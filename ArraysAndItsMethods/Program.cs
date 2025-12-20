// //declaring the array of string datatype with size of 3
// Span<string> fraudulantOrderIds = new string[5];
// //assigning the values to fraudulant array
// fraudulantOrderIds[0] = "ABC1";
// fraudulantOrderIds[1] = "ABC2";
// fraudulantOrderIds[2] = "ABC3";
// fraudulantOrderIds[3] = "ABC3";
// // int[] num = new int[5];
// Console.WriteLine(fraudulantOrderIds[0]+fraudulantOrderIds[1]+fraudulantOrderIds[2]+fraudulantOrderIds[3]);
// Console.WriteLine(fraudulantOrderIds.Length);
// //initializing the string array...
// // string[] name = {"rushab","nishan","anish"}; //this is old, we can use collection expression
using classAndmethod;
string[] firstName =["rushab","nishan","anish","manish"];
Console.WriteLine(firstName);
Console.WriteLine(firstName.Length);

//looping through array using foreach...
foreach(string name in firstName)
    Console.WriteLine(name);


int[] inventory = [200,100,50,60,300];
int sum = 0;
int bin = 0;
foreach(int items in inventory)
{
    sum+=items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

string[] fraudulantOrderId = ["B123","C234","A345","C15","B177","G3003","C235","B179"];
// foreach(string froudId in fraudulantOrderId)
// {
//     if (froudId.StartsWith('B'))
//     {
//         Console.WriteLine($"The name starts with B! :{froudId}");
//     }
// }
string[] combine = [..firstName,..fraudulantOrderId]; //using spread element .. we can combime multiple collection into one
foreach(string items in combine)
{
    Console.WriteLine(items);
}
List<int> value = [1,2,3];
Console.WriteLine(value.Count);
value.Clear();
Console.WriteLine(value.Count);
Console.WriteLine(value);
Student student = new();
student.SetUser("NishanPaudel","Paudel@#123");
student.SetStudentId(12);
student.DisplayStudent();
