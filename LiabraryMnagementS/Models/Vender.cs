namespace LiabraryMnagementS.Models
{
    public class Vender
    {
        [key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int PhonNo { get; set; }
    }
}
