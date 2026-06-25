using System;
using System.Collections.Generic;

namespace ExpenseManagement.Domain.Entities
{
    /// <summary>
    /// Entidad que representa un usuario del sistema (rendidor)
    /// </summary>
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Email { get; set; }
        public string NombreCompleto { get; set; }
        public string Departamento { get; set; }
        public string CentroCosto { get; set; }
        public string Rol { get; set; } // Empleado, Gerente, Auditor, Admin
        public bool Estado { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaModificacion { get; set; }

        // Relaciones
        public virtual ICollection<RendicionGasto> RendicionesGastos { get; set; } = new List<RendicionGasto>();
        public virtual ICollection<FlujoAprobacion> FlujoAprobaciones { get; set; } = new List<FlujoAprobacion>();
        public virtual ICollection<AuditoriaRendicion> Auditorias { get; set; } = new List<AuditoriaRendicion>();
    }
}
