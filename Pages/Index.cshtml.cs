using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pages;
public class ArticleOverviewModel
    {
        public string Title { get; set; }

        public string? ImageUrl { get; set; }
        
        public Data.ArticleCategory Category { get; set; }
        
    }
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    //TODO: design the backend and connect it 
    public ArticleOverviewModel[] Articles = new ArticleOverviewModel[]
    {
        new()
        {
            Title = "Introduction to ASP.NET Core",
            Category = Data.ArticleCategory.Technology
        },
        new()
        {
            Title = "Healthy Eating Habits",
            Category = Data.ArticleCategory.LifeStyle
        },
        new()
        {
            Title = "The Wonders of Quantum Physics",
            Category = Data.ArticleCategory.Science
        },
        new()
        {
            Title = "Top 10 Soccer Goals of All Time",
            Category = Data.ArticleCategory.Entertainment
        }
    };

    public void OnGet()
    {

    }
    
}
