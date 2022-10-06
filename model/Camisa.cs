using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRopaMayorista.model
{
    class Camisa:Prenda
    {
        private string tipoManga;
        private string tipoCuello;

        public Camisa(int codigo, string nombre, string calidad, float precioUnitario, int cantidad, string tipoManga, string tipoCuello) : base(codigo, nombre, calidad, precioUnitario, cantidad)
        {
            this.tipoManga = tipoManga;
            this.tipoCuello = tipoCuello;
        }
    }
}
