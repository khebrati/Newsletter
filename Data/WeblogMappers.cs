using Pages;
namespace Data;
public static class WeblogMapper
{
    //TODO: all the database methods needed to fill in your ModelViews
    public static IQueryable<IndexModel.ArticleOverviewModel> MapArticleToOverview(this IQueryable<Article> articles)
    {
        return articles.Select(article => new IndexModel.ArticleOverviewModel()
            {
                Title = article.Title,
                ImageUrl = article.ImageUrl ?? "Images/no-image.webp",
                Category = article.Category,
                AuthorUserName = article.Author.UserName
            }
        );
    }
}