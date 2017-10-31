namespace GettingStartedTutorials.CSharp.Classes
{
    public class Person : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address ShippingAddress { get; set; }

        public override string ToString() =>
            $@"{FirstName} {LastName}
        {ShippingAddress}";
    }
}