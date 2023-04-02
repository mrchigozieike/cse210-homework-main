public class Address {
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string street, string city, string stateOrProvince, string country) {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public string Street { get { return street; } }
    public string City { get { return city; } }
    public string StateOrProvince { get { return stateOrProvince; } }
    public string Country { get { return country; } }

    public bool IsInUSA() {
        return country.Equals("USA");
    }

    public string GetFullAddress() {
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}
