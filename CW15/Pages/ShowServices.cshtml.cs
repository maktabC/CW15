using CW15.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace CW15.Pages
{
    public class ShowServicesModel : PageModel
    {
        [BindProperty]
        public List<Service>? Services { get; set; } = new List<Service>();

        public void OnGet()
        {
            var data = TempData["services"] as string;
            //for asp.net core 2.x ------JsonConvert.DeserializeObject<List<Entity>>(data)
            //for asp.net core 3.x
            Services = JsonSerializer.Deserialize<List<Service>>(data);
        }

        [HttpPost]
        public void OnPost()
        {

        }
    }
}
