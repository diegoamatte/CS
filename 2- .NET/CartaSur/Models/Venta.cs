namespace CartaSur.Models
{
    public class Venta
    {
        public int ID_VENTA { get; set; }
        public DateTime Fecha_venta { get; set; }
        public string Dni_cliente { get; set; }
        public string Nombre_empleado { get; set; }
        public string Nombre_cliente { get; set; }
        public decimal Importe_total { get; set; }
        public string Direccion_envio_cliente { get; set; }
        public string Direccion_sucursal_venta { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
