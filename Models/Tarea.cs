using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace listaBack.Models
{
    public class Tarea
    {
        //uso data notation
       
            public int Id { get; set; }
            [Required]
            [Column(TypeName = "varchar(100)")]
            public required string Nombre { get; set; }
            [Required]
            public bool Estado { get; set; }
        
    }
}
