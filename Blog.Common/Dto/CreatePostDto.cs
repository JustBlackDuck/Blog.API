using System.ComponentModel.DataAnnotations;

namespace Blog.Common.Dto;

public class CreatePostDto
{
    [Required]
    public string Heading { get; set; }
    
    [Required]
    public string Text { get; set; }
}