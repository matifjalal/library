using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;

namespace LiabraryMnagementS.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public Books? BooksId { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public float  Cost { get; set; }

        public int? AutorId { get; set; }
        public Author? AuthorId { get; set; }
        public int BooksCatagoryId { get; set; }
        public BooksCatagory? BooksCatagory { get; set; }
        public int CustomerId { get; set; }
        public Customer? CustomersId { get; set; }

        public int VenderId { get; set; }
        public Vender? VendersId { get; set; }

        public float  CurrencyId { get; set; }

        public float CurrancyId  { get; set; }
    }
}
