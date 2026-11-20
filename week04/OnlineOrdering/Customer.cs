public class Customer
{
    private string _customerName;
    private List<Address> _address = new List<Address>();

    public Customer(string customerName)
    {
        _customerName = customerName;
    }

    public Customer(string customerName, List<Address> address)
    {
        _customerName = customerName;
        _address = address;
    }

    public void GetCustomerName()
    {
        Console.WriteLine($"Orderd by: {_customerName}");
    }
}