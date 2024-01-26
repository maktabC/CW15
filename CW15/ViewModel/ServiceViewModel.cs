using CW15.Model;

namespace CW15.ViewModel;

public class ServiceViewModel
{
    public string? Location { get; set; }
    public string? Title { get; set; }
    public string? ServiceName { get; set; }
    public Gender? Gender { get; set; }
    public DateTime? Date { get; set; }
}