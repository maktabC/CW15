using CW15.DataBase;

namespace CW15.Model;

public class Category
{
    public Category()
    {
        //Id = 1;
        //if (MyMemory.CategoriesList != null) { Id = MyMemory.CategoriesList.Max(x => x.Id); }
    }
    public int Id { get; set; }
    public string Title { get; set; }
}
