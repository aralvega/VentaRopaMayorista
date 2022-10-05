using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRopaMayorista.model
{
    class Vendedor
    {
        private int codigo;
        private string nombre;
        private string apellido;
        private List<Cotizacion> historicoCotizaciones;
        private Tienda tienda;

        public Vendedor(int codigo, string nombre, string apellido, Tienda tienda)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tienda = tienda;
        }

        public void RegistrarCotizacion(Cotizacion cotizacion)
        {
            if (historicoCotizaciones is null)
            {
                historicoCotizaciones = new List<Cotizacion>();
            }
            cotizacion.NroIdentificacion = historicoCotizaciones.Count + 1;
            historicoCotizaciones.Add(cotizacion);
        }

    }
}
