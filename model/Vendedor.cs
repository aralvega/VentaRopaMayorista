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

        public int Codigo { get => codigo;}

        public Vendedor(int codigo, string nombre, string apellido, Tienda tienda)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tienda = tienda;
        }

        public string ObtenerDatos()
        {
            return this.nombre + " " + this.apellido + " | Código: " + this.codigo;
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

        public string ObtenerHistorialCotizaciones()
        {
            string stringHistorial = "";
            if (historicoCotizaciones is null || historicoCotizaciones.Count == 0)
            {
                stringHistorial = "No hay registros por mostrar";
            }
            else
            {
                stringHistorial = "=====================================\n";
                foreach (Cotizacion c in historicoCotizaciones)
                {
                    stringHistorial += c.ImprimirCotizacion() + "\n=====================================\n";
                }
            }
            return stringHistorial;

        }



    }
}
