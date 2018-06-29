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
    public partial class FormRecetaDePan : Form
    {
        public void nombre_producto()

        {
            costeoEntities db = new costeoEntities();
            var lista = db.producto.ToList();
            if (lista.Count > 0)
            {
                cm_prodfinal.DataSource = lista;
                cm_prodfinal.DisplayMember = "nombre";
                cm_prodfinal.ValueMember = "id";
                cm_inginsumos.DataSource = lista;
                cm_inginsumos.DisplayMember = "nombre";
                cm_inginsumos.ValueMember = "id";
            }

        }
        public void nombre_producto1()

        {
            costeoEntities db = new costeoEntities();
            var lista = db.producto.ToList();
            if (lista.Count > 0)
            {
               
                cm_inginsumos.DataSource = lista;
                cm_inginsumos.DisplayMember = "nombre";
                cm_inginsumos.ValueMember = "id";
            }

        }
         public void uni_medida()

        {
            costeoEntities db = new costeoEntities();
            var lista = db.unidad_medida.ToList();
            if (lista.Count > 0)
            {

                comboBox1.DataSource = lista;
                comboBox1.DisplayMember = "descripcion";
                comboBox1.ValueMember = "id";
            }

        }
        public FormRecetaDePan()
        {
            InitializeComponent();
            nombre_producto();
            nombre_producto1();
            uni_medida();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dg_reporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cm_prodfinal_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void cm_inginsumos_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void FormRecetaDePan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}