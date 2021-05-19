using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ex3.Models
{
    [Table("Exam")]
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID", TypeName = "int")]
        public int ID { get; set; }
        [Column("Nameofquestion", TypeName = "varchar")]
        public string Nameofquestion { get; set; }
        [StringLength(500)]
        [Column("AnswerA", TypeName = "varchar")]
        public string AnswerA { get; set; }
        [StringLength(100)]
        [Column("AnswerB", TypeName = "varchar")]
        public string AnswerB { get; set; }
        [StringLength(100)]
        [Column("AnswerC", TypeName = "varchar")]
        public string AnswerC { get; set; }
        [StringLength(100)]
        [Column("AnswerD", TypeName = "varchar")]
        public string AnswerD { get; set; }
        [StringLength(100)]
        [Column("Status", TypeName = "varchar")]
        public string Status { get; set; }
        [StringLength(100)]
        [Column("UserID", TypeName = "int")]
        public int UserID { get; set; }
    }
}