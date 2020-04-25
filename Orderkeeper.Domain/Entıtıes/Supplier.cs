namespace Orderkeeper.Domain.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Fax { get; set; }
    }
}
