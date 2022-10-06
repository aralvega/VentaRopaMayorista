using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRopaMayorista.model
{
    class Tienda
    {
        private string nombre;
        private string direccion;
        private List<Prenda> catalogo;

        public Tienda(string nombre, string direccion, List<Prenda> catalogo)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.catalogo = catalogo;
        }

        public string ObtenerDatos()
        {
            return this.nombre + "          " + this.direccion;
        }

        public string ObtenerDatosCatalogo()
        {
            string datosCatalogo = "==============================\n";
            foreach (Prenda p in catalogo)
            {
                datosCatalogo += p.ObtenerDatos() + "==============================\n";
            }
            return datosCatalogo;
        }
    }
}
