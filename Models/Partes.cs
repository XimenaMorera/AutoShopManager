namespace AutoShopManager.Models
{
    public class Partes
    {
        public int Id { get; set; } //llave primaria
        public string Nombre { get; set; }
        public int NumeroParte { get; set; }
        public int Precio { get; set; }

        public int Stock { get; set; }
        public string Proveedor { get; set; }
    }
}
