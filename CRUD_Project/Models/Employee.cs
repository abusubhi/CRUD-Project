using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Project.Models
{

    [Table("Employees",Schema ="HR")]
    public class Employee
    {
        [Key]
        [Display(Name ="ID")]
        public int EmployeeId { get; set; }
        [Display(Name ="Name")]
        [Column(TypeName ="varchar(200)")]
        public string EmployeeName { get; set; } = string.Empty;
        [Display(Name ="Image User")]
        [Column(TypeName ="varchar(250)")]
        public string? ImageUser { get; set; }
        [Display(Name ="Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Display(Name ="Salary")]
        [Column(TypeName ="Decimal(12,2)")]
        public Decimal Salary { get; set; }
        [Display(Name ="Hiring Date")]
        [DataType (DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}")]
        public DateTime HiringDate { get; set; }
        [Required]
        [Display(Name = "Namtional ID")]
        [MaxLength(14)]
        [MinLength(14)]
        [Column(TypeName = "Varchar(14)")]
        public string NationalId { get; set; } = string.Empty;

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }

    }

}
