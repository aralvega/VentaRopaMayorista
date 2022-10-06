using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRopaMayorista.model;
using VentaRopaMayorista.model.util;
using VentaRopaMayorista.presenter.views;
using VentaRopaMayorista.service.dao;
using VentaRopaMayorista.service.dao.imp;

namespace VentaRopaMayorista.presenter
{
    class VendedorPresenter
    {
        private IViewVendedor formularioCotizador;
        private Vendedor vendedorModel;
        private IPrendaDAO prendaService;

        public VendedorPresenter(IViewVendedor formularioCotizador, Tienda tienda)
        {
            this.formularioCotizador = formularioCotizador;

            //creación del objeto Vendedor
            vendedorModel = new Vendedor(1111, "Ariel Alejandro", "Vega", tienda);

            formularioCotizador.VisualizarDatosVendedor(vendedorModel.ObtenerDatos());
        }

        public void RegistrarCotizacion(bool esCamisa, bool esMangaCorta, bool esCuelloMao, bool esChupin, bool esPremium, string stringCantidad, string stringPrecioUnitario)
        {
            //lo primero a realizar es traducir los valores de componentes a valores de campos en las prendas de la bd
            string tipoPrenda = "";
            string calidadPrenda = "";
            string tipoManga = "";
            string tipoCuello = "";
            string tipoPantalon = "";
            if (esCamisa == true)
            {
                tipoPrenda = NombrePrendaCte.CAMISA;
                if (esMangaCorta == true)
                {
                    tipoManga = TipoMangaCte.MANGA_CORTA;
                }
                else
                {
                    tipoManga = TipoMangaCte.MANGA_LARGA;
                }
                if (esCuelloMao == true)
                {
                    tipoCuello = TipoCuelloCte.CUELLO_MAO;
                }
                else
                {
                    tipoCuello = TipoCuelloCte.CUELLO_COMUN;
                }
            }
            else
            {
                tipoPrenda = NombrePrendaCte.PANTALON;
                if (esChupin == true)
                {
                    tipoPantalon = TipoPantalonCte.CHUPIN;
                }
                else
                {
                    tipoPantalon = TipoPantalonCte.COMUN;
                }
            }

            if (esPremium == true)
            {
                calidadPrenda = CalidadPrendaCte.PREMIUM;
            }
            else
            {
                calidadPrenda = CalidadPrendaCte.STANDARD;
            }

            if (tipoPrenda == NombrePrendaCte.CAMISA)
            {
                Camisa camisa = new Camisa(0, tipoPrenda, calidadPrenda, 0f, 0, tipoManga, tipoCuello);
            }
            else
            {
                Pantalon pantalon = new Pantalon(0, tipoPrenda, calidadPrenda, 0f, 0, tipoPantalon);
            }
            int cantidadSolicitada = int.Parse(stringCantidad);
            float precioUnitario = float.Parse(stringPrecioUnitario);
            // ahora obtenemmos la prenda cotizada
            prendaService = new PrendaDAOImp();
            Prenda prendaCotizada = prendaService.ObtenerPrenda(tipoPrenda, calidadPrenda, tipoManga, tipoCuello, tipoPantalon);
            prendaCotizada.PrecioUnitario = precioUnitario;
            //ahora generamos la cotización
            Cotizacion cotizacion = new Cotizacion(DateTime.Now, cantidadSolicitada, precioUnitario, vendedorModel.Codigo, prendaCotizada);
            //mediante este méotodo establecemos el valor total de la cotización
            cotizacion.CalcularTotalCotizacion();
            //cotizacion.PrecioPorUnidad = prendaCotizada.CalcularPrecioFinal();

            //finalmente registramos la cotización
            vendedorModel.RegistrarCotizacion(cotizacion);

            //y ahora visualizamos la cotizacion
            formularioCotizador.visualizarCotizacion(cotizacion.TotalCotizacion.ToString());
        }

        public void visualizarHistorialCotizaciones()
        {
            formularioCotizador.visualizarHistorialCotizaciones(vendedorModel.ObtenerHistorialCotizaciones());
        }
    }
}
