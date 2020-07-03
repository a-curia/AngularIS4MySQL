using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularIS4MySQL.Models
{
    public class Grabagereq
    {
        [Key]
        public int id { get; set; }

        //[Column("full_name", Order = 2, TypeName = "nvarchar(100)"]
        [Column(TypeName = "nvarchar(100)")]
        public string fullName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }

        [Column(TypeName = "nvarchar(13)")]
        public string phone { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string address { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string message { get; set; }
    }
}
