namespace AutoShopManager.Models
{
    public class Cliente
    {
        public int Id { get; set; } //llave primaria
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string? Direccion { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; }  //propiedad de navegacion
        public ICollection<Cita> Citas { get; set; }  //propiedad de navegacion
    }
}
