using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Data;
using Services;

namespace Pages;

public class IndexModel : PageModel
{
    private readonly WeblogService _service;
    public IndexModel(WeblogService service)
    {
        _service = service;
    }

    public ArticleOverviewModel[] ArticleOverviews {get; set; }

    public void OnGet()
    {
        ArticleOverviews = _service.GetAllArticleOverviews();

    }
public class ArticleOverviewModel
{
    public string Title { get; set; }

    public string? ImageUrl { get; set; }

    public Data.ArticleCategory Category { get; set; }
    //TODO: authentication
    public string AuthorUserName {get; set; }

}

}