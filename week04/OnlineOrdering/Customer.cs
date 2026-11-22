using System.Net.Sockets;

public class Customer
{
    private string _customerName;

   private Address _address;

   public Customer(string customerName)
    {
        _customerName = customerName;
    }

   public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool Country()
    {
        return _address.GetCountry();
    }

    public string DisplayCustomer()
    {
        return $"Customer: {_customerName} \n{_address.DisplayAddress()}";
    }
}