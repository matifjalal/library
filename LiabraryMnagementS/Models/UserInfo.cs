using System.ComponentModel.DataAnnotations;


namespace LiabraryMnagementS.Models
{
    public class UserInfo
    {
        [Key]
        public string Name { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }

    }
}
