//namespace CRM_App.Data.Northwind; // Razor won't recognize third level namespace
namespace CRM_App.Northwind;

public class CustomersType
{
    public string CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public AddressType Address { get; set; }
}

public class AddressType
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
}
