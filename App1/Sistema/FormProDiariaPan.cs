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
    public partial class FormProDiariaPan : Form
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
            }

        }
        public FormProDiariaPan()
        {
            InitializeComponent();
            nombre_producto();
            mostrar3_datagridview();
        }

        private void FormProDiariaPan_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void mostrar3_datagridview()
        {
            costeoEntities precio_diario = new costeoEntities();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("producto");
            tabla.Columns.Add("uni de medida");
            tabla.Columns.Add("produccion");
            tabla.Columns.Add("fecha");
            tabla.Columns.Add("Id");
            /* foreach (var dato in precio_diario.precio_venta.ToList())
             {
                 if (dato.eliminado_el == null)
                 {
                     DataRow row = tabla.NewRow();
                     row["Fecha"] = Convert.ToString(dato.fecha);
                     costeoEntities db = new costeoEntities();
                     var producto = db.producto.FirstOrDefault(codigo => codigo.id == dato.producto_id);
                     row["Producto"] = producto.nombre;
                     row["Precio"] = Convert.ToString(dato.valor);
                     row["Id"] = Convert.ToString(dato.id);
                     tabla.Rows.Add(row);
                 }

             }*/
            tabla.DefaultView.Sort = "[Fecha] DESC";
            dg_reporte.DataSource = tabla;
            dg_reporte.Columns["Producto"].Width = 226;
            dg_reporte.Columns["Id"].Visible = false;
            dg_reporte.Refresh();
        }
        private void dg_reporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            
        }

        private void cm_prodfinal_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_unidadmedida.Text == "")
            {
                // MessageBox.Show("Debe Ingresar Descripcion Familia");
                MessageBox.Show("Debe Ingresar unidad de medida ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_unidadmedida.Focus();
            }
            if (tb_produccion.Text == "")
            {
                // MessageBox.Show("Debe Ingresar Descripcion Familia");
                MessageBox.Show("Debe Ingresar produccion ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_produccion.Focus();
            }
            costeoEntities db = new costeoEntities();
            produccion_diaria pro = new produccion_diaria();

            pro.producto_id = Convert.ToInt32(cm_prodfinal.SelectedValue);
            pro.unidad_medida = tb_unidadmedida.Text;
            pro.produccion = tb_produccion.Text;
            pro.creado_el = DateTime.Today;
            db.produccion_diaria.Add(pro);
            db.SaveChanges();
            MessageBox.Show("Registro Guardado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            tb_unidadmedida.Focus();
            mostrar3_datagridview();



        }

        private void bt_editar_Click(object sender, EventArgs e)
        {

        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void dg_reporte_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //tb_id.Text = dg_mostrar.CurrentRow.Cells["Id"].Value.ToString();
            //tb_nuevo.Text = dg_mostrar.CurrentRow.Cells["Precio"].Value.ToString();
            costeoEntities db = new costeoEntities();
            produccion_diaria pre = new produccion_diaria();
            //pre = db.precio_venta.Find(Convert.ToInt16(tb_id.Text));
            //var codigo_int = Convert.ToInt64(pre.producto_id);
            //var producto = db.producto.FirstOrDefault(codigo => codigo.id == codigo_int);
            //costeoEntities dbf = new costeoEntities();
            //var familia = dbf.familia.FirstOrDefault(codigof => codigof.id == producto.familia_id);
            //var linea_id = familia.linea_id;

            //costeoEntities dbl = new costeoEntities();
            //var linea = dbl.linea.FirstOrDefault(codigol => codigol.id == linea_id);
            cm_prodfinal.Text = pre.producto_id.ToString();
            tb_unidadmedida.Text = pre.unidad_medida.ToString();
            tb_produccion.Text = pre.produccion.ToString();
            
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
