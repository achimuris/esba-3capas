using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace MiPrimeraAPPen3Capas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbTipoDeProductos.SelectedValue.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TipoDeProducto unTipoDeProducto = new TipoDeProducto();



            //dgvTiposDeProductos.DataSource = unTipoDeProducto.Listar();
            dgvTiposDeProductos.DataSource = unTipoDeProducto.ReporteDeStore();

            cmbTipoDeProductos.DataSource = unTipoDeProducto.Listar();
            cmbTipoDeProductos.DisplayMember = "nombre";
            cmbTipoDeProductos.ValueMember = "codigo";
        }
    }
}
