public class Address
{
    private string street;
    private string city;
    private string state;

    public Address(string street, string city, string state)
    {
        this.street = street;
        this.city = city;
        this.state = state;
    }

    public override string ToString()
    {
        return $"{street}, {city}, {state}";
    }
}


