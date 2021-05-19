using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ex3.Models
{
    [Table("UserInfo")]
    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID",TypeName ="int")]
        public int ID { get; set; }
        [Column("UserID",TypeName ="int")]
        public int UserID { get; set; }
        [Column("FullName",TypeName ="varchar")]
        public String FullName { get; set; }
        [StringLength(100)]
        [Column("Age",TypeName ="tinyint")]
        public int Age { get; set; }
        [Column("Gender",TypeName ="varchar")]
        public String Gender { get; set; }
        [StringLength(10)]
        [Column("Email", TypeName = "varchar")]
        public String Email { get; set; }
        [StringLength(150)]
        [Column("Phone", TypeName = "varchar")]
        public String Phone { get; set; }
        [StringLength(20)]
        [Column("Address", TypeName = "varchar")]
        public String Address { get; set; }
        [StringLength(100)]
        [Column("Scores",TypeName ="int")]
        public int Scores { get; set; }
        [Column("Status",TypeName ="bit")]
        public bool Status { get; set; }

    }
}