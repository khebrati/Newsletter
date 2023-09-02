using System.ComponentModel.DataAnnotations.Schema;
//TODO: find the tool to understand EF core modeling
namespace Models;
public class Article
{
    public int ArticleId { get; set; }

    public string Title { get; set; }
    
    public ArticleCategory Category { get; set; }

    public DateTime PublishDate { get; set; }
    
    public string? ImageUrl {get; set; }

    [ForeignKey(nameof(Author))]
    public string AuthorUserName{ get; set; }
    
    public Author Author {get; set; }

    public string ContentFilePath { get; set; }
    
    
    
}