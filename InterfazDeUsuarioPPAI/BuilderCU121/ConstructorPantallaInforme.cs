using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfazDeUsuarioPPAI.BusinessLayer.BuilderCU121
{
    
    class ConstructorPantallaInforme : IConstructorInforme
    {
        frmInformeProductos informe;

        public ConstructorPantallaInforme()
        {

        }

        void IConstructorInforme.ContruirProducto()
        {
            informe = new frmInformeProductos();

        }

        void IConstructorInforme.ConstruirEncabezado(DateTime fechaDesde, DateTime fechaHasta, string titulo)
        {
            informe.setEncabezado(fechaDesde.ToShortDateString(), fechaHasta.ToShortDateString());
        }
        void IConstructorInforme.ConstruirCuerpo(List<string> categorias, List<int> totalCategorias, List<string> subcategorias, List<int> totalSubCategorias, List<string> productos, List<int> totalProductos)
        {
            //VERRRR!!!!!
            for (int i = 0; i < categorias.Count; i++)
            {
                informe.AgregarFila();
                informe.AgregarCategoria(categorias[i], totalCategorias[i].ToString());
                for (int j = 0; j < subcategorias.Count; j++)

                {
                    var categoria = subcategorias[j].Split('|')[0];
                    if (categoria.Equals(categoria[i]))
                    {
                        var subcategoria= subcategorias[j].Split('|')[1];
                        informe.AgregarFila():
                        informe.AgregarSubCategoria(subcategoria, totalSubCategorias[j].ToString());
                        for (int k = 0; k < productos.Count; k++)
                        {
                            if ((productos[k].Split('|')[1].Equals(subcategoria))
                            {
                                var producto = productos[k].Split('|')[2];
                                informe.AgregarFila();
                                informe.AgregarProducto(producto, totalProductos);
                            }

                        }
                    }

                }
            }
        }

        void IConstructorInforme.ConstruirPie(string usuarioLog, DateTime fechaHoraActual)
        {
            informe.SetPie(usuarioLog, fechaHoraActual.ToString());
        }

        object IConstructorInforme.ConstruirProducto()
        {
            return informe;
        }


    }
}
