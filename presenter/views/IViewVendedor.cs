using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRopaMayorista.presenter.views
{
    interface IViewVendedor
    {
        void VisualizarDatosVendedor(string datosVendedor);
        void visualizarCotizacion(string valorCotizacion);
        void visualizarHistorialCotizaciones(string historialCotizaciones);
    }
}
