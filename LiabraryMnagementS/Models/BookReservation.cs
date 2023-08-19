using System.ComponentModel.DataAnnotations;

namespace LiabraryMnagementS.Models
{ 
    public class BookReservation
    {
        [key]
        public int Id { get; set; }
  
        public int BookId { get; set; }
        public Book? Book { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public float Cost { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int VenderId { get; set; }
        public Vender? Vender { get; set; }


    }
}
