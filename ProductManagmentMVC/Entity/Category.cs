using System.ComponentModel.DataAnnotations;

namespace ProductManagmentMVC.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength (50)]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
