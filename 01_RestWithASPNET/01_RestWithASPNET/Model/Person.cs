using _01_RestWithASPNET.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _01_RestWithASPNET.Model
{
    [Table("Person")]
    public class Person : BaseEntity
    {
        
        [Column("first_name")]
        public String FirstName { get; set; }
        
        [Column("last_name")]
        public String LastName { get; set; }
        
        [Column("address")]
        public String Address { get; set; }
        
        [Column("gender")]
        public String Gender { get; set; }

    }
}
