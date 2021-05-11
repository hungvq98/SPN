using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ex3.Models
{
    [Table("HistoryCourse")]
    public class HistoryCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID",TypeName ="int")]
        public int ID { get; set; }
        [Column("IDUser", TypeName = "int")]
        public int IDUser { get; set; }
        [Column("IDCourse", TypeName = "int")]
        public int IDCourse { get; set; }
        [Column("Payment",TypeName ="bit")]
        public bool Payment { get; set; }
        [Column("StartTime",TypeName ="datetime")]
        public DateTime StartTime { get; set; }
        [Column("EndTime", TypeName = "datetime")]
        public DateTime EndTime { get; set; }

    }
}