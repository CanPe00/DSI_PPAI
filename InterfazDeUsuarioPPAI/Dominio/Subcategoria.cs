using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazDeUsuarioPPAI.BusinessLayer
{
    class Subcategoria
    {
        private int idSubCategoria;
        private string nombre;

        public int IdSubCategoria { get => idSubCategoria; set => idSubCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public override string ToString()
        {
            return Nombre;
        }

        public IList<Subcategoria> GetAll()
        {
            List<Subcategoria> listadoSubcategoria = new List<Subcategoria>();

            String strSql = string.Concat(" SELECT id_subcateg, nombre ",
                                            "FROM Subcategoria"); ;


            //var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            DataManager dm = new DataManager();
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoSubcategoria.Add(ObjectMapping(row));
            }

            return listadoSubcategoria;
        }

        
        
        private Subcategoria ObjectMapping(DataRow row)
        {
            Subcategoria subcategoria = new Subcategoria
            {

                IdSubCategoria = Convert.ToInt32(row["id_subcateg"].ToString()),
                Nombre = row["nombre"].ToString()
            };
            
            return subcategoria;
        }
    }
}
