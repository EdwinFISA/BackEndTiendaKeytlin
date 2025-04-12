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

                    // Caja
                    new Permiso { Id = 5, Nombre = "Ver Caja" },
                    new Permiso { Id = 6, Nombre = "Crear Caja" },
                    new Permiso { Id = 7, Nombre = "Editar Caja" },
                    new Permiso { Id = 8, Nombre = "Eliminar Caja" },

                    // Artículos
                    new Permiso { Id = 9, Nombre = "Ver Artículos" },
                    new Permiso { Id = 10, Nombre = "Crear Artículos" },
                    new Permiso { Id = 11, Nombre = "Editar Artículos" },
                    new Permiso { Id = 12, Nombre = "Eliminar Artículos" },

                    // Inventario
                    new Permiso { Id = 13, Nombre = "Ver Inventario" },
                    new Permiso { Id = 14, Nombre = "Crear Inventario" },
                    new Permiso { Id = 15, Nombre = "Editar Inventario" },
                    new Permiso { Id = 16, Nombre = "Eliminar Inventario" },

                    // Ventas
                    new Permiso { Id = 17, Nombre = "Ver Ventas" },
                    new Permiso { Id = 18, Nombre = "Crear Ventas" },
                    new Permiso { Id = 19, Nombre = "Editar Ventas" },
                    new Permiso { Id = 20, Nombre = "Eliminar Ventas" },

                    // Administración
                    new Permiso { Id = 21, Nombre = "Ver Administración" },
                    new Permiso { Id = 22, Nombre = "Crear Administración" },
                    new Permiso { Id = 23, Nombre = "Editar Administración" },
                    new Permiso { Id = 24, Nombre = "Eliminar Administración" },

                    // Reportes
                    new Permiso { Id = 25, Nombre = "Ver Reportes" },
                    new Permiso { Id = 26, Nombre = "Crear Reportes" },
                    new Permiso { Id = 27, Nombre = "Editar Reportes" },
                    new Permiso { Id = 28, Nombre = "Eliminar Reportes" }
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
