using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;

namespace LiabraryMnagementS.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string  Name { get; set; }

        public int Price { get; set; }
        public int? AuthorId { get; set; }
        public Author? Author { get; set; }
        public int BooksCatagoryId { get; set; }
        public BooksCatagory? BooksCatagory { get; set; }
        public string? IsReserved { get; set; }
        public string? IsSold { get; set; }

        public int Currency { get; set; }
        public Currency? Currency { get; set; }

    }
}
