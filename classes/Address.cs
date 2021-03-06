namespace GettingStartedTutorials.CSharp.Classes
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public override string ToString() =>
            $@"{StreetAddress}
        {City}, {State}, {PostalCode}
        {Country}";
    }
}