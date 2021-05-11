using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ex3.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID", TypeName ="int")]
        public int ID { get; set; }
        [Column("UserName",TypeName ="varchar")]
        public String UserName { get; set; }
        [StringLength(50)]
        [Column("UserPassword",TypeName ="varchar")]
        public String UserPassword { get; set; }
        [StringLength(200)]
        [Column("RegisDate",TypeName ="datetime")]
        public DateTime RegisDate { get; set; }
        [Column("Active",TypeName ="bit")]
        public bool Active { get; set; }

    }
}