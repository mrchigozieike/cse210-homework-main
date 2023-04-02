public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, Address address, string rsvpEmail)
        : base(title, description, date, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}

