public class Address
{
    //The address contains a string for the street address, the city, state/province, and country.
    private string _streetAddress;
    private string _cityAddress;
    private string _stateAddress;
    private string _zippostalAddress; // Adding the zip code or postal code, using STRING for the case of postal code Canada
    private string _countryAddress;

    public Address(string streetAddress, string city, string state, string zippostalCode, string country)
    {
        _streetAddress = streetAddress;
        _cityAddress = city;
        _stateAddress = state;
        _zippostalAddress = zippostalCode;
        _countryAddress = country;
    }

    public bool USA() // The address should have a method that can return whether it is in the USA or not.
    {
        return _countryAddress.ToLower() == "usa";
    }

    public string GetFullAddress() // The address should have a method to return a string all of its fields together in one string 
    {
        return $"{_streetAddress}\n{_cityAddress}, {_stateAddress}\n {_zippostalAddress} \n{_countryAddress}";
    }
}