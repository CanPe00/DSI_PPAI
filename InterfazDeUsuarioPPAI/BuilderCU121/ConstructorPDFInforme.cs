using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazDeUsuarioPPAI.BusinessLayer.BuilderCU121
{
    class ConstructorPDFInforme : IConstructorInforme
    {
        frmInformeProductos informe;
        
        void IConstructorInforme.ConstruirEncabezado(DateTime fechaDesde, DateTime fechaHasta, string titulo)
        {
            throw new NotImplementedException();
        }

        void IConstructorInforme.ConstruirCuerpo(List<string> categorias, List<int> totalCategorias, List<string> subcategorias, List<int> totalSubCategorias, List<string> productos, List<int> totalProductos)
        {
            throw new NotImplementedException();
        }

        void IConstructorInforme.ConstruirPie(string usuarioLog, DateTime fechaHoraActual)
        {
            throw new NotImplementedException();
        }

        void IConstructorInforme.ContruirProducto()
        {
            throw new NotImplementedException();
        }

        object IConstructorInforme.ConstruirProducto()
        {
            throw new NotImplementedException();
        }

        
    }
}
