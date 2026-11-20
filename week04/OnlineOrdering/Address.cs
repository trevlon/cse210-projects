public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
        _streetAddress = "";
        _city = "";
        _state = "";
        _country = "";
    }

    public Address(string streetAddress, string city, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _country = country;
    }

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public void GetLimitedAddress()
    {
        Console.WriteLine($"Country: {_country}, \nCity: {_city}, \nStreet Address: {_streetAddress}");
    }

    // public void GetCountry()
    // {
    //     Console.WriteLine($"{_country}");
    // }

    public void GetFullAddress()
    {
        Console.WriteLine($"Country: {_country}, \nCity: {_city}, \nStreet Address: {_streetAddress}, \nState: {_state}");
    }
}