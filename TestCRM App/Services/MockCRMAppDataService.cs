namespace CRM_App.CRMAppData
{
    public class MockCRMAppDataService : ICRMAppDataService
    {
        public Task<List<MeetingsTasksType>> GetMeetingsTasks()
        {
            return Task.FromResult<List<MeetingsTasksType>>(new());
        }
    }
}