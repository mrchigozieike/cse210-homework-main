

public class Order {
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer) {
        this.products = products;
        this.customer = customer;
    }

    public List<Product> Products { get { return products; } }
    public Customer Customer { get { return customer; } }

    public decimal TotalPrice() {
        decimal shippingCost = 0;
        if (customer.IsInUSA()) {
            shippingCost = 5;
        } else {
            shippingCost = 35;
        }

        decimal totalPrice = 0;
        foreach (Product product in products) {
            totalPrice += product.GetTotalPrice();
        }

        return totalPrice + shippingCost;
    }

    public string GetPackingLabel() {
        string packingLabel = "";
        foreach (Product product in products) {
            packingLabel += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel() {
        string shippingLabel = "";
        shippingLabel += $"Customer Name: {customer.Name}\n";
        shippingLabel += $"Customer Address:\n{customer.Address.GetFullAddress()}";
        return shippingLabel;
    }
}

