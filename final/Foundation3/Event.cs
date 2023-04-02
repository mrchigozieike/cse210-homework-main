public abstract class Event
{
    private string title;
    private string description;
    private DateTime date;
    private Address address;

    public Event(string title, string description, DateTime date, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {date.ToShortTimeString()}\nAddress: {address.ToString()}";
    }

    public abstract string GetFullDetails();

    public virtual string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}