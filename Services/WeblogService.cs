using Data;
using Pages;
namespace Services;
public class WeblogService
{
    private readonly WeblogContext _context;
    public WeblogService(WeblogContext context)
    {
        _context = context;
    }
    public IndexModel.ArticleOverviewModel[] GetAllArticleOverviews()
    {
        return _context.Articles.MapArticleToOverview().ToArray();
    }
    public ArticlePageModel.ArticleModel GetArticleWithId(int id)
    {
        //FindBetterWay: having 3 classes for article? (one for database model, one DTO with path, one for the page view)
        //TODO: the file path (putting the article Id on the file's name)

        // p : article with content path instead of content
        var p = _context.Articles.MapArticleWithContentPath(id).Single();
        return new()
        {
            Title = p.Title,
            AuthorUserName = p.AuthorUserName,
            Category = p.Category,
            PublishDate = p.PublishDate,
            ImageUrl = p.ImageUrl,
            Content = File.ReadAllText(p.ContentFilePath)
        };
    }
    
}