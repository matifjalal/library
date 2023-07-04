using System.ComponentModel.DataAnnotations;

namespace LiabraryMnagementS.Models
{
    public class BooksCatagory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public float Cost { get; set; }
    }
}
