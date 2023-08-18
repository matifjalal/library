using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;

namespace LiabraryMnagementS.Models
{
    public class Customer
    {
        [key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string FName { get; set; }

        public string Education  { get; set; }

        public string Addrass { get; set; }

        public string PhonNo { get; set; }

        public string IdNumber { get; set; }

    }
}
