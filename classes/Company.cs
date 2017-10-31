public class Company : Entity
{
    public string Name { get; set; }
    public Address ShippingAddress { get; set; }

    public override string ToString() => 
        $@"{Name}
        {ShippingAddress}";
}