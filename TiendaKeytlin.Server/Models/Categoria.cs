using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TiendaKeytlin.Server.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CategoriaNombre { get; set; }

        public string Descripcion { get; set; }

        // Relación con EstadoUsuario
        public int EstadoUsuarioId { get; set; }

        public virtual EstadoUsuario EstadoUsuario { get; set; }
    }
}
