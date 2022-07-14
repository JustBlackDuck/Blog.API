using Blog.Database.Base;

namespace Blog.Database;

public class User: BaseModel
{
    public string Firstname { get; set; } 
    public string Surname { get; set; }
    public string Lastname { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateOnly DateOfBirthd { get; set; }
}
