using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopManager.Models
{
    public class Vehiculo
    {
        public int Id { get; set; } //llave primaria
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }
        public int IdCliente { get; set; }//llave foranea
        public Cliente Cliente { get; set; } //propiedad de navegacion

        public ICollection<Reparacion> Reparaciones { get; set; }  //propiedad de navegacion
        public ICollection<Cita> Citas { get; set; }  //propiedad de navegacion

    }
}
