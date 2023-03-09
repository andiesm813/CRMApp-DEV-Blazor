namespace CRM_App.Northwind
{
    public interface INorthwindService
    {
        Task<List<CustomersType>> GetCustomers();
    }
}