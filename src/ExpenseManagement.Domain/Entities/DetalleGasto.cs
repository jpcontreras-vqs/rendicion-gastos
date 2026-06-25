using System;

namespace ExpenseManagement.Domain.Entities
{
    /// <summary>
    /// Entidad que representa un detalle de gasto dentro de una rendición
    /// </summary>
    public class DetalleGasto
    {
        public int DetalleID { get; set; }
        public int RendicionID { get; set; }
        public DateTime FechaGasto { get; set; }
        public string Concepto { get; set; }
        public string Categoria { get; set; } // Transporte, Alojamiento, Alimentación, Otros
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public string RutaComprobante { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        // Relaciones
        public virtual RendicionGasto RendicionGasto { get; set; }
    }
}
