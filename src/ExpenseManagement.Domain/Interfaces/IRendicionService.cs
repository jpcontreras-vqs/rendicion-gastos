using ExpenseManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseManagement.Domain.Interfaces
{
    /// <summary>
    /// Interfaz para el servicio de rendiciones de gastos
    /// </summary>
    public interface IRendicionService
    {
        Task<RendicionGasto> CrearRendicionAsync(RendicionGasto rendicion);
        Task<RendicionGasto> ObtenerRendicionAsync(int id);
        Task<IEnumerable<RendicionGasto>> ObtenerRendicionesPorusuarioAsync(int usuarioId);
        Task<bool> ActualizarRendicionAsync(RendicionGasto rendicion);
        Task<bool> EnviarAprobacionAsync(int rendicionId);
        Task<bool> EliminarRendicionAsync(int rendicionId);
        Task<decimal> CalcularMontoTotalAsync(int rendicionId);
    }
}
