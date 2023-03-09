namespace CRM_App.ECommerce
{
    public class MockECommerceService : IECommerceService
    {
        public Task<List<RevenueType>> GetRevenue()
        {
            return Task.FromResult<List<RevenueType>>(new());
        }
    }
}