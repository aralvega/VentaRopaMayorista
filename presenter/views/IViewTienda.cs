using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRopaMayorista.presenter.views
{
    interface IViewTienda
    {
        void VisualizarDatosTienda(string datosTienda);

        void VisualizarCatalogoPrendas(string datosPrendas);

        void VisualizarUnidadesDisponibles(string unidadesDisponibles);
    }
}
