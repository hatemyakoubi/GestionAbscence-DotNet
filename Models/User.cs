using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestionabscence.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string IdCard { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public string Role { get; set; } = "Student";

        // Navigation properties
        public virtual ICollection<Student>? Students { get; set; }
        public virtual ICollection<Professor>? Professors { get; set; }
        public virtual ICollection<Admin>? Admins { get; set; }
    }
}
