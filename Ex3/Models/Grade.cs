using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ex3.Models
{
    [Table("Grade")]
    public class Grade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID",TypeName ="int")]
        public int ID { get; set; }
        [Column("NameGrade",TypeName ="varchar")]
        public String NameGrade { get; set; }
        [StringLength(50)]
        [Column("ContentGrade",TypeName ="varchar")]
        public String ContentGrade { get; set; }
        [Column("Active",TypeName ="bit")]
        public bool Active { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}