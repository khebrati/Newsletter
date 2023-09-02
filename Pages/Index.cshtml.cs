using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pages;
public class ArticleOverviewModel
{
    public string Title { get; set; }

    public string? ImageUrl { get; set; }

    public Models.ArticleCategory Category { get; set; }
    //TODO: authentication
    public string AuthorName {
        get
        {
            return "A person";
        }
    }



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
            Category = Models.ArticleCategory.Technology
        },
        new()
        {
            Title = "Healthy Eating Habits",
            Category = Models.ArticleCategory.LifeStyle
        },
        new()
        {
            Title = "The Wonders of Quantum Physics",
            Category = Models.ArticleCategory.Science
        },
        new()
        {
            Title = "Top 10 Soccer Goals of All Time",
            Category = Models.ArticleCategory.Entertainment
        }
    };

    public void OnGet()
    {

    }

}
