using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaRopaMayorista.presenter.views;
using VentaRopaMayorista.presenter;

namespace VentaRopaMayorista
{
    public partial class CotizadorRopa : Form, IViewTienda, IViewVendedor, IViewValidator
    {
        private TiendaPresenter tiendaPresenter;
        private VendedorPresenter vendedorPresenter;
        private ValidadorPresenter validadorPresenter;
        public CotizadorRopa()
        {
            InitializeComponent();
            this.tiendaPresenter = new TiendaPresenter(this);
            this.vendedorPresenter = new VendedorPresenter(this,this.tiendaPresenter.TiendaModel);
            ObtenerUnidadesDisponibles();
            this.validadorPresenter = new ValidadorPresenter(this);
        }

        public void VisualizarCatalogoPrendas(string datosPrendas)
        {
            MessageBox.Show(datosPrendas);
        }

        public void VisualizarDatosTienda(string datosTienda)
        {
            lblDatosTienda.Text = datosTienda;
        }

        public void VisualizarDatosVendedor(string datosVendedor)
        {
            lblDatosVendedor.Text = datosVendedor;
        }

        public void VisualizarUnidadesDisponibles(string unidadesDisponibles)
        {
            lblUnidadesDisponibles.Text = unidadesDisponibles;
        }

        private void ObtenerUnidadesDisponibles()
        {
            this.tiendaPresenter.VisualizarUnidadesDisponibles(rdioCamisa.Checked, chkMangaCorta.Checked, chkCuelloMao.Checked, chkChupin.Checked, rdioPremium.Checked);
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if(validadorPresenter.validarCampos(lblUnidadesDisponibles.Text, txtPrecio.Text, txtCantidad.Text) == true)
            {
                vendedorPresenter.RegistrarCotizacion(rdioCamisa.Checked, chkMangaCorta.Checked, chkCuelloMao.Checked, 
                                                        chkChupin.Checked, rdioPremium.Checked, txtCantidad.Text, txtPrecio.Text);

            }
            
        }

        private void btnListadoPrendas_Click(object sender, EventArgs e)
        {
            tiendaPresenter.VisualizarDatosCatalogo();
        }

        private void rdioCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioCamisa.Checked == true)
            {
                chkMangaCorta.Checked = false;
                chkMangaCorta.Enabled = true;
                chkCuelloMao.Checked = false;
                chkCuelloMao.Enabled = true;
                chkChupin.Checked = false;
                chkChupin.Enabled = false;
                
                lblCotizacionFinal.Text = "$ ______________";
            }
            ObtenerUnidadesDisponibles();
        }

        private void rdioPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioPantalon.Checked == true)
            {
                chkMangaCorta.Checked = false;
                chkMangaCorta.Enabled = false;
                chkCuelloMao.Checked = false;
                chkCuelloMao.Enabled = false;
                chkChupin.Checked = false;
                chkChupin.Enabled = true;
                
                lblCotizacionFinal.Text = "$ ______________";
            }
            ObtenerUnidadesDisponibles();
        }

        private void rdioStandard_CheckedChanged(object sender, EventArgs e)
        {
            ObtenerUnidadesDisponibles();
            
            lblCotizacionFinal.Text = "$ ______________";
        }

        private void rdioPremium_CheckedChanged(object sender, EventArgs e)
        {
            ObtenerUnidadesDisponibles();
            
            lblCotizacionFinal.Text = "$ ______________";
        }

        private void chkMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            ObtenerUnidadesDisponibles();
            
            lblCotizacionFinal.Text = "$ ______________";
        }

        private void chkCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            ObtenerUnidadesDisponibles();
            
            lblCotizacionFinal.Text = "$ ______________";
        }

        private void chkChupin_CheckedChanged(object sender, EventArgs e)
        {
            ObtenerUnidadesDisponibles();
            
            lblCotizacionFinal.Text = "$ ______________";
        }

        public void VisualizarResultadoValidaciones(string mensajeValidacion)
        {
            MessageBox.Show(mensajeValidacion);

        }

        public void visualizarCotizacion(string valorCotizacion)
        {
            lblCotizacionFinal.Text = "$ " + valorCotizacion;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            lblCotizacionFinal.Text= "$ ______________";
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            lblCotizacionFinal.Text = "$ ______________";
        }

        private void lblHistorialCotizaciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vendedorPresenter.visualizarHistorialCotizaciones();
        }

        public void visualizarHistorialCotizaciones(string historialCotizaciones)
        {
            MessageBox.Show(historialCotizaciones);
        }
    }
}
