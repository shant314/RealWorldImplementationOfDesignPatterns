using System.Net.Mail;

namespace IteratorPattern
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public MailAddress EmailAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZipCode { get; set; }
    }
}
