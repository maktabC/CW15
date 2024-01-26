using CW15.Model;

namespace CW15.DataBase;

public static class MyMemory
{
    static MyMemory()
    {
        Category category1 = new Category() { Title = "Cname1" };
        Category category2 = new Category() { Title = "Cname2" };
        Category category3 = new Category() { Title = "Cname3" };


        Service service1 = new Service() { Id = 1, Name = "semsari", Location = "tehran", Categories = new List<Category> { category1 } };
        Service service2 = new Service() { Id = 2, Name = "mechanic", Location = "mashhad", Categories = new List<Category> { category2, category3 } };
        Service service3 = new Service() { Id = 3, Name = "lole keshi", Location = "shiraz", Categories = new List<Category> { category3 } };


        Experts.Add(new Expert { Name = "name1", City = "city1", Gender = Gender.Male, Services = new List<Service> { service1, service2 }, AvailableDays = new List<DayOfWeek> { DayOfWeek.Friday, DayOfWeek.Saturday } });
        Experts.Add(new Expert { Name = "name2", City = "city2", Gender = Gender.Female, Services = new List<Service> { service3 } });


        CategoriesList.AddRange(new List<Category> { category1, category2, category3 });

        Services.AddRange(new List<Service> { service1, service2, service3 });
    }
    public static List<Category> CategoriesList { get; set; } = new List<Category>();
    public static List<Service> Services { get; set; } = new List<Service>();
    public static List<Expert> Experts { get; set; } = new List<Expert>();
}
