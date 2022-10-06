
namespace VentaRopaMayorista
{
    partial class CotizadorRopa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDatosTienda = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.btnListadoPrendas = new System.Windows.Forms.Button();
            this.pnlDatosVendedor = new System.Windows.Forms.Panel();
            this.lblDatosVendedor = new System.Windows.Forms.Label();
            this.grpPrenda = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkChupin = new System.Windows.Forms.CheckBox();
            this.chkCuelloMao = new System.Windows.Forms.CheckBox();
            this.chkMangaCorta = new System.Windows.Forms.CheckBox();
            this.rdioPantalon = new System.Windows.Forms.RadioButton();
            this.rdioCamisa = new System.Windows.Forms.RadioButton();
            this.pnlUnidadesDisponibles = new System.Windows.Forms.Panel();
            this.lblCampoUnidades = new System.Windows.Forms.Label();
            this.lblUnidadesDisponibles = new System.Windows.Forms.Label();
            this.grpCalidad = new System.Windows.Forms.GroupBox();
            this.rdioPremium = new System.Windows.Forms.RadioButton();
            this.rdioStandard = new System.Windows.Forms.RadioButton();
            this.grpPrecioCantidad = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPesos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCotizacionFinal = new System.Windows.Forms.Label();
            this.lblHistorialCotizaciones = new System.Windows.Forms.LinkLabel();
            this.pnlDatosVendedor.SuspendLayout();
            this.grpPrenda.SuspendLayout();
            this.pnlUnidadesDisponibles.SuspendLayout();
            this.grpCalidad.SuspendLayout();
            this.grpPrecioCantidad.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.BlueViolet;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(1, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(431, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cotizador Express";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatosTienda
            // 
            this.lblDatosTienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDatosTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosTienda.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblDatosTienda.Location = new System.Drawing.Point(-2, 50);
            this.lblDatosTienda.Name = "lblDatosTienda";
            this.lblDatosTienda.Size = new System.Drawing.Size(434, 39);
            this.lblDatosTienda.TabIndex = 1;
            this.lblDatosTienda.Text = "Datos de la Tienda";
            this.lblDatosTienda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.Blue;
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.Color.White;
            this.btnCotizar.Location = new System.Drawing.Point(28, 13);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(136, 46);
            this.btnCotizar.TabIndex = 2;
            this.btnCotizar.Text = "COTIZAR";
            this.btnCotizar.UseVisualStyleBackColor = false;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // btnListadoPrendas
            // 
            this.btnListadoPrendas.BackColor = System.Drawing.Color.MediumPurple;
            this.btnListadoPrendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoPrendas.ForeColor = System.Drawing.Color.White;
            this.btnListadoPrendas.Location = new System.Drawing.Point(156, 92);
            this.btnListadoPrendas.Name = "btnListadoPrendas";
            this.btnListadoPrendas.Size = new System.Drawing.Size(118, 23);
            this.btnListadoPrendas.TabIndex = 3;
            this.btnListadoPrendas.Text = "Listado de Prendas";
            this.btnListadoPrendas.UseVisualStyleBackColor = false;
            this.btnListadoPrendas.Click += new System.EventHandler(this.btnListadoPrendas_Click);
            // 
            // pnlDatosVendedor
            // 
            this.pnlDatosVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosVendedor.Controls.Add(this.lblHistorialCotizaciones);
            this.pnlDatosVendedor.Controls.Add(this.lblDatosVendedor);
            this.pnlDatosVendedor.Location = new System.Drawing.Point(-2, 121);
            this.pnlDatosVendedor.Name = "pnlDatosVendedor";
            this.pnlDatosVendedor.Size = new System.Drawing.Size(434, 44);
            this.pnlDatosVendedor.TabIndex = 4;
            // 
            // lblDatosVendedor
            // 
            this.lblDatosVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDatosVendedor.Location = new System.Drawing.Point(10, 9);
            this.lblDatosVendedor.Name = "lblDatosVendedor";
            this.lblDatosVendedor.Size = new System.Drawing.Size(265, 23);
            this.lblDatosVendedor.TabIndex = 0;
            this.lblDatosVendedor.Text = "Datos Vendedor";
            this.lblDatosVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpPrenda
            // 
            this.grpPrenda.Controls.Add(this.panel1);
            this.grpPrenda.Controls.Add(this.chkChupin);
            this.grpPrenda.Controls.Add(this.chkCuelloMao);
            this.grpPrenda.Controls.Add(this.chkMangaCorta);
            this.grpPrenda.Controls.Add(this.rdioPantalon);
            this.grpPrenda.Controls.Add(this.rdioCamisa);
            this.grpPrenda.Location = new System.Drawing.Point(27, 180);
            this.grpPrenda.Name = "grpPrenda";
            this.grpPrenda.Size = new System.Drawing.Size(376, 100);
            this.grpPrenda.TabIndex = 5;
            this.grpPrenda.TabStop = false;
            this.grpPrenda.Text = "Prenda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(26, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 10);
            this.panel1.TabIndex = 6;
            // 
            // chkChupin
            // 
            this.chkChupin.AutoSize = true;
            this.chkChupin.Enabled = false;
            this.chkChupin.Location = new System.Drawing.Point(159, 65);
            this.chkChupin.Name = "chkChupin";
            this.chkChupin.Size = new System.Drawing.Size(59, 17);
            this.chkChupin.TabIndex = 5;
            this.chkChupin.Text = "Chupin";
            this.chkChupin.UseVisualStyleBackColor = true;
            this.chkChupin.CheckedChanged += new System.EventHandler(this.chkChupin_CheckedChanged);
            // 
            // chkCuelloMao
            // 
            this.chkCuelloMao.AutoSize = true;
            this.chkCuelloMao.Location = new System.Drawing.Point(270, 30);
            this.chkCuelloMao.Name = "chkCuelloMao";
            this.chkCuelloMao.Size = new System.Drawing.Size(79, 17);
            this.chkCuelloMao.TabIndex = 3;
            this.chkCuelloMao.Text = "Cuello Mao";
            this.chkCuelloMao.UseVisualStyleBackColor = true;
            this.chkCuelloMao.CheckedChanged += new System.EventHandler(this.chkCuelloMao_CheckedChanged);
            // 
            // chkMangaCorta
            // 
            this.chkMangaCorta.AutoSize = true;
            this.chkMangaCorta.Location = new System.Drawing.Point(159, 30);
            this.chkMangaCorta.Name = "chkMangaCorta";
            this.chkMangaCorta.Size = new System.Drawing.Size(87, 17);
            this.chkMangaCorta.TabIndex = 2;
            this.chkMangaCorta.Text = "Manga Corta";
            this.chkMangaCorta.UseVisualStyleBackColor = true;
            this.chkMangaCorta.CheckedChanged += new System.EventHandler(this.chkMangaCorta_CheckedChanged);
            // 
            // rdioPantalon
            // 
            this.rdioPantalon.AutoSize = true;
            this.rdioPantalon.Location = new System.Drawing.Point(26, 65);
            this.rdioPantalon.Name = "rdioPantalon";
            this.rdioPantalon.Size = new System.Drawing.Size(67, 17);
            this.rdioPantalon.TabIndex = 4;
            this.rdioPantalon.Text = "Pantalón";
            this.rdioPantalon.UseVisualStyleBackColor = true;
            this.rdioPantalon.CheckedChanged += new System.EventHandler(this.rdioPantalon_CheckedChanged);
            // 
            // rdioCamisa
            // 
            this.rdioCamisa.AutoSize = true;
            this.rdioCamisa.Checked = true;
            this.rdioCamisa.Location = new System.Drawing.Point(26, 30);
            this.rdioCamisa.Name = "rdioCamisa";
            this.rdioCamisa.Size = new System.Drawing.Size(59, 17);
            this.rdioCamisa.TabIndex = 1;
            this.rdioCamisa.TabStop = true;
            this.rdioCamisa.Text = "Camisa";
            this.rdioCamisa.UseVisualStyleBackColor = true;
            this.rdioCamisa.CheckedChanged += new System.EventHandler(this.rdioCamisa_CheckedChanged);
            // 
            // pnlUnidadesDisponibles
            // 
            this.pnlUnidadesDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUnidadesDisponibles.Controls.Add(this.lblCampoUnidades);
            this.pnlUnidadesDisponibles.Controls.Add(this.lblUnidadesDisponibles);
            this.pnlUnidadesDisponibles.Location = new System.Drawing.Point(27, 286);
            this.pnlUnidadesDisponibles.Name = "pnlUnidadesDisponibles";
            this.pnlUnidadesDisponibles.Size = new System.Drawing.Size(376, 40);
            this.pnlUnidadesDisponibles.TabIndex = 6;
            // 
            // lblCampoUnidades
            // 
            this.lblCampoUnidades.AutoSize = true;
            this.lblCampoUnidades.Location = new System.Drawing.Point(13, 13);
            this.lblCampoUnidades.Name = "lblCampoUnidades";
            this.lblCampoUnidades.Size = new System.Drawing.Size(157, 13);
            this.lblCampoUnidades.TabIndex = 8;
            this.lblCampoUnidades.Text = "Unidades de stock disponibles: ";
            // 
            // lblUnidadesDisponibles
            // 
            this.lblUnidadesDisponibles.AutoSize = true;
            this.lblUnidadesDisponibles.Location = new System.Drawing.Point(172, 13);
            this.lblUnidadesDisponibles.Name = "lblUnidadesDisponibles";
            this.lblUnidadesDisponibles.Size = new System.Drawing.Size(37, 13);
            this.lblUnidadesDisponibles.TabIndex = 7;
            this.lblUnidadesDisponibles.Text = "_____";
            // 
            // grpCalidad
            // 
            this.grpCalidad.Controls.Add(this.rdioPremium);
            this.grpCalidad.Controls.Add(this.rdioStandard);
            this.grpCalidad.Location = new System.Drawing.Point(27, 338);
            this.grpCalidad.Name = "grpCalidad";
            this.grpCalidad.Size = new System.Drawing.Size(161, 52);
            this.grpCalidad.TabIndex = 7;
            this.grpCalidad.TabStop = false;
            this.grpCalidad.Text = "Calidad de Prenda";
            // 
            // rdioPremium
            // 
            this.rdioPremium.AutoSize = true;
            this.rdioPremium.Location = new System.Drawing.Point(96, 19);
            this.rdioPremium.Name = "rdioPremium";
            this.rdioPremium.Size = new System.Drawing.Size(65, 17);
            this.rdioPremium.TabIndex = 9;
            this.rdioPremium.Text = "Premium";
            this.rdioPremium.UseVisualStyleBackColor = true;
            this.rdioPremium.CheckedChanged += new System.EventHandler(this.rdioPremium_CheckedChanged);
            // 
            // rdioStandard
            // 
            this.rdioStandard.AutoSize = true;
            this.rdioStandard.Checked = true;
            this.rdioStandard.Location = new System.Drawing.Point(17, 19);
            this.rdioStandard.Name = "rdioStandard";
            this.rdioStandard.Size = new System.Drawing.Size(68, 17);
            this.rdioStandard.TabIndex = 8;
            this.rdioStandard.TabStop = true;
            this.rdioStandard.Text = "Standard";
            this.rdioStandard.UseVisualStyleBackColor = true;
            this.rdioStandard.CheckedChanged += new System.EventHandler(this.rdioStandard_CheckedChanged);
            // 
            // grpPrecioCantidad
            // 
            this.grpPrecioCantidad.Controls.Add(this.txtCantidad);
            this.grpPrecioCantidad.Controls.Add(this.lblCantidad);
            this.grpPrecioCantidad.Controls.Add(this.txtPrecio);
            this.grpPrecioCantidad.Controls.Add(this.lblPesos);
            this.grpPrecioCantidad.Location = new System.Drawing.Point(194, 338);
            this.grpPrecioCantidad.Name = "grpPrecioCantidad";
            this.grpPrecioCantidad.Size = new System.Drawing.Size(209, 52);
            this.grpPrecioCantidad.TabIndex = 8;
            this.grpPrecioCantidad.TabStop = false;
            this.grpPrecioCantidad.Text = "Precio Unitario y Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(141, 20);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(55, 20);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(86, 23);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(25, 20);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(55, 20);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(6, 23);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(13, 13);
            this.lblPesos.TabIndex = 9;
            this.lblPesos.Text = "$";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCotizacionFinal);
            this.panel2.Controls.Add(this.btnCotizar);
            this.panel2.Location = new System.Drawing.Point(-2, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 71);
            this.panel2.TabIndex = 9;
            // 
            // lblCotizacionFinal
            // 
            this.lblCotizacionFinal.AutoSize = true;
            this.lblCotizacionFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacionFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCotizacionFinal.Location = new System.Drawing.Point(182, 22);
            this.lblCotizacionFinal.Name = "lblCotizacionFinal";
            this.lblCotizacionFinal.Size = new System.Drawing.Size(230, 29);
            this.lblCotizacionFinal.TabIndex = 3;
            this.lblCotizacionFinal.Text = "$ ______________";
            this.lblCotizacionFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHistorialCotizaciones
            // 
            this.lblHistorialCotizaciones.AutoSize = true;
            this.lblHistorialCotizaciones.Location = new System.Drawing.Point(295, 14);
            this.lblHistorialCotizaciones.Name = "lblHistorialCotizaciones";
            this.lblHistorialCotizaciones.Size = new System.Drawing.Size(110, 13);
            this.lblHistorialCotizaciones.TabIndex = 1;
            this.lblHistorialCotizaciones.TabStop = true;
            this.lblHistorialCotizaciones.Text = "Historial  Cotizaciones";
            this.lblHistorialCotizaciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHistorialCotizaciones_LinkClicked);
            // 
            // CotizadorRopa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grpPrecioCantidad);
            this.Controls.Add(this.grpCalidad);
            this.Controls.Add(this.pnlUnidadesDisponibles);
            this.Controls.Add(this.grpPrenda);
            this.Controls.Add(this.pnlDatosVendedor);
            this.Controls.Add(this.btnListadoPrendas);
            this.Controls.Add(this.lblDatosTienda);
            this.Controls.Add(this.lblTitulo);
            this.Name = "CotizadorRopa";
            this.Text = "Cotizador de Prendas";
            this.pnlDatosVendedor.ResumeLayout(false);
            this.pnlDatosVendedor.PerformLayout();
            this.grpPrenda.ResumeLayout(false);
            this.grpPrenda.PerformLayout();
            this.pnlUnidadesDisponibles.ResumeLayout(false);
            this.pnlUnidadesDisponibles.PerformLayout();
            this.grpCalidad.ResumeLayout(false);
            this.grpCalidad.PerformLayout();
            this.grpPrecioCantidad.ResumeLayout(false);
            this.grpPrecioCantidad.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDatosTienda;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Button btnListadoPrendas;
        private System.Windows.Forms.Panel pnlDatosVendedor;
        private System.Windows.Forms.Label lblDatosVendedor;
        private System.Windows.Forms.GroupBox grpPrenda;
        private System.Windows.Forms.RadioButton rdioPantalon;
        private System.Windows.Forms.RadioButton rdioCamisa;
        private System.Windows.Forms.CheckBox chkChupin;
        private System.Windows.Forms.CheckBox chkCuelloMao;
        private System.Windows.Forms.CheckBox chkMangaCorta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlUnidadesDisponibles;
        private System.Windows.Forms.Label lblUnidadesDisponibles;
        private System.Windows.Forms.GroupBox grpCalidad;
        private System.Windows.Forms.RadioButton rdioPremium;
        private System.Windows.Forms.RadioButton rdioStandard;
        private System.Windows.Forms.GroupBox grpPrecioCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label lblCampoUnidades;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCotizacionFinal;
        private System.Windows.Forms.LinkLabel lblHistorialCotizaciones;
    }
}

