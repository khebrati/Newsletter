using Microsoft.AspNetCore.Mvc.RazorPages;
using Data;
using Microsoft.AspNetCore.Mvc;
using Services;
namespace Pages;
public class ArticlePageModel : PageModel
{
    private readonly WeblogContext _context;
    public ArticlePageModel(WeblogContext context)
    {
        _context = context;
    }
    [BindProperty(SupportsGet = true)]
    public int ArticleId { get; set; }
    
    public ArticleModel Article { get; set; }

    public void OnGet()
    {
        WeblogService service = new(_context);
        Article = service.GetArticleWithId(ArticleId);
    }

    public class ArticleModel
    {
        public string Title { get; set; }

        public string Category { get; set; }

        public DateTime PublishDate { get; set; }
        public string ImageUrl { get; set; }

        public string AuthorUserName {get; set; }

        public string Content { get; set; }
    
    }

}