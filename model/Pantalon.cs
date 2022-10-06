using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRopaMayorista.model.util;

namespace VentaRopaMayorista.model
{
    class Pantalon:Prenda
    {
        private string tipoPantalon;

        public Pantalon(int codigo, string nombre, string calidad, float precioUnitario, int cantidad, string tipoPantalon) : base(codigo, nombre, calidad, precioUnitario, cantidad)
        {
            this.tipoPantalon = tipoPantalon;
        }

        public override float CalcularPrecioFinal()
        {
            float precioFinal = 0f;

            //Aplicación regla de negocio RN4
            switch (tipoPantalon)
            {
                case TipoPantalonCte.COMUN:
                    {
                        precioFinal = this.precioUnitario;
                        break;
                    }
                case TipoPantalonCte.CHUPIN:
                    {
                        precioFinal = (precioUnitario - precioUnitario * 0.12f);
                        break;
                    }
            }

            this.precioUnitario = precioFinal;

            // Aplicación regla de negocio N6
            precioFinal = base.CalcularPrecioFinal();

            return precioFinal;
        }

    }
}
