using System.ComponentModel;

namespace BoletoBusAppSol.Web.Api.Models.Configuration
{
    public class BusModel
    {
        public int idBus { get; set; }
        [DisplayName("No. Placa")]
        public string? numeroPlaca { get; set; }
        public string? nombre { get; set; }
        public int capacidadPiso1 { get; set; }
        public int capacidadPiso2 { get; set; }
        public bool disponible { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
