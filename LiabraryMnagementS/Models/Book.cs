using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;

namespace LiabraryMnagementS.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public float  Cost { get; set; }

        public int? AuthorId { get; set; }
        public Author? Author { get; set; }
        public int BooksCatagoryId { get; set; }
        public BooksCatagory? BooksCatagory { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int VenderId { get; set; }
        public Vender? Vender { get; set; }

        public int CurrancyId { get; set; }

        public Currancy? Currancy { get; set; }
    }
}
