using ExpenseManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseManagement.Domain.Interfaces
{
    /// <summary>
    /// Interfaz para el servicio de aprobaciones
    /// </summary>
    public interface IAprobacionService
    {
        Task<FlujoAprobacion> ObtenerFlujoPorIdAsync(int flujoId);
        Task<IEnumerable<FlujoAprobacion>> ObtenerFlujosPorendicionAsync(int rendicionId);
        Task<IEnumerable<FlujoAprobacion>> ObtenerFlujosParaAprobadorAsync(int usuarioAprobadorId);
        Task<bool> AprobarFlujosAsync(int flujoId, string comentarios, int usuarioAprobadorId);
        Task<bool> RechazarFlujosAsync(int flujoId, string motivoRechazo, int usuarioAprobadorId);
        Task CrearFlujosAprobacionAsync(int rendicionId);
    }
}
