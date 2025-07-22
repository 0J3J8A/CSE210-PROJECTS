public class Customer
{
    // The customer contains a name and an address.
    private string _customerName; // string
    private Address _fullAddress; // linked to Address class
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

    public bool LivesUSA() //The customer should have a method that can return whether they live in the USA or not. 
    {
        return _fullAddress.USA();
    }
}