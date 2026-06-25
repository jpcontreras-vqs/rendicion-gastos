using System;

namespace ExpenseManagement.Domain.Entities
{
    /// <summary>
    /// Entidad que representa el flujo de aprobación de una rendición
    /// </summary>
    public class FlujoAprobacion
    {
        public int FlujoID { get; set; }
        public int RendicionID { get; set; }
        public int? UsuarioAprobadorID { get; set; }
        public int Nivel { get; set; } // 1: Gerente, 2: Auditor, 3: Administrador
        public string Estado { get; set; } = "Pendiente"; // Pendiente, Aprobado, Rechazado
        public string Comentarios { get; set; }
        public DateTime? FechaRevision { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        // Relaciones
        public virtual RendicionGasto RendicionGasto { get; set; }
        public virtual Usuario UsuarioAprobador { get; set; }
    }
}
