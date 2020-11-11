using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDeUsuarioPPAI
{
    public partial class frmInformeProductos : Form
    {
        int indice = -1;
        public frmInformeProductos()
        {
            InitializeComponent();
        }

        private void frmInformeProductos_Load(object sender, EventArgs e)
        {

            this.reportViewerProductos.RefreshReport();
        }

        public void setEncabezado(string fechaDesde, string fechaHasta)
        {
            lblFechaDesde.Text += fechaDesde;
            lblFechaHasta.Text += fechaHasta;
        }

        public void AgregarCategoria(string categoria, string total)
        {
            grdCuerpo.Rows[indice].Cells[0].Value = categoria;
            grdCuerpo.Rows[indice].Cells[3].Value =total;
        }

        public void AgregarFila()
        {
            //PARA MI NO VA ESTE
            grdCuerpo.Rows.Add();
            indice++;
        }


        public void AgregarSubCategoria(string subcategoria, string total)
        {
            grdCuerpo.Rows[indice].Cells[1].Value = subcategoria;
            grdCuerpo.Rows[indice].Cells[3].Value = total;

        }

        
        public void AgregarProducto(string producto, string total )
        {
            grdCuerpo.Rows[indice].Cells[2].Value = producto;
            grdCuerpo.Rows[indice].Cells[3].Value = total;
        }

        public void SetPie(string usuario, string fechaHora)
        {
            this.lblUsuario.text += usuario;
            this.lblFechaHora.text += fechaHora;

        }

        private void visualizarProducto()
        {
            this.ShowDialog();
        }
    }
}
