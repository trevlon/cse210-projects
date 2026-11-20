
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Products> _productsInfo = new List<Products>();
    private List<Customer> _customerInfo = new List<Customer>();

    private string _packingLabel;
    private string _shippingLabel;

    public Order()
    {
        _packingLabel = "";
        _shippingLabel = "";
    }

    public Order(string packingLabel, string shippingLabel)
    {
        _packingLabel = packingLabel;
        _shippingLabel = shippingLabel;
    }
    public Order(List<Products> productsInfo, List<Customer> customerInfo, string packingLabel, string shippingLabel)
    {
        _productsInfo = productsInfo;
        _customerInfo = customerInfo;
        _packingLabel = packingLabel;
        _shippingLabel = shippingLabel;
    }

    public string PackingLabel()
    {
        return $"Packing Label: {_packingLabel}";
    }

    public string ShippingLabel()
    {
        return $"Shipping Label: {_shippingLabel}";
    }

}