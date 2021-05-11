using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ex3.Models
{
    [Table("PostUser")]
    public class PostUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID",TypeName ="int")]
        public int ID { get; set; }
        [Column("TypeID",TypeName ="int")]
        public int TypeID { get; set; }
        [Column("IDUser", TypeName = "int")]
        public int IDUser { get; set; }
        [Column("Img",TypeName ="varchar")]
        public String Img { get; set; }
        [StringLength(200)]
        [Column("Subject",TypeName ="varchar")]
        public String Subject { get; set; }
        [StringLength(500)]
        [Column("Content",TypeName ="varchar")]
        public String Content { get; set; }
        [Column("Active",TypeName ="bit")]
        public bool Active { get; set; }

    }
}