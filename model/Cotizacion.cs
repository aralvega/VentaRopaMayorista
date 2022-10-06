using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRopaMayorista.model
{
    class Cotizacion
    {
        private int nroIdentificacion;
        private DateTime fechaHora;
        private int cantUnidades;
        private float precioPorUnidad;
        private int codigoVendedor;
        private float totalCotizacion;
        private Prenda prendaCotizada;

        public Cotizacion(DateTime fechaHora, int cantUnidades, float precioPorUnidad, int codigoVendedor, Prenda prendaCotizada)
        {
            this.fechaHora = fechaHora;
            this.cantUnidades = cantUnidades;
            this.precioPorUnidad = precioPorUnidad;
            this.codigoVendedor = codigoVendedor;
            this.prendaCotizada = prendaCotizada;
        }

        public int NroIdentificacion { set => nroIdentificacion = value; }
        public float TotalCotizacion { get => totalCotizacion;}

        public void CalcularTotalCotizacion()
        {
            this.totalCotizacion = prendaCotizada.CalcularPrecioFinal() *cantUnidades;
            this.precioPorUnidad = this.prendaCotizada.PrecioUnitario; // el precio por unidad se toma del precio de la prenda, luego 
        }

        public string ImprimirCotizacion()
        {
            return "N° Identificacion: " + this.nroIdentificacion + "       Fecha: " + this.fechaHora.ToString("dd/MM/yyyy HH:mm:ss") + "\n" +
                    "Cant Unidades: " + this.cantUnidades + "       Precio cotizado por unidad: $" + this.precioPorUnidad + "\n" +
                    "Total Cotización: $" + this.totalCotizacion + "\nCódigo Vendedor: " + this.codigoVendedor + "\n" +
                    this.prendaCotizada.ObtenerDatos();
        }

    }
}
