<<<<<<< HEAD:Ex3/Models/Type.cs
﻿using System;
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
        [Column("ID", TypeName = "int")]
        public int ID { get; set; }
        [Column("TypeName", TypeName = "varchar")]
        public String TypeName { get; set; }
        [StringLength(50)]
        [Column("Content", TypeName = "varchar")]
        public string Content { get; set; }
        [StringLength(500)]
        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }

        public ICollection<PostUser> PostUsers { get; set; }
        public ICollection<PostAdmin> PostAdmins { get; set; }

    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex3.Models.Modelview
{
    public class Gradeview
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public bool active { get; set; }
    }
>>>>>>> main:Ex3/Models/Modelview/Gradeview.cs
}