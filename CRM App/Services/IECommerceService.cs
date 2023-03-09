namespace CRM_App.ECommerce
{
    public interface IECommerceService
    {
        Task<List<RevenueType>> GetRevenue();
    }
}