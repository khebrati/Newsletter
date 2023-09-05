using System.ComponentModel.DataAnnotations;
using Data;

public class Author
{
    [Key]
    public string UserName { get; set; }
    public string Password {get; set; }
    public string? EmailAddress {get; set; }
    public string? ProfileImageUrl { get; set; } //in wwwroot
    public ICollection<Article> Articles {get; set; }
}