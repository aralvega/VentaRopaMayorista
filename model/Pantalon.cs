using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRopaMayorista.model
{
    class Pantalon:Prenda
    {
        private string tipoPantalon;

        public Pantalon(int codigo, string nombre, string calidad, float precioUnitario, int cantidad, string tipoPantalon) : base(codigo, nombre, calidad, precioUnitario, cantidad)
        {
            this.tipoPantalon = tipoPantalon;
        }
    }
}
