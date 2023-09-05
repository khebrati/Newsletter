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
}