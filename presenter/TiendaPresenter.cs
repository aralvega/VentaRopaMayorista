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
    class TiendaPresenter
    {
        private IViewTienda formularioCotizador;
        private Tienda tiendaModel;
        private IPrendaDAO prendaService;

        public TiendaPresenter(IViewTienda formularioCotizador)
        {
            this.formularioCotizador = formularioCotizador;
            this.prendaService = new PrendaDAOImp();

            this.prendaService.GenerarCatalogo(); // esto genera el cátalogo en la BD la primera vez

            // ahora creamos el objeto de tipo Tienda, para lo cual necesitamos extraer las prendas de la BD
            tiendaModel = new Tienda("Clothes Center", "Manuel Belgrano 888 S S de Jujuy", prendaService.ObtenerPrendas());

            // finalmente mostramos en la vista los datos de la tienda
            formularioCotizador.VisualizarDatosTienda(tiendaModel.ObtenerDatos());
        }

        public Tienda TiendaModel { get => tiendaModel; }

        public void VisualizarDatosCatalogo()
        {
            formularioCotizador.VisualizarCatalogoPrendas(tiendaModel.ObtenerDatosCatalogo());
        }

        public void VisualizarUnidadesDisponibles(bool esCamisa, bool esMangaCorta, bool esCuelloMao, bool esChupin, bool esPremium)
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

            // ahora obtenemmos las unidades disponibles
            int cantidadUnidadesDisponibles = prendaService.ObtenerUnidadesDisponibles(tipoPrenda, calidadPrenda, tipoManga, tipoCuello, tipoPantalon);

            formularioCotizador.VisualizarUnidadesDisponibles(cantidadUnidadesDisponibles.ToString());
        }
    }
}
