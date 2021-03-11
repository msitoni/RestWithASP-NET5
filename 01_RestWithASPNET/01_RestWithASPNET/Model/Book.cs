using _01_RestWithASPNET.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _01_RestWithASPNET.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {

        [Column("author")]
        public String Author  { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }

        [Column("price")]
        public Decimal Price { get; set; }

        [Column("title")]
        public String Title { get; set; }

    }
}
