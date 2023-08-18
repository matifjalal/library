namespace LiabraryMnagementS.Models
{
    public class BookSales
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Books? BookID { get; set; }
        public int CustomerId { get; set; }
        public Customer? CustomersId { get; set; }
        public int  VenderId { get; set; }
        public Vender? VendersId { get; set; }
    }
}
