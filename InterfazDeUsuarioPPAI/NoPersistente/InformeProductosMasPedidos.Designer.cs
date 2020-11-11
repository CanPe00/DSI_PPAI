
namespace InterfazDeUsuarioPPAI
{
    partial class frmInformeProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformeProductos));
            this.groupBoxPeriodo = new System.Windows.Forms.GroupBox();
            this.txtFechaHasta = new System.Windows.Forms.TextBox();
            this.txtFechaDesde = new System.Windows.Forms.TextBox();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.reportViewerProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBoxPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPeriodo
            // 
            this.groupBoxPeriodo.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBoxPeriodo.Controls.Add(this.txtFechaHasta);
            this.groupBoxPeriodo.Controls.Add(this.txtFechaDesde);
            this.groupBoxPeriodo.Controls.Add(this.lblFechaDesde);
            this.groupBoxPeriodo.Controls.Add(this.lblFechaHasta);
            this.groupBoxPeriodo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPeriodo.Location = new System.Drawing.Point(39, 9);
            this.groupBoxPeriodo.Name = "groupBoxPeriodo";
            this.groupBoxPeriodo.Size = new System.Drawing.Size(753, 67);
            this.groupBoxPeriodo.TabIndex = 46;
            this.groupBoxPeriodo.TabStop = false;
            this.groupBoxPeriodo.Text = "PERÍODO";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(557, 27);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(100, 25);
            this.txtFechaHasta.TabIndex = 46;
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(234, 26);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(100, 25);
            this.txtFechaDesde.TabIndex = 45;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaDesde.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.Black;
            this.lblFechaDesde.Location = new System.Drawing.Point(127, 27);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(100, 18);
            this.lblFechaDesde.TabIndex = 37;
            this.lblFechaDesde.Text = "Fecha Desde: ";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaHasta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaHasta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.ForeColor = System.Drawing.Color.Black;
            this.lblFechaHasta.Location = new System.Drawing.Point(451, 27);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(100, 18);
            this.lblFechaHasta.TabIndex = 42;
            this.lblFechaHasta.Text = "Fecha Hasta:  ";
            // 
            // reportViewerProductos
            // 
            this.reportViewerProductos.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.reportViewerProductos.LocalReport.ReportEmbeddedResource = "InterfazDeUsuarioPPAI.ReporteProductosMasPedidos.rdlc";
            this.reportViewerProductos.Location = new System.Drawing.Point(13, 85);
            this.reportViewerProductos.Name = "reportViewerProductos";
            this.reportViewerProductos.ServerReport.BearerToken = null;
            this.reportViewerProductos.Size = new System.Drawing.Size(820, 497);
            this.reportViewerProductos.TabIndex = 0;
            // 
            // frmInformeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(845, 600);
            this.Controls.Add(this.groupBoxPeriodo);
            this.Controls.Add(this.reportViewerProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInformeProductos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe Productos Más Pedidos";
            this.Load += new System.EventHandler(this.frmInformeProductos_Load);
            this.groupBoxPeriodo.ResumeLayout(false);
            this.groupBoxPeriodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxPeriodo;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.TextBox txtFechaDesde;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProductos;
        private System.Windows.Forms.TextBox txtFechaHasta;
    }
}