using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FormReporteKilo : Form
    {
        public FormReporteKilo()
        {
            InitializeComponent();
            llenarCompoTipoPan();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void llenarCompoTipoPan() {
            costeoEntities db = new costeoEntities();
            var lista = db.familia.ToList();

            if (lista.Count > 0)
            {

                cb_tipopan.DataSource = lista;
                cb_tipopan.DisplayMember = "nombre";
                cb_tipopan.ValueMember = "id";
            }
        }
        private void cb_tipopan_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            costeoEntities db = new costeoEntities();
            BindingSource bi = new BindingSource();
            bi.DataSource = db.unidad_medida.ToList();
            dg_reporte.DataSource = bi;
            dg_reporte.Refresh();
        }

        private void FormReporteKilo_Load(object sender, EventArgs e)
        {

        }
    }
}
