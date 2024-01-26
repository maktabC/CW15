using CW15.DataBase;
using CW15.ViewModel;
using CW15.Model;
using CW15.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using CW15.Repository;
using System.Reflection;
using System.Text.Json;

namespace CW15.Pages;

public class SearchServicecshtmlModel : PageModel
{
    Search search = new Search();


    [BindProperty]
    public ServiceViewModel ServiceDTO { get; set; } = new ServiceViewModel();
    public List<string> CategoryTitle { get; set; }=MyMemory.CategoriesList.Select(c => c.Title).ToList();
    public void OnGet()
    {

    }

    [HttpPost]
    public IActionResult OnPost()
    {
        var services = search.GetServices(ServiceDTO);
        TempData["services"] = JsonSerializer.Serialize(services);
        return RedirectToPage("ShowServices");
    }
}
