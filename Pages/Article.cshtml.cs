using Microsoft.AspNetCore.Mvc.RazorPages;
using Data;
namespace Pages;
public class ArticlePageModel : PageModel
{
    private readonly WeblogContext _context;
    public ArticlePageModel(WeblogContext context)
    {
        _context = context;
    }
    public ArticleModel Article { get; set; }

    public void OnGet()
    {
        //TODO: fill the ArticleModel with a query
    }

    public class ArticleModel
    {
        public string Title { get; set; }

        public ArticleCategory Category { get; set; }

        public DateTime PublishDate { get; set; }
        public string? ImageUrl { get; set; }

        public string AuthorNameOrUserName {get; set; }

        public string ContentFilePath { get; set; }
    
    }

}