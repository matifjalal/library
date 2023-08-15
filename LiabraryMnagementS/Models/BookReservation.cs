using System.ComponentModel.DataAnnotations;

namespace LiabraryMnagementS.Models
{ 
    public class BookReservation
    {
        [key]
        public int Id { get; set; }

        public string Name { get; set; }

        public float CostFees { get; set; }

        public float RestCost { get; set; }
    }
}
