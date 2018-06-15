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
    public partial class FormRegistroProducto : Form
    {
        public FormRegistroProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            costeoEntities db = new costeoEntities();
            var lista = db.familia.ToList();


            if (lista.Count > 0)
            {

                cm_unidadmedida.DataSource = lista;
                cm_unidadmedida.DisplayMember = "nombre";
                cm_unidadmedida.ValueMember = "id";
            }

        }

        private void FormRegistroProducto_Load(object sender, EventArgs e)
        {

        }

        private void cm_unidadmedida_SelectedIndexChanged(object sender, EventArgs e)
        {

            costeoEntities db = new costeoEntities();
            var lista = db.unidad_medida.ToList();


            if (lista.Count > 0)
            {

                cm_unidadmedida.DataSource = lista;
                cm_unidadmedida.DisplayMember = "nombre";
                cm_unidadmedida.ValueMember = "id";
            }

        }

        private void cm_linea_SelectedIndexChanged(object sender, EventArgs e)
        {
            costeoEntities db = new costeoEntities();
            var lista = db.linea.ToList();


            if (lista.Count > 0)
            {

                cm_unidadmedida.DataSource = lista;
                cm_unidadmedida.DisplayMember = "nombre";
                cm_unidadmedida.ValueMember = "id";
            }
        }
    }
}
