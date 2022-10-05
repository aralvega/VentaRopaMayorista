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
        private string prendaCotizada;

        public Cotizacion(DateTime fechaHora, int cantUnidades, float precioPorUnidad, int codigoVendedor, string prendaCotizada)
        {
            this.fechaHora = fechaHora;
            this.cantUnidades = cantUnidades;
            this.precioPorUnidad = precioPorUnidad;
            this.codigoVendedor = codigoVendedor;
            this.prendaCotizada = prendaCotizada;
        }

        public int NroIdentificacion { set => nroIdentificacion = value; }
        
        public void CalcularTotalCotizacion(float precioPrenda)
        {
            this.totalCotizacion = precioPrenda * this.cantUnidades;
        }

    }
}
