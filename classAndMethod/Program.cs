using classAndmethod;
Users user = new();
user.SetUser("rushab","Admin@#23");
List<string> resp = user.GetUser();
Console.WriteLine(resp);
foreach(string res in resp)
{
    Console.WriteLine(res);
}
bool login = user.Login("rushab","Admin@#23");
if(login) Console.WriteLine("login Successful");
else Console.WriteLine("Incorrect credential");
Student student = new();
student.SetUser("NishanPaudel","Paudel@#123");
student.SetStudentId(12);
student.DisplayStudent();


