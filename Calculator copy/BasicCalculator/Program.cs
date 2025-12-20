/*
    This Project will focus in creation of basic calculator.
    No fancy way. It will be implemented in a lame way.
*/
/*
    What is include??
    addition
    substraction
    multiplication
    division
    remainder
    percentage
    power
    root values
*/
// I will not use any kind of AI or copilot, and use raw code no libraries.

//hamlai k chainxa
//variables where real time data will be stored temparily for calculation
// A brain that will perform calculation
using System;

int operandOne;
int operandTwo;
int total = 300;
operandOne = 2;
operandTwo = 3;
int addition = operandOne + operandTwo;
int multiplication  = operandOne * operandTwo;
float division = (float)operandTwo / (float)operandOne;
float remainder =operandTwo%operandOne ;
int substraction = operandTwo - operandOne;
double percentage = ((double)addition/(double)total) * 100; //finding percentage of there addition with respect to total
int power = operandOne ^ operandTwo;
int root = (int)Math.Sqrt(36);
int value = 1;
var testValue = (decimal)operandOne / (decimal)operandTwo;
Console.WriteLine($"Addition = {addition}");
Console.WriteLine($"Multiplication = {multiplication}");
Console.WriteLine($"Division = {division}");
Console.WriteLine($"Remainder = {remainder}");
Console.WriteLine($"substraction = {substraction}");
Console.WriteLine($"percentage = {percentage}%");
Console.WriteLine($"power = {power}");
Console.WriteLine(++value);
Console.WriteLine(value++);
Console.WriteLine(value);
Console.WriteLine(--value);
Console.WriteLine($"The root of 36 is {root}");

/*
Student: Sophia Johnson

Course          Grade   Credit Hours	
English 101         4       3
Algebra 101         3       3
Biology 101         3       4
Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35
*/
// string Course1 = "English 101";
// string Course2 = "Algebra 101";
// string Course3 = "Biology 101";
// string Course4 = "Computer Science 101";
// string Course5 = "Psychology 101";
int credit1 = 3;
int credit2 = 3;
int credit3 = 4;
int credit4 = 4;
int credit5 = 3;
int gradeA = 4;
int gradeB = 3;
int creditcourse1 = gradeA * credit1;
int creditcourse2 = gradeB * credit2;
int creditcourse3 = gradeB * credit3;
int creditcourse4 = gradeB * credit4;
int creditcourse5 = gradeA * credit5;
int sum = creditcourse1 + creditcourse2 + creditcourse3 + creditcourse4 + creditcourse5;
float gpa = (float)sum/(credit1+credit2+credit3+credit4+credit5);
Console.WriteLine(Math.Round(gpa,2,MidpointRounding.AwayFromZero));


