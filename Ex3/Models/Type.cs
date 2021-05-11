using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ex3.Models
{
    [Table("Type")]
    public class Type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID",TypeName ="int")]
        public int ID { get; set; }
        [Column("TypeName",TypeName ="varchar")]
        public String TypeName { get; set; }
        [StringLength(50)]
        [Column("CourseID",TypeName ="int")]
        public int Course { get; set; }

    }
}