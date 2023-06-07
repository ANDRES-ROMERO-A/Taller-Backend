using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RomeroAlvarado.API.Models
{
    public class Usuario
    {
        public int id { get; set; }
        [Required]
        [Column(TypeName = "Varchar(10)")]
        public string NombreUsuario { get; set; }
        [Required]
        [Column(TypeName = "Varchar(10)")]
        public string clave { get; set; }
        [Required]

        public Boolean estado { get; set; }
        public Genero Genero { get; set; }

    }
}
