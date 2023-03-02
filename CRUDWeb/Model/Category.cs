using System.ComponentModel.DataAnnotations;
namespace CRUDWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Display Order")]
        [Range(1,100,ErrorMessage ="Display must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
