namespace LiabraryMnagementS.Models
using System.ComponentModel.DataAnnotations;
{
    public class CustomerReservation
    {
        [key]
        public int Id { get; set; }

        public string Name { get; set; }

        public float CostFees { get; set; }

        public float RestCost { get; set; }
    }
}
