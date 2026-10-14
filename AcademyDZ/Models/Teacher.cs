using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyDZ.Models
{
    public class Teacher
    {
        [Key]
        public int teacher_id { get; set; }

        [Required]
        [StringLength(50)]
        public string last_name { get; set; }

        [Required]
        [StringLength(50)]
        public string first_name { get; set; }

        [Required]
        [StringLength(50)]
        public string middle_name { get; set; }

        [Column("birth_date", TypeName = "DATE")]
        public DateOnly? birth_date { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string phone { get; set; }
        public string photo { get; set; }

        [Column("work_since", TypeName = "DATE")]
        public DateOnly? work_since { get; set; }

        [Column(TypeName = "smallmoney")]
        public int rate { get; set; }
    }
}
