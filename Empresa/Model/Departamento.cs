using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empresa.Model
{
    [Table("Departamentos_PX")]
    public class Departamento
    {
        [Key]
        public int DepID { get; set; }
        public string DepNome { get; set; } = string.Empty;
    }
}
