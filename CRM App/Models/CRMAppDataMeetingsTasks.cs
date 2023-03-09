//namespace CRM_App.Data.CRMAppData; // Razor won't recognize third level namespace
namespace CRM_App.CRMAppData;

public class MeetingsTasksType
{
    public string MeetingDate { get; set; }
    public string MeetingTime { get; set; }
    public string Contact { get; set; }
    public string Company { get; set; }
    public string MeetingType { get; set; }
    public string Task { get; set; }
    public string TaskStatus { get; set; }
    public string DueDate { get; set; }
}
