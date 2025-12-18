
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;


int num =3;
num =5; // this is stateful becuz it is changing the previous state
Console.WriteLine("hello"); // this is stateless because it doesn't hamper other LOC.
Console.WriteLine(num);


//this is instance of a Random class -- It is called an object.
Random dice = new();
int roll = dice.Next(0,30); // this also the stateful method since it is using the state variable dice checking the previous state.
//Here if there is any error in the Random then the exception is called ArgumentOutOfRangeException.
// Console.WriteLine(roll);
/*Have you ever questioned what that new is for??
    1. request address in computer's memory,
    2. create new object and store it in the address
    3. return the address and store in dice object.
Now here the dice is like a variable thats stores the state of Random Class
*/
// Console.Clear();

//string is also class!! It has multiple methods like ToUpper, ToLower, Contains and many more...
string listOfWords = "hello my name is fox and who you are? are you dog?";


string[] name = [
  "rushab","rishav","nishan","anish","prayojan","aashish"  
];

Random generateNameId = new();
int indexValue = generateNameId.Next(name.Length);

Console.WriteLine($"The random name is {name[indexValue]}");
int firstValue = 500;
int secondValue = 600;
int largeValue = Math.Max(firstValue,secondValue);
Console.WriteLine($"The large value is {largeValue}");


