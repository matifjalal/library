using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace LiabraryMnagementS.Models
{
    public class Customer
    {
        [key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Addrass { get; set; }

        public int PhonNo { get; set; }

        public int WhatsappNo { get; set; }

        public string BookName { get; set; }

        public float Cost { get; set; }

        public  float SalsePrice { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
