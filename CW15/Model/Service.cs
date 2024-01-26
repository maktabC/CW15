using CW15.DataBase;
using System.ComponentModel.DataAnnotations;

namespace CW15.Model;

public class Service
{
    public Service()
    {
        //Id = 1;
        //if (MyMemory.Services != null) { Id = MyMemory.Services.Max(x => x.Id); }
        CreateDate = DateTime.Now;
    }
    public int Id { get; set; }

    [Display(Name = "اسم")]
    public string Name { get; set; }

    public DateTime CreateDate { get; set; }
    public List<Category> Categories { get; set; } = new List<Category>();

    [Display(Name = "موقعیت")]
    public string Location { get; set; }
}
