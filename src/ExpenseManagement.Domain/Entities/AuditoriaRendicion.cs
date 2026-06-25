using System;

namespace ExpenseManagement.Domain.Entities
{
    /// <summary>
    /// Entidad para auditoría de cambios en rendiciones de gastos
    /// </summary>
    public class AuditoriaRendicion
    {
        public int AuditoriaID { get; set; }
        public int RendicionID { get; set; }
        public int? UsuarioID { get; set; }
        public string Accion { get; set; } // Crear, Editar, Aprobar, Rechazar, etc.
        public string DetalleAnterior { get; set; }
        public string DetalleNuevo { get; set; }
        public DateTime FechaAccion { get; set; } = DateTime.UtcNow;

        // Relaciones
        public virtual RendicionGasto RendicionGasto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
