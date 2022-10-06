using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRopaMayorista.model;

namespace VentaRopaMayorista.service.dao
{
    interface IPrendaDAO
    {
        void GenerarCatalogo();

        List<Prenda> ObtenerPrendas();

        int ObtenerUnidadesDisponibles(string tipoPrenda, string calidad, string tipoManga, string tipoCuello, string tipoPantalon);

        Prenda ObtenerPrenda(string tipoPrenda, string calidad, string tipoManga, string tipoCuello, string tipoPantalon);
    }
}
