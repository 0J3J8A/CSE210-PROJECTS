public class Product
{
    private string _productName;
    private string _productId;
    private double _productPrice;
    private int _productQuantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _productName = name;
        _productId = productId;
        _productPrice = price;
        _productQuantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double TotalCost()
    {
        return _productPrice * _productQuantity;
    }
}