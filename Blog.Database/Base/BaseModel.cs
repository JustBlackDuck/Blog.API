namespace Blog.Database.Base;

public class BaseModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    /*public DateTime DateOfCreated { get; set; } = DateTime.Now;*/
    
}
