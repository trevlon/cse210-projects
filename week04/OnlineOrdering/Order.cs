
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Products> _productsInfo = new List<Products>();
    private List<Customer> _customerInfo = new List<Customer>();

    private string _packingLabels;
    private string _shippingLabels;

    public Order()
    {
        _packingLabels = "";
        _shippingLabels = "";
    }

    public Order(string packingLabels, string shippingLabels)
    {
        _packingLabels = packingLabels;
        _shippingLabels = shippingLabels;
    }
    public Order(List<Products> productsInfo, List<Customer> customerInfo, string packingLabels, string shippingLabels)
    {
        _productsInfo = productsInfo;
        _customerInfo = customerInfo;
        _packingLabels = packingLabels;
        _shippingLabels = shippingLabels;
    }

    public string PackingLabel()
    {
        return $"Packing Label: {_packingLabels}";
    }

    public string ShippingLabel()
    {
        return $"Shipping Label: {_shippingLabels}";
    }

}