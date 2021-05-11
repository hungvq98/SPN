using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ex3.Models
{
    [Table("FeedBack")]
    public class FeedBack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID",TypeName ="int")]
        public int ID { get; set; }
        [Column("FullName",TypeName ="varchar")]
        public String FullName { get; set; }
        [StringLength(100)]
        [Column("Phone",TypeName ="varchar")]
        public string Phone { get; set; }
        [StringLength(20)]
        [Column("Email", TypeName = "varchar")]
        public string Email { get; set; }
        [StringLength(150)]
        [Column("Subject", TypeName = "varchar")]
        public string Subject { get; set; }
        [StringLength(500)]
        [Column("Message", TypeName = "varchar")]
        public string Message { get; set; }
        [Column("ReceivedDate",TypeName ="datetime")]
        public DateTime ReceivedDate { get; set; }
        [Column("Status",TypeName ="bit")]
        public bool Status { get; set; }
    }
}