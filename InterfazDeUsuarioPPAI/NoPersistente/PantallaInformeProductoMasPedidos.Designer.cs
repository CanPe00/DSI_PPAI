
namespace InterfazDeUsuarioPPAI.NoPersistente
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.lblInformes = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.groupBoxPeriodo = new System.Windows.Forms.GroupBox();
            this.btnSelecP = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBoxCategorias = new System.Windows.Forms.GroupBox();
            this.btnSelecCat = new System.Windows.Forms.Button();
            this.chklCategorias = new System.Windows.Forms.CheckedListBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.groupBoxSubcategorias = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnSelecSubCat = new System.Windows.Forms.Button();
            this.lblSubcategoria = new System.Windows.Forms.Label();
            this.groupBoxOrdenamiento = new System.Windows.Forms.GroupBox();
            this.btnSelecOrd = new System.Windows.Forms.Button();
            this.chkDescendente = new System.Windows.Forms.CheckBox();
            this.chkAscendente = new System.Windows.Forms.CheckBox();
            this.lblOrdenamiento = new System.Windows.Forms.Label();
            this.groupBoxVisualizacion = new System.Windows.Forms.GroupBox();
            this.btnSelecVis = new System.Windows.Forms.Button();
            this.cbkExcel = new System.Windows.Forms.CheckBox();
            this.cbkPantalla = new System.Windows.Forms.CheckBox();
            this.cbkPDF = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pctMenu = new System.Windows.Forms.PictureBox();
            this.groupBoxPeriodo.SuspendLayout();
            this.groupBoxCategorias.SuspendLayout();
            this.groupBoxSubcategorias.SuspendLayout();
            this.groupBoxOrdenamiento.SuspendLayout();
            this.groupBoxVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformes
            // 
            this.lblInformes.AutoSize = true;
            this.lblInformes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInformes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInformes.Location = new System.Drawing.Point(228, 10);
            this.lblInformes.Name = "lblInformes";
            this.lblInformes.Size = new System.Drawing.Size(550, 39);
            this.lblInformes.TabIndex = 1;
            this.lblInformes.Text = "Informe de Productos Más Pedidos";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaDesde.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.Black;
            this.lblFechaDesde.Location = new System.Drawing.Point(53, 34);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(100, 18);
            this.lblFechaDesde.TabIndex = 37;
            this.lblFechaDesde.Text = "Fecha Desde: ";
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.BackColor = System.Drawing.Color.DarkRed;
            this.btnGenerarInforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerarInforme.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnGenerarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarInforme.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarInforme.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerarInforme.Location = new System.Drawing.Point(171, 75);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(161, 39);
            this.btnGenerarInforme.TabIndex = 40;
            this.btnGenerarInforme.Text = "Generar Informe ";
            this.btnGenerarInforme.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(171, 125);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 36);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaHasta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaHasta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.ForeColor = System.Drawing.Color.Black;
            this.lblFechaHasta.Location = new System.Drawing.Point(53, 65);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(100, 18);
            this.lblFechaHasta.TabIndex = 42;
            this.lblFechaHasta.Text = "Fecha Hasta:  ";
            // 
            // groupBoxPeriodo
            // 
            this.groupBoxPeriodo.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBoxPeriodo.Controls.Add(this.btnSelecP);
            this.groupBoxPeriodo.Controls.Add(this.dtpFechaHasta);
            this.groupBoxPeriodo.Controls.Add(this.dtpFechaDesde);
            this.groupBoxPeriodo.Controls.Add(this.lblFechaDesde);
            this.groupBoxPeriodo.Controls.Add(this.lblFechaHasta);
            this.groupBoxPeriodo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPeriodo.Location = new System.Drawing.Point(461, 81);
            this.groupBoxPeriodo.Name = "groupBoxPeriodo";
            this.groupBoxPeriodo.Size = new System.Drawing.Size(351, 144);
            this.groupBoxPeriodo.TabIndex = 45;
            this.groupBoxPeriodo.TabStop = false;
            this.groupBoxPeriodo.Text = "1. PERÍODO";
            // 
            // btnSelecP
            // 
            this.btnSelecP.BackColor = System.Drawing.Color.DarkRed;
            this.btnSelecP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelecP.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnSelecP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecP.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelecP.Location = new System.Drawing.Point(225, 104);
            this.btnSelecP.Name = "btnSelecP";
            this.btnSelecP.Size = new System.Drawing.Size(102, 27);
            this.btnSelecP.TabIndex = 45;
            this.btnSelecP.Text = "Seleccionar ";
            this.btnSelecP.UseVisualStyleBackColor = false;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(174, 65);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaHasta.TabIndex = 44;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(174, 34);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaDesde.TabIndex = 43;
            // 
            // groupBoxCategorias
            // 
            this.groupBoxCategorias.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBoxCategorias.Controls.Add(this.btnSelecCat);
            this.groupBoxCategorias.Controls.Add(this.chklCategorias);
            this.groupBoxCategorias.Controls.Add(this.lblCategoria);
            this.groupBoxCategorias.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCategorias.Location = new System.Drawing.Point(38, 248);
            this.groupBoxCategorias.Name = "groupBoxCategorias";
            this.groupBoxCategorias.Size = new System.Drawing.Size(351, 255);
            this.groupBoxCategorias.TabIndex = 46;
            this.groupBoxCategorias.TabStop = false;
            this.groupBoxCategorias.Text = "2. CATEGORÍAS";
            // 
            // btnSelecCat
            // 
            this.btnSelecCat.BackColor = System.Drawing.Color.DarkRed;
            this.btnSelecCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelecCat.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnSelecCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecCat.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecCat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelecCat.Location = new System.Drawing.Point(227, 213);
            this.btnSelecCat.Name = "btnSelecCat";
            this.btnSelecCat.Size = new System.Drawing.Size(102, 27);
            this.btnSelecCat.TabIndex = 46;
            this.btnSelecCat.Text = "Seleccionar ";
            this.btnSelecCat.UseVisualStyleBackColor = false;
            // 
            // chklCategorias
            // 
            this.chklCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklCategorias.Location = new System.Drawing.Point(18, 62);
            this.chklCategorias.Name = "chklCategorias";
            this.chklCategorias.Size = new System.Drawing.Size(309, 132);
            this.chklCategorias.TabIndex = 38;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(28, 33);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(161, 18);
            this.lblCategoria.TabIndex = 37;
            this.lblCategoria.Text = "Seleccione Categorías: ";
            // 
            // groupBoxSubcategorias
            // 
            this.groupBoxSubcategorias.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBoxSubcategorias.Controls.Add(this.checkedListBox1);
            this.groupBoxSubcategorias.Controls.Add(this.btnSelecSubCat);
            this.groupBoxSubcategorias.Controls.Add(this.lblSubcategoria);
            this.groupBoxSubcategorias.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSubcategorias.Location = new System.Drawing.Point(461, 248);
            this.groupBoxSubcategorias.Name = "groupBoxSubcategorias";
            this.groupBoxSubcategorias.Size = new System.Drawing.Size(351, 255);
            this.groupBoxSubcategorias.TabIndex = 47;
            this.groupBoxSubcategorias.TabStop = false;
            this.groupBoxSubcategorias.Text = "3. SUBCATEGORÍAS";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(30, 62);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(309, 124);
            this.checkedListBox1.TabIndex = 47;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnSelecSubCat
            // 
            this.btnSelecSubCat.BackColor = System.Drawing.Color.DarkRed;
            this.btnSelecSubCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelecSubCat.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnSelecSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecSubCat.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecSubCat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelecSubCat.Location = new System.Drawing.Point(225, 213);
            this.btnSelecSubCat.Name = "btnSelecSubCat";
            this.btnSelecSubCat.Size = new System.Drawing.Size(102, 27);
            this.btnSelecSubCat.TabIndex = 46;
            this.btnSelecSubCat.Text = "Seleccionar ";
            this.btnSelecSubCat.UseVisualStyleBackColor = false;
            // 
            // lblSubcategoria
            // 
            this.lblSubcategoria.AutoSize = true;
            this.lblSubcategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubcategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubcategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubcategoria.ForeColor = System.Drawing.Color.Black;
            this.lblSubcategoria.Location = new System.Drawing.Point(30, 33);
            this.lblSubcategoria.Name = "lblSubcategoria";
            this.lblSubcategoria.Size = new System.Drawing.Size(182, 18);
            this.lblSubcategoria.TabIndex = 37;
            this.lblSubcategoria.Text = "Seleccione SubCategorías:";
            // 
            // groupBoxOrdenamiento
            // 
            this.groupBoxOrdenamiento.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBoxOrdenamiento.Controls.Add(this.btnSelecOrd);
            this.groupBoxOrdenamiento.Controls.Add(this.chkDescendente);
            this.groupBoxOrdenamiento.Controls.Add(this.chkAscendente);
            this.groupBoxOrdenamiento.Controls.Add(this.lblOrdenamiento);
            this.groupBoxOrdenamiento.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrdenamiento.Location = new System.Drawing.Point(40, 528);
            this.groupBoxOrdenamiento.Name = "groupBoxOrdenamiento";
            this.groupBoxOrdenamiento.Size = new System.Drawing.Size(349, 197);
            this.groupBoxOrdenamiento.TabIndex = 48;
            this.groupBoxOrdenamiento.TabStop = false;
            this.groupBoxOrdenamiento.Text = "4. ORDENAMIENTO";
            // 
            // btnSelecOrd
            // 
            this.btnSelecOrd.BackColor = System.Drawing.Color.DarkRed;
            this.btnSelecOrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelecOrd.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnSelecOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecOrd.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecOrd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelecOrd.Location = new System.Drawing.Point(225, 155);
            this.btnSelecOrd.Name = "btnSelecOrd";
            this.btnSelecOrd.Size = new System.Drawing.Size(102, 27);
            this.btnSelecOrd.TabIndex = 46;
            this.btnSelecOrd.Text = "Seleccionar ";
            this.btnSelecOrd.UseVisualStyleBackColor = false;
            // 
            // chkDescendente
            // 
            this.chkDescendente.AutoSize = true;
            this.chkDescendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDescendente.Location = new System.Drawing.Point(26, 109);
            this.chkDescendente.Name = "chkDescendente";
            this.chkDescendente.Size = new System.Drawing.Size(108, 20);
            this.chkDescendente.TabIndex = 39;
            this.chkDescendente.Text = "Descendente";
            this.chkDescendente.UseVisualStyleBackColor = true;
            // 
            // chkAscendente
            // 
            this.chkAscendente.AutoSize = true;
            this.chkAscendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAscendente.Location = new System.Drawing.Point(26, 80);
            this.chkAscendente.Name = "chkAscendente";
            this.chkAscendente.Size = new System.Drawing.Size(99, 20);
            this.chkAscendente.TabIndex = 38;
            this.chkAscendente.Text = "Ascendente";
            this.chkAscendente.UseVisualStyleBackColor = true;
            // 
            // lblOrdenamiento
            // 
            this.lblOrdenamiento.AutoSize = true;
            this.lblOrdenamiento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrdenamiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrdenamiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenamiento.ForeColor = System.Drawing.Color.Black;
            this.lblOrdenamiento.Location = new System.Drawing.Point(26, 42);
            this.lblOrdenamiento.Name = "lblOrdenamiento";
            this.lblOrdenamiento.Size = new System.Drawing.Size(180, 18);
            this.lblOrdenamiento.TabIndex = 37;
            this.lblOrdenamiento.Text = "Seleccione Ordenamiento:";
            // 
            // groupBoxVisualizacion
            // 
            this.groupBoxVisualizacion.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBoxVisualizacion.Controls.Add(this.btnSelecVis);
            this.groupBoxVisualizacion.Controls.Add(this.cbkExcel);
            this.groupBoxVisualizacion.Controls.Add(this.cbkPantalla);
            this.groupBoxVisualizacion.Controls.Add(this.cbkPDF);
            this.groupBoxVisualizacion.Controls.Add(this.label1);
            this.groupBoxVisualizacion.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVisualizacion.Location = new System.Drawing.Point(461, 528);
            this.groupBoxVisualizacion.Name = "groupBoxVisualizacion";
            this.groupBoxVisualizacion.Size = new System.Drawing.Size(351, 197);
            this.groupBoxVisualizacion.TabIndex = 49;
            this.groupBoxVisualizacion.TabStop = false;
            this.groupBoxVisualizacion.Text = "5. VISUALIZACION";
            // 
            // btnSelecVis
            // 
            this.btnSelecVis.BackColor = System.Drawing.Color.DarkRed;
            this.btnSelecVis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelecVis.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btnSelecVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecVis.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecVis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelecVis.Location = new System.Drawing.Point(227, 155);
            this.btnSelecVis.Name = "btnSelecVis";
            this.btnSelecVis.Size = new System.Drawing.Size(102, 27);
            this.btnSelecVis.TabIndex = 50;
            this.btnSelecVis.Text = "Seleccionar ";
            this.btnSelecVis.UseVisualStyleBackColor = false;
            // 
            // cbkExcel
            // 
            this.cbkExcel.AutoSize = true;
            this.cbkExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkExcel.Location = new System.Drawing.Point(26, 134);
            this.cbkExcel.Name = "cbkExcel";
            this.cbkExcel.Size = new System.Drawing.Size(60, 20);
            this.cbkExcel.TabIndex = 40;
            this.cbkExcel.Text = "Excel";
            this.cbkExcel.UseVisualStyleBackColor = true;
            // 
            // cbkPantalla
            // 
            this.cbkPantalla.AutoSize = true;
            this.cbkPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkPantalla.Location = new System.Drawing.Point(26, 107);
            this.cbkPantalla.Name = "cbkPantalla";
            this.cbkPantalla.Size = new System.Drawing.Size(76, 20);
            this.cbkPantalla.TabIndex = 39;
            this.cbkPantalla.Text = "Pantalla";
            this.cbkPantalla.UseVisualStyleBackColor = true;
            // 
            // cbkPDF
            // 
            this.cbkPDF.AutoSize = true;
            this.cbkPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkPDF.Location = new System.Drawing.Point(26, 80);
            this.cbkPDF.Name = "cbkPDF";
            this.cbkPDF.Size = new System.Drawing.Size(54, 20);
            this.cbkPDF.TabIndex = 38;
            this.cbkPDF.Text = "PDF";
            this.cbkPDF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Seleccione Forma de Visualización:";
            // 
            // pctMenu
            // 
            this.pctMenu.BackColor = System.Drawing.Color.Moccasin;
            this.pctMenu.Image = global::InterfazDeUsuarioPPAI.Properties.Resources.WhatsApp_Image_2020_11_10_at_20_58_52;
            this.pctMenu.Location = new System.Drawing.Point(12, 29);
            this.pctMenu.Name = "pctMenu";
            this.pctMenu.Size = new System.Drawing.Size(133, 132);
            this.pctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMenu.TabIndex = 0;
            this.pctMenu.TabStop = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(842, 745);
            this.Controls.Add(this.groupBoxVisualizacion);
            this.Controls.Add(this.groupBoxSubcategorias);
            this.Controls.Add(this.groupBoxOrdenamiento);
            this.Controls.Add(this.groupBoxCategorias);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBoxPeriodo);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.lblInformes);
            this.Controls.Add(this.pctMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Más Pedidos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.groupBoxPeriodo.ResumeLayout(false);
            this.groupBoxPeriodo.PerformLayout();
            this.groupBoxCategorias.ResumeLayout(false);
            this.groupBoxCategorias.PerformLayout();
            this.groupBoxSubcategorias.ResumeLayout(false);
            this.groupBoxSubcategorias.PerformLayout();
            this.groupBoxOrdenamiento.ResumeLayout(false);
            this.groupBoxOrdenamiento.PerformLayout();
            this.groupBoxVisualizacion.ResumeLayout(false);
            this.groupBoxVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctMenu;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblInformes;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.GroupBox groupBoxPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.GroupBox groupBoxCategorias;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.CheckedListBox chklCategorias;
        private System.Windows.Forms.GroupBox groupBoxSubcategorias;
        private System.Windows.Forms.Label lblSubcategoria;
        private System.Windows.Forms.GroupBox groupBoxOrdenamiento;
        private System.Windows.Forms.Label lblOrdenamiento;
        private System.Windows.Forms.CheckBox chkDescendente;
        private System.Windows.Forms.CheckBox chkAscendente;
        private System.Windows.Forms.GroupBox groupBoxVisualizacion;
        private System.Windows.Forms.CheckBox cbkPantalla;
        private System.Windows.Forms.CheckBox cbkPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecP;
        private System.Windows.Forms.Button btnSelecCat;
        private System.Windows.Forms.Button btnSelecSubCat;
        private System.Windows.Forms.Button btnSelecOrd;
        private System.Windows.Forms.Button btnSelecVis;
        private System.Windows.Forms.CheckBox cbkExcel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}