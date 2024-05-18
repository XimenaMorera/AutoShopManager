using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopManager.Models
{
    public class Cita
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Descripcion { get; set; }

        public int ClienteId { get; set; } = default!; //FK

        public int VehiculoId { get; set; } = default!; //FK

        public Cliente? Cliente { get; set; } = default!;//propiedad de navegacion
        public Vehiculo? Vehiculo { get; set; } = default!;//propiedad de navegacion

    }
}
