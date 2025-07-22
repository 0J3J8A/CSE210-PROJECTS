public class Address
{
    private string _streetAddress;
    private string _cityAddress;
    private string _stateAddress;
    private string _zippostalAddress;
    private string _countryAddress;

    public Address(string streetAddress, string city, string state, string zippostalCode, string country)
    {
        _streetAddress = streetAddress;
        _cityAddress = city;
        _stateAddress = state;
        _zippostalAddress = zippostalCode;
        _countryAddress = country;
    }

    public bool USA()
    {
        return _countryAddress.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_cityAddress}, {_stateAddress}\n {_zippostalAddress} \n{_countryAddress}";
    }
}