using CW15.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW15.Pages
{
    public class ExpertModel : PageModel
    {
        [BindProperty]
        public Service NewService { get; set; }
        public void OnGet()
        {

        }

        public void OnPost() 
        {

        }
    }
}
