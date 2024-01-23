using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Project.Models
{

    [Table("Departments",Schema ="HR")]
    public class Department
    {
        [Key]
        [Display(Name ="Id")]
        public int DepartmentId { get; set; }


        [Required]
        [Display(Name = "DepartmentName")]
        [Column(TypeName = "varchar(200)")]
        public string DepartmentName { get; set; } = string.Empty;
    }
}
