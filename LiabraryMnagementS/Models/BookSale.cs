namespace LiabraryMnagementS.Models
{
    public class BookSale
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public int  VenderId { get; set; }
        public Vender? Vender { get; set; }
    }
}
