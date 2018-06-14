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
    public partial class formulario1 : Form
    {
        public formulario1()
        {
            InitializeComponent();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
           if (tb_nombre.Text!= "")
            {
                unidad_medida um = new unidad_medida();
                um.descripcion = tb_nombre.Text;

                costeoEntities db = new costeoEntities();
                db.unidad_medida.Add(um);
                db.SaveChanges();
                tb_nombre.Text = "";
            
            }


        }


        private void bt_cargar_combo_Click(object sender, EventArgs e)
        {

            costeoEntities db = new costeoEntities(); 
            var lista = db.unidad_medida.ToList();


            if (lista.Count > 0)
            {

                cmb_unidad_medida.DataSource = lista;
                cmb_unidad_medida.DisplayMember = "nombre";
                cmb_unidad_medida.ValueMember = "id";
            }


        }

        private void bt_cargar_editar_Click(object sender, EventArgs e)
        {
            tb_edit_id.Text = cmb_unidad_medida.SelectedValue.ToString();
            tb_edit_nombre.Text = cmb_unidad_medida.Text.ToString();
        }

        private void bt_guardar_editar_Click(object sender, EventArgs e)
        {
            costeoEntities db = new costeoEntities();
            unidad_medida um = new unidad_medida();

            um = db.unidad_medida.Find(Convert.ToInt16(tb_edit_id.Text));
            um.descripcion = tb_edit_nombre.Text;
            db.SaveChanges();

        }

        private void bt_cargar_gv_Click(object sender, EventArgs e)
        {
            costeoEntities db = new costeoEntities();
            BindingSource bi = new BindingSource();
            bi.DataSource = db.unidad_medida.ToList();
            gv_todo.DataSource = bi;
            gv_todo.Refresh();

        }

        private void gv_todo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
