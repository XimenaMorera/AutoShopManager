using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace AutoShopManager.Models
{
    public class Reparacion
    {
        //nueva reparacion
        public int Id { get; set; } //llave primaria
        public string Descripcion { get; set; }
      
        [Column(TypeName="date")]
        public DateTime FechaInicio {  get; set; }
        public DateTime FechaFin { get; set; }
        public int CostoEstimado { get; set; }
        public int VehiculoId { get; set; }
        public Vehiculo? Vehiculo { get; set; } = default!;//propiedad de navegacion
    }
}
