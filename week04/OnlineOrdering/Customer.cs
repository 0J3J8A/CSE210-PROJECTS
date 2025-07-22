public class Customer
{
    private string _customerName;
    private Address _fullAddress;
    public Customer(string name, Address address)
    {
        _customerName = name;
        _fullAddress = address;
    }

    public string GetName()
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        return _fullAddress;
    }

    public bool LivesUSA()
    {
        return _fullAddress.USA();
    }
}