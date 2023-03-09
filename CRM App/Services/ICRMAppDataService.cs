namespace CRM_App.CRMAppData
{
    public interface ICRMAppDataService
    {
        Task<List<MeetingsTasksType>> GetMeetingsTasks();
    }
}