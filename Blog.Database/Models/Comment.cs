using Blog.Database.Base;

namespace Blog.Database;

public class Comment: BaseModel
{
    public string Text { get; set; }
}