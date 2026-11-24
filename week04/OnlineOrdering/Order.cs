public class Order
{
    private List<Product> _productList = new List<Product>();
    private List<Customer> _customerList = new List<Customer>();
    
    // Calling the other classes inside the order class
    private Customer _customer;
    // private AddressTrial _address;
    // private Product _product;

    // regular member variables
    private string _packingLabel;
    private string _shippingLabel;

    public Order(Customer customer, List<Product> productList, string packingLabel, string shippingLabel)
    {
        _customer = customer;
        _productList = productList;
        _packingLabel = packingLabel;
        _shippingLabel = shippingLabel;
    }

    public Order(Customer customer, List<Product> productList)
    {
        _customer = customer;
        _productList = productList;
    }

    public Order(string packingLabel, string shippingLabel)
    {
        _packingLabel = packingLabel;
        _shippingLabel = shippingLabel;
    }

    // public void AddProduct(Product productList)
    // {
    //     _productList.Add(productList);
    // }

    public double GetTotalCost()
    {
       double total = 0;
       foreach(Product product in _productList)
        {
            total += product.GetTotalCost();
        }
         return total;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach(Product product in _productList)
        {
            label += product.DisplayProductLimited() + "\n";
        }
        return $"Packing Label: \n{label}";
    }

    public string ShippingLabel()
    {
        string label2 = "";
        label2 += _customer.DisplayCustomer() + "\n";
        return $"Shipping Label: \n{label2}";
    }

    public string DisplayLabels()
    {
        return $"{_packingLabel} \n{_shippingLabel}";
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
        // Console.WriteLine(DisplayLabels());

        foreach(Product products in _productList)
        {
        Console.WriteLine($"{products.DisplayProduct()}");
        }
        Console.WriteLine($"Total Price of Product: {GetTotalCost()}");
        Console.WriteLine($"Shipping Fee: {GetShippingFee()}");
        Console.WriteLine($"Full Order Price: {TotalOrderAmount()}");
    }

}