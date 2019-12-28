using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoria_EECC_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar()){
            
            Estado e1 = new Estado();
            e1.pNombreE = txtNomE.Text;
            e1.pAnio = Convert.ToInt32(txtAnio.Text);
            e1.pActivoCte = Convert.ToDouble(txtActCte.Text);
            e1.pActivoNoCte = Convert.ToDouble(txtActNoCte.Text);
            e1.pPasivoCte = Convert.ToDouble(txtPasCte.Text);
            e1.pPasivoNoCte = Convert.ToDouble(txtPasNoCte.Text);
            e1.pPatNeto = Convert.ToDouble(txtPN.Text);
            e1.pBnCambio = Convert.ToDouble(txtBnsC.Text);
            e1.pVenta = Convert.ToDouble(txtVtas.Text);
            e1.pRtdoOrd = Convert.ToDouble(txtRtdoOrd.Text);
            e1.pRtdoNeto = Convert.ToDouble(txtRtdoNeto.Text);
            MessageBox.Show(e1.toStringMessage());

            lblTotAct.Text = e1.calcularTotalActivo().ToString();
            lblTotPas.Text = e1.calcularTotalPasivo().ToString();
            lblSolv.Text = e1.calcularSolvencia().ToString();
            lblLiqCte.Text = e1.calcularLiquidezCte().ToString();
            lblEnde.Text = e1.calcularEndeudamiento().ToString();
            lblPruAc.Text = e1.calcularPruebaAcida().ToString();
            lblRPNAct.Text = e1.calcularRznPNAct().ToString();
            lblRzInAct.Text = e1.calcularRznInmAct().ToString();
            lblRtbInAc.Text = e1.calcularRtbInvAcc().ToString();
            lblApFin.Text = e1.calcularApalancaFin().ToString();
            lblRotAct.Text = e1.calcularRotacionAct().ToString();


        }
        }

        public Boolean Validar()
        {
           
            if (txtNomE.Text == string.Empty)
            {
                MessageBox.Show("COMPLETE CAMPO NOMBRE EMPRESA");
                txtNomE.Focus();
                return false;
            }
            if (txtAnio.Text == string.Empty)
            {
                MessageBox.Show("COMPLETE CAMPO AÑO");
                txtAnio.Focus();
                return false;
            }
            if (txtActCte.Text == string.Empty)
            {
                MessageBox.Show("COMPLETE CAMPO ACTIVO CORRIENTE");
                txtActCte.Focus();
                return false;
            }
            if (txtActNoCte.Text == string.Empty)
            {
                MessageBox.Show("COMPLETE CAMPO ACTIVO NO CORRIENTE");
                txtActNoCte.Focus();
                return false;
            }
            if (txtPasCte.Text == string.Empty)
            {
                MessageBox.Show("COMPLETE CAMPO PASIVO CORRIENTE");
                txtPasCte.Focus();
                return false;
            }
            if (txtPasNoCte.Text == string.Empty)
            {
                MessageBox.Show("COMPLETE CAMPO PASIVO NO CORRIENTE");
                txtPasNoCte.Focus();
                return false;
            }
            if (txtPN.Text == string.Empty)
            {
                MessageBox.Show("COMPLETE CAMPO PATRIMONIO NETO");
                txtPN.Focus();
                return false;
            }
            if (txtBnsC.Text == string.Empty)
            {
                MessageBox.Show("COMPLETE CAMPO BIENES DE CAMBIO");
                txtBnsC.Focus();
                return false;
            }
            if (txtVtas.Text == string.Empty)
            {
                MessageBox.Show("COMPLETE CAMPO VENTAS");
                txtVtas.Focus();
                return false;
            }
            if (txtRtdoNeto.Text == string.Empty)
            {
                MessageBox.Show("COMPLETE CAMPO RESULTADO NETO");
                txtRtdoNeto.Focus();
                return false;
            }
            if (txtRtdoOrd.Text == string.Empty)
            {
                MessageBox.Show("COMPLETE CAMPO RESULTADO ORDINARIO");
                txtRtdoOrd.Focus();
                return false;
            }
         


            return true;
            
            
        }

        public void limpiarCampos()
        {
            txtNomE.Clear();
            txtAnio.Clear();
            txtActCte.Clear();
            txtActNoCte.Clear();
            txtPasCte.Clear();
            txtPasNoCte.Clear();
            txtPN.Clear();
            txtBnsC.Clear();
            txtVtas.Clear();
            txtRtdoOrd.Clear();
            txtRtdoNeto.Clear();
            lblTotAct.ResetText();
            lblTotPas.ResetText();
            lblSolv.Text = "0.00";
            lblApFin.Text = "0.00";
            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
