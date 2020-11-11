using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using InterfazDeUsuarioPPAI.BusinessLayer.BuilderCU121;

namespace InterfazDeUsuarioPPAI.BusinessLayer
{
    class DirectorConstruccionInformeProductosMasPedidos
    {
        private IConstructorInforme _constructor;

        public DirectorConstruccionInformeProductosMasPedidos(IConstructorInforme constructor)
        {
            this._constructor = constructor;
        }

        public void Contruir(DateTime fechaDesde, DateTime fechaHasta, string titulo, List<String> categorias, List<int> totalCategorias, List<String> subcategorias,
            List<int> totalSubCategorias, List<String> productos, List<int> totalProductos, string usuarioLog, DateTime fechaHoraActual)
        {
            this._constructor.ContruirProducto();
            this._constructor.ConstruirEncabezado(fechaDesde, fechaHasta,titulo);
            this._constructor.ConstruirCuerpo(categorias, totalCategorias, subcategorias, totalSubCategorias, productos, totalProductos);
            this._constructor.ConstruirPie(usuarioLog, fechaHoraActual);
        }
    }
}
