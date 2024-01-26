using CW15.Model;

namespace CW15.DTO
{
    public record ServiceDTO
    {
        public string Location { get; set; }
        public  List<Category> categires { get; set; }
        public string ServiceName { get; set; }
        public Gender Gender { get; set; }

    }
}
