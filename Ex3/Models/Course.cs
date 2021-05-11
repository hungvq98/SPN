using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ex3.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID",TypeName ="int")]
        public int ID { get; set; }
        [Column("NameCourse",TypeName ="varchar")]
        public String NameCourse { get; set; }
        [StringLength(100)]
        [Column("Price",TypeName ="float")]
        public float Price { get; set; }
        [Column("GradeID",TypeName ="int")]
        public int GradeID { get; set; }
        [Column("Size", TypeName = "int")]
        public int Size { get; set; }
        [Column("Time", TypeName = "int")]
        public int time { get; set; }
        [Column("Material",TypeName ="varchar")]
        public String Material { get; set; }
        [StringLength(200)]
        [Column("Active",TypeName ="bit")]
        public bool Active { get; set; }
    }
}