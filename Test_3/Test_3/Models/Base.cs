using System.ComponentModel.DataAnnotations;

namespace Test_3.Models
{
    public class Base
    {
        /*
        [Key]
        public int Id { get; set; }
        */

        [Required(ErrorMessage = "CreatedDate is required")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        [Required(ErrorMessage = "IsDeleted is required")]
        public bool IsDeleted { get; set; } = false;

        public DateTime? DeletedAt { get; set; }
    }

}
