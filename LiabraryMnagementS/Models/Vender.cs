using System.ComponentModel.DataAnnotations;

namespace LiabraryMnagementS.Models
{
    public class Vender
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int PhonNo { get; set; }
    }
}
