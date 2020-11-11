using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazDeUsuarioPPAI.BusinessLayer.BuilderCU121
{
    interface IConstructorInforme
    {
        void ConstruirEncabezado(DateTime fechaDesde, DateTime fechaHasta, string titulo);

        void ConstruirCuerpo(List<String> categorias, List<int> totalCategorias, List<String> subcategorias,
            List<int> totalSubCategorias, List<String> productos, List<int> totalProductos);

        void ConstruirPie(string usuarioLog, DateTime fechaHoraActual);

        void ContruirProducto();

        Object ConstruirProducto();
    }
}
