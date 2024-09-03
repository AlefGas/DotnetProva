using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empresa.Model
{
    [Table("Empregados_PX")]
    public class Empregado
    {
        [Key]
        public int EmpId { get; set; }
        
        public string Name { get; set;}= string.Empty;
        public string Sobrenome { get; set;} = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Genero Genero { get; set; }
        public int DepID { get; set; }
        public string FotoUrl { get; set; } = string.Empty;
    }
}
