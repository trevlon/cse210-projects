public class Customer
{
    private string _customerNames;
    private List<Address> _address = new List<Address>();

    public Customer(string customerNames)
    {
        _customerNames = customerNames;
    }

    public Customer(string customerNames, List<Address> address)
    {
        _customerNames = customerNames;
        _address = address;
    }

    public void GetCustomerName()
    {
        Console.WriteLine($"Orderd by: {_customerNames}");
    }
}