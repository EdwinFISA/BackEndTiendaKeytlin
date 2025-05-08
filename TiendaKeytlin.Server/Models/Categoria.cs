using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TiendaKeytlin.Server.Models;


namespace TiendaKeytlin.Server.Models
{



    public class Categoria
    {
        public Categoria()
        {
            Productos = new HashSet<Productos>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string CategoriaNombre { get; set; }

        public string Descripcion { get; set; }

        // Relación con EstadoUsuario
        public int EstadoUsuarioId { get; set; }

        public virtual EstadoUsuario EstadoUsuario { get; set; }
        public virtual ICollection<Productos> Productos { get; set; }

    }
}
