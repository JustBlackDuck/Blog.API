using Blog.Database.Base;

namespace Blog.Database;

public class Post: BaseModel
{
    public string Heading { get; set; }
    public string Text { get; set; }
}
