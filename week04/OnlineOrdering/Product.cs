using System.Numerics;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private double _quantity;

    public Product(string name, string productId, double price, double quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string DisplayProduct()
    {
        return $"Name: {_name} \nProduct ID: {_productId} \nPrice of one: {_price} \nQuantity: {_quantity}";
    }

}

  