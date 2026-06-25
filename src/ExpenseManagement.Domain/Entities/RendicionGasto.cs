using System;
using System.Collections.Generic;

namespace ExpenseManagement.Domain.Entities
{
    /// <summary>
    /// Entidad que representa una solicitud de rendición de gastos
    /// </summary>
    public class RendicionGasto
    {
        public int RendicionID { get; set; }
        public int UsuarioID { get; set; }
        public string NumeroSolicitud { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
        public decimal MontoTotal { get; set; } = 0;
        public string Estado { get; set; } = "Borrador"; // Borrador, Enviada, EnAprobacion, Aprobada, Rechazada
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaModificacion { get; set; }

        // Relaciones
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<DetalleGasto> DetallesGastos { get; set; } = new List<DetalleGasto>();
        public virtual ICollection<FlujoAprobacion> FlujosAprobacion { get; set; } = new List<FlujoAprobacion>();
        public virtual ICollection<AuditoriaRendicion> Auditorias { get; set; } = new List<AuditoriaRendicion>();
    }
}
