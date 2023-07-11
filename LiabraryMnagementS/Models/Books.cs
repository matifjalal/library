using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;

namespace LiabraryMnagementS.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Autor { get; set; }
        public int BooksCatagoryId { get; set; }
        public BooksCatagory? BooksCatagory { get; set; }
        public float Cost { get; set; }
    }
}
