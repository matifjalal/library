using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;

namespace LiabraryMnagementS.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        public string BookId { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

        public int StartDate { get; set; }

        public int EndDate { get; set; }

        public float  Cost { get; set; }

        public string? Autor { get; set; }
        public int BooksCatagoryId { get; set; }
        public BooksCatagory? BooksCatagory { get; set; }
        public float CustomerId { get; set; }

        public int VenderId { get; set; }

        public float  CurrencyId { get; set; }

        public float CurrancyId  { get; set; }
    }
}
