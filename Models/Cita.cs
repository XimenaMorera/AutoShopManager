using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopManager.Models
{
    public class Cita
    {
        //Ensayando para los commits
        public int Id { get; set; }
        public int IdVehiculo { get; set; }
        public int IdCliente { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        public string Hora { get; set; }
        public string Descripcion { get; set; }
        public Cliente Cliente { get; set; } //propiedad de navegacion
        
    }
}
