using System.ComponentModel.DataAnnotations;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;
namespace Pages
{
    public class PostModel : PageModel
    {

        public WeblogContext _context;
        public PostModel(WeblogContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ArticleInfo Input { get; set; }

        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("PostSubmitted");
            }
            return Page();
            //TODO: save the post to the database + it's date

        }


        public class ArticleInfo
        {
            [Required]
            [StringLength(200, ErrorMessage = "Max length is {1}")]
            public string Title { get; set; }


            public string? ImageUrl { get; set; }

            public string Body { get; set; }

            public Data.ArticleCategory Category { get; set; }


        }
    }
}
