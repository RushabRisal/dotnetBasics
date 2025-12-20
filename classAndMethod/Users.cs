namespace classAndmethod;
    

 public class Users
{
    protected string? Username;
    protected string? Password;
    public void SetUser(string Username,string Password)
    {
        this.Username = Username;
        this.Password = Password;
    }
    public List<string> GetUser()
    {
        List<string> user = [this.Username,this.Password];
        return user;
    }
    public bool Login(string Username, string Password)
    {
        if (Username.Equals(this.Username) && Password.Equals(this.Password)) return true;
        return false;
    }
}
public class Student: Users
{
    private int StudentId;
    public void SetStudentId(int StudentId)
    {
        this.StudentId = StudentId;
    }
    public void DisplayStudent()
    {
        Console.WriteLine($"The username: {base.Username}, Password: {base.Password} and Student Id: {this.StudentId}");
    }
}