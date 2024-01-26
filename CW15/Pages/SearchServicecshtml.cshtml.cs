using CW15.DataBase;
using CW15.DTO;
using CW15.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW15.Pages
{
    public class SearchServicecshtmlModel : PageModel
    {

        [BindProperty]
        public ServiceDTO ServiceDTO { get; set; } = new ServiceDTO() { categires = MyMemory.CategoriesList };
        public void OnGet()
        {

        }



        [HttpPost]
        public void OnPost()
        {

        }
    }
}
