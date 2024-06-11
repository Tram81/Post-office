namespace Project3.Models
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public bool? IsDeleted { get; set; }
    }

}
