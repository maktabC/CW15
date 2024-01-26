using CW15.Model;

namespace CW15.DataBase
{
    public static class MyMemory
    {
        static MyMemory()
        {
            Category category1 = new Category() { Title = "Cname1" };
            Category category2 = new Category() { Title = "Cname2" };
            Category category3 = new Category() { Title = "Cname3" };


            Service service1 = new Service() { Name = "Sname1", Location = "City1", Categories = new List<Category> { category1 } };
            Service service2 = new Service() { Name = "Sname2", Location = "City2", Categories = new List<Category> { category2, category3 } };
            Service service3 = new Service() { Name = "Sname3", Location = "City3", Categories = new List<Category> { category3 } };


            Experts.Add(new Expert { Name = "name1", City = "city1", Gender = Gender.Male, Services = new List<Service> { service1, service2 } });
            Experts.Add(new Expert { Name = "name2", City = "city2", Gender = Gender.Female, Services = new List<Service> { service3 } });


            CategoriesList.AddRange(new List<Category> { category1, category2, category3 });

            Services.AddRange(new List<Service> { service1, service2, service3 });
        }
        public static List<Category> CategoriesList { get; set; } = new List<Category>();
        public static List<Service> Services { get; set; } = new List<Service>();
        public static List<Expert> Experts { get; set; } = new List<Expert>();
    }
}
