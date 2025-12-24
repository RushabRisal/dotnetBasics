int currentAssaignment = 5;
int[] sophiaScore = [90, 86, 87, 98, 100];
int [] andrewScores = [ 92, 89, 81, 96, 90 ];
int [] emmaScores = [90, 85, 87, 98, 68];
int [] loganScores = [90, 95, 87, 88, 96 ];
string[] names = ["Sophia","Andrew","Emma","Logan"];
int[] studentScores = new int[5];

Console.WriteLine("Students\tGrade");

static string NumericGrade(decimal num)
{
    if(num <= 59) return "F";
    else if(num <= 62) return "D-";
    else if(num <= 66) return "D";
    else if(num <= 69) return "D+";
    else if(num <= 72) return "C-";
    else if(num <= 76) return "C";
    else if(num <= 79) return "C+";
    else if(num <= 82) return "B-";
    else if(num <= 86) return "B";
    else if(num <= 89) return "B+";
    else if(num <= 92) return "A-";
    else if(num <= 96) return "A";
    else if(num <= 100) return "A+";
    return "";
}
foreach(string name in names)
{
    string currentStudent = name;
    if (currentStudent.Equals("Sophia"))
        studentScores = sophiaScore;
    else if (currentStudent.Equals("Andrew"))
        studentScores = andrewScores;
    else if (currentStudent.Equals("Emma"))
        studentScores = emmaScores;
    else if (currentStudent.Equals("Logan"))
        studentScores = loganScores;
    int studentSum = 0;
    decimal currentGrade = 0;
    foreach(int item in studentScores) studentSum += item;
    currentGrade = (decimal) studentSum / currentAssaignment;
    Console.WriteLine($"{currentStudent}\t\t{currentGrade}\t{NumericGrade(currentGrade)}");
}