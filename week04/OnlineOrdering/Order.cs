public class Order
{
    private List<Product> _productTrial = new List<Product>();
    private List<Customer> _customerTrial = new List<Customer>();
    
    // Calling the other classes inside the order class
    private Customer _customer;
    // private AddressTrial _address;
    private Product _product;

    // regular member variables
    private string _packingLabel;
    private string _shippingLabel;

    public Order(Customer customer, Product product, string packingLabel, string shippingLabel)
    {
        _customer = customer;
        _product = product;
        _packingLabel = packingLabel;
        _shippingLabel = shippingLabel;
    }

    // public Order(CustomerTrial customer, ProductTrial product)
    // {
    //     _customer = customer;
    //     _product = product;
    // }

    // public Order(string packingLabel, string shippingLabel)
    // {
    //     _packingLabel = packingLabel;
    //     _shippingLabel = shippingLabel;
    // }

    public double GetTotalCost()
    {
       return _product.GetTotalCost();
    }

    public string PackingLabel()
    {
        return _packingLabel;
    }

    public string ShippingLabel()
    {
        return _shippingLabel;
    }

    public string DisplayLabels()
    {
        return $"Packing Label: {_packingLabel} \nShipping Label: {_shippingLabel}";
    }

    public double GetShippingFee()
    {
        if(_customer.Country())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public double TotalOrderAmount()
    {
        return GetTotalCost() + GetShippingFee();
    }

    public void DisplayAll()
    {
        Console.WriteLine($"{_customer.DisplayCustomer()}");
        Console.WriteLine(DisplayLabels());
        Console.WriteLine($"{_product.DisplayProduct()}");
        Console.WriteLine($"Total Price of Product: {_product.GetTotalCost()}");
        Console.WriteLine($"Shipping Fee: {GetShippingFee()}");
        Console.WriteLine($"Full Order Price: {TotalOrderAmount()}");
    }

}