using System.ComponentModel.DataAnnotations.Schema;

namespace _01_RestWithASPNET.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
