

using System.Text.Json.Serialization;

namespace BoletoBusAppSol.Web.Api.Models.Configuration
{
    public class UpdteBusModel
    {
        public int idBus { get; set; }
        public string? numeroPlaca { get; set; }
        public string? nombre { get; set; }
        public int capacidadPiso1 { get; set; }
        public int capacidadPiso2 { get; set; }
        public bool disponible { get; set; }

        public int busId { get { return this.idBus; } }
        public int usuarioId { get; set; }
        public DateTime fechaCambio { get; set; }
    }
}
