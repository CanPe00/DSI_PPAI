using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using InterfazDeUsuarioPPAI.BusinessLayer;

namespace InterfazDeUsuarioPPAI.BusinessLayer
{
    class Categoria
    {
        private int idCategoria;
        private string nombre;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public IList<Categoria> GetAll()
        {
            List<Categoria> listadoCategoria = new List<Categoria>();

            String strSql = string.Concat(" SELECT c.id_categoria, c.nombre ",
                                            "FROM Categoria c"); 
          

            //var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            DataManager dm = new DataManager();
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoCategoria.Add(ObjectMapping(row));
            }

            return listadoCategoria;
        }

        private Categoria ObjectMapping(DataRow row)
        {
            Categoria categoria = new Categoria
            {

                IdCategoria = Convert.ToInt32(row["id_categoria"].ToString()),
                Nombre = row["nombre"].ToString()
            };

            return categoria;

        }
        
    }
}
