using Microsoft.EntityFrameworkCore;
using TiendaKeytlin.Server.Models;

namespace TiendaKeytlin.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<EstadoUsuario> Estados { get; set; }
        public DbSet<RolUsuario> Roles { get; set; }
        public DbSet<Permiso> Permisos { get; set; }          
        public DbSet<RolPermiso> RolPermisos { get; set; }     
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Insertar datos iniciales para Estados
            modelBuilder.Entity<EstadoUsuario>().HasData(
                new EstadoUsuario { Id = 1, Nombre = "Activo" },
                new EstadoUsuario { Id = 2, Nombre = "Inactivo" },
                new EstadoUsuario { Id = 3, Nombre = "Eliminado"}
            );

            // Insertar datos iniciales para Roles
            modelBuilder.Entity<RolUsuario>().HasData(
                new RolUsuario { Id = 1, Nombre = "Admin" },
                new RolUsuario { Id = 2, Nombre = "Vendedor" }
            );

            // Insertar datos iniciales para Permisos
            modelBuilder.Entity<Permiso>().HasData(

                // Dashboard
                new Permiso { Id = 1, Nombre = "Ver Dashboard" },
                new Permiso { Id = 2, Nombre = "Crear Dashboard" },
                new Permiso { Id = 3, Nombre = "Editar Dashboard" },
                new Permiso { Id = 4, Nombre = "Eliminar Dashboard" },

                // Apertura Caja
                new Permiso { Id = 5, Nombre = "Ver Apertura Caja" },
                new Permiso { Id = 6, Nombre = "Crear Apertura Caja" },
                new Permiso { Id = 7, Nombre = "Editar Apertura Caja" },
                new Permiso { Id = 8, Nombre = "Eliminar Apertura Caja" },

                // Cierre Caja
                new Permiso { Id = 9, Nombre = "Ver Cierre Caja" },
                new Permiso { Id = 10, Nombre = "Crear Cierre Caja" },
                new Permiso { Id = 11, Nombre = "Editar Cierre Caja" },
                new Permiso { Id = 12, Nombre = "Eliminar Cierre Caja" },

                // Productos
                new Permiso { Id = 13, Nombre = "Ver Productos" },
                new Permiso { Id = 14, Nombre = "Crear Productos" },
                new Permiso { Id = 15, Nombre = "Editar Productos" },
                new Permiso { Id = 16, Nombre = "Eliminar Productos" },

                // Categorías
                new Permiso { Id = 17, Nombre = "Ver Categorías" },
                new Permiso { Id = 18, Nombre = "Crear Categorías" },
                new Permiso { Id = 19, Nombre = "Editar Categorías" },
                new Permiso { Id = 20, Nombre = "Eliminar Categorías" },

                // Proveedores
                new Permiso { Id = 21, Nombre = "Ver Proveedores" },
                new Permiso { Id = 22, Nombre = "Crear Proveedores" },
                new Permiso { Id = 23, Nombre = "Editar Proveedores" },
                new Permiso { Id = 24, Nombre = "Eliminar Proveedores" },

                // Inventario / Stock
                new Permiso { Id = 25, Nombre = "Ver Inventario" },
                new Permiso { Id = 26, Nombre = "Crear Inventario" },
                new Permiso { Id = 27, Nombre = "Editar Inventario" },
                new Permiso { Id = 28, Nombre = "Eliminar Inventario" },

                // Pedidos
                new Permiso { Id = 29, Nombre = "Ver Pedidos" },
                new Permiso { Id = 30, Nombre = "Crear Pedidos" },
                new Permiso { Id = 31, Nombre = "Editar Pedidos" },
                new Permiso { Id = 32, Nombre = "Eliminar Pedidos" },

                // Ventas
                new Permiso { Id = 33, Nombre = "Ver Ventas" },
                new Permiso { Id = 34, Nombre = "Crear Ventas" },
                new Permiso { Id = 35, Nombre = "Editar Ventas" },
                new Permiso { Id = 36, Nombre = "Eliminar Ventas" },

                // Historial
                new Permiso { Id = 37, Nombre = "Ver Historial" },
                new Permiso { Id = 38, Nombre = "Crear Historial" },
                new Permiso { Id = 39, Nombre = "Editar Historial" },
                new Permiso { Id = 40, Nombre = "Eliminar Historial" },

                // Usuarios
                new Permiso { Id = 41, Nombre = "Ver Usuarios" },
                new Permiso { Id = 42, Nombre = "Crear Usuarios" },
                new Permiso { Id = 43, Nombre = "Editar Usuarios" },
                new Permiso { Id = 44, Nombre = "Eliminar Usuarios" },

                // Contacto
                new Permiso { Id = 45, Nombre = "Ver Contacto" },
                new Permiso { Id = 46, Nombre = "Crear Contacto" },
                new Permiso { Id = 47, Nombre = "Editar Contacto" },
                new Permiso { Id = 48, Nombre = "Eliminar Contacto" },

                // Roles
                new Permiso { Id = 49, Nombre = "Ver Roles" },
                new Permiso { Id = 50, Nombre = "Crear Roles" },
                new Permiso { Id = 51, Nombre = "Editar Roles" },
                new Permiso { Id = 52, Nombre = "Eliminar Roles" },

                // Reportes Usuarios
                new Permiso { Id = 53, Nombre = "Ver Reportes de Usuarios" },
                new Permiso { Id = 54, Nombre = "Crear Reportes de Usuarios" },
                new Permiso { Id = 55, Nombre = "Editar Reportes de Usuarios" },
                new Permiso { Id = 56, Nombre = "Eliminar Reportes de Usuarios" },

                // Reportes Ventas
                new Permiso { Id = 57, Nombre = "Ver Reportes de Ventas" },
                new Permiso { Id = 58, Nombre = "Crear Reportes de Ventas" },
                new Permiso { Id = 59, Nombre = "Editar Reportes de Ventas" },
                new Permiso { Id = 60, Nombre = "Eliminar Reportes de Ventas" },

                // Reportes Pedidos
                new Permiso { Id = 61, Nombre = "Ver Reportes de Pedidos" },
                new Permiso { Id = 62, Nombre = "Crear Reportes de Pedidos" },
                new Permiso { Id = 63, Nombre = "Editar Reportes de Pedidos" },
                new Permiso { Id = 64, Nombre = "Eliminar Reportes de Pedidos" },

                // Reportes Inventario
                new Permiso { Id = 65, Nombre = "Ver Reportes de Inventario" },
                new Permiso { Id = 66, Nombre = "Crear Reportes de Inventario" },
                new Permiso { Id = 67, Nombre = "Editar Reportes de Inventario" },
                new Permiso { Id = 68, Nombre = "Eliminar Reportes de Inventario" }

            );

            // Configurar las relaciones
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Estado)
                .WithMany(e => e.Usuarios)
                .HasForeignKey(u => u.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Rol)
                .WithMany(r => r.Usuarios)
                .HasForeignKey(u => u.RolId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configurar relación entre RolUsuario y Permiso 
            modelBuilder.Entity<RolPermiso>()
                .HasKey(rp => new { rp.RolId, rp.PermisoId });  // Establece la clave primaria compuesta

            modelBuilder.Entity<RolPermiso>()
                .HasOne(rp => rp.Rol)  // Relación con RolUsuario
                .WithMany()  // RolUsuario no tiene una colección de Permisos, ya que se maneja a través de RolPermiso
                .HasForeignKey(rp => rp.RolId);  // Clave foránea en RolPermiso para RolUsuario

            modelBuilder.Entity<RolPermiso>()
                .HasOne(rp => rp.Permiso)  // Relación con Permiso
                .WithMany()  // Permiso no tiene una colección de RolPermiso, ya que se maneja a través de RolPermiso
                .HasForeignKey(rp => rp.PermisoId);  // Clave foránea en RolPermiso para Permiso
        }
    }
}
