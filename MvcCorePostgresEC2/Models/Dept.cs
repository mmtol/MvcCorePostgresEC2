using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCorePostgresEC2.Models
{
    [Table("DEPT")]
    public class Dept
    {
        [Key]
        [Column("DEPT_NO")]
        public int IdDept { get; set; }

        [Column("DNOMBRE")]
        public string Nombre { get; set; }

        [Column("LOC")]
        public string Loc { get; set; }
    }
}
