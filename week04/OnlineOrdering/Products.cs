public class Products
{
    private string _name;
    private int _productId;
    private double _price;

    private int _quantity;

    private int _shippingFee;

    public Products()
    {
        _name = "";
        _productId = 0;
        _price = 0;
        _quantity = 0;
    }

    public Products(string name, int productId, double price, int quantity, int shippingFee)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
        _shippingFee = shippingFee;
    }

    public string Display()
    {
        return $"Name of product: {_name}, \nProduct Id: {_productId}";
    }

    public double DisplayPrice()
    {
        return _price;
    }

    public int DisplayQuantity()
    {
        return _quantity;
    }

    public double DisplayTotalCost()
    {
        Address country = new Address();
        // double totalCost = _price * _quantity;
        // return $"Total Cost: {totalCost}";

        return (_price + _shippingFee) * _quantity;
    }

    public void ShippingFee()
    {
        Console.WriteLine($"Shipping Fee: {_shippingFee}");
    }

}