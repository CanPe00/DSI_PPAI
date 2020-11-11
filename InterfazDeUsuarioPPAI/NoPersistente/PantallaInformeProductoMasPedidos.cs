using InterfazDeUsuarioPPAI.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InterfazDeUsuarioPPAI.NoPersistente
{

    public partial class frmProductos : Form
    {
        private Categoria ocategoria;
        private Subcategoria osubcategoria;
        public frmProductos()
        {
            InitializeComponent();
            ocategoria = new Categoria();
            osubcategoria = new Subcategoria();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {              

            LlenarListas(chklCategorias, ocategoria.GetAll(), "nombre", "idCategoria");
            LlenarListas(checkedListBox1, osubcategoria.GetAll(), "nombre", "idSubCategoria");
            
        }

        private void LlenarListas(ListBox listBox, Object source, string display, String value)
        {
            listBox.DataSource = source;
            listBox.DisplayMember = display;
            listBox.ValueMember = value;
            listBox.SelectedIndex = -1;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
