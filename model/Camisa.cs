using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRopaMayorista.model.util;

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

        public override float CalcularPrecioFinal()
        {
            float precioFinal = 0f;

            //Aplicación regla de negocio RN1
            switch (tipoManga)
            {
                case TipoMangaCte.MANGA_LARGA:
                    {
                        precioFinal = precioUnitario;
                        break;
                    }
                case TipoMangaCte.MANGA_CORTA:
                    {
                        precioFinal = (precioUnitario - precioUnitario * 0.1f);
                        break;
                    }
            }

            //Aplicación regla de negocio RN2
            switch (tipoCuello)
            {
                case TipoCuelloCte.CUELLO_MAO:
                    {
                        precioFinal += (precioFinal * 0.03f);
                        break;
                    }
            }

            precioUnitario = precioFinal;
            // Aplicación regla de negocio N6
            precioFinal = base.CalcularPrecioFinal();

            return precioFinal;
        }

        public override string ObtenerDatos()
        {
            return base.ObtenerDatos() + "Tipo de Manga: " + tipoManga + " -- Tipo de Cuello: " + tipoCuello + "\n";
        }

    }
}
