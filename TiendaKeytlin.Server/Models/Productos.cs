using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TiendaKeytlin.Server.Models;

public class Productos
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Nombre { get; set; }

    [Required]
    [StringLength(50)]
    public string Codigo { get; set; }

    [StringLength(50)]
    public string Marca { get; set; }

    [Range(0, 999999)]
    public decimal PrecioAdquisicion { get; set; }

    [Range(0, 999999)]
    public decimal PrecioVenta { get; set; }

    [Range(0, int.MaxValue)]
    public int Stock { get; set; }

    [StringLength(500)]
    public string? Descripcion { get; set; }

    public string? Imagen { get; set; }

    // Hacer que los campos CategoriaId y ProveedorId sean nullable
    public int? CategoriaId { get; set; }

    public int? ProveedorId { get; set; }

    [JsonIgnore]
    [ForeignKey("CategoriaId")]
    public virtual Categoria? Categoria { get; set; }

    [JsonIgnore]
    [ForeignKey("ProveedorId")]
    public virtual Proveedor? Proveedor { get; set; }
}
