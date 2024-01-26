using CW15.DataBase;

namespace CW15.Model
{
    public class Expert
    {
        public Expert()
        {
            //Id = 1;
            //if (MyMemory.Experts != null) { Id = MyMemory.Experts.Max(x => x.Id); }
        }
        public int? Id { get; set; }
        public string Name { get; set; }
        public List<Service> Services { get; set; } = new List<Service>();
        public string City { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
