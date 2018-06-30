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
    public partial class FormProdPan : Form
    {
        public FormProdPan()
        {
            InitializeComponent();
            listaProductos();
            listaUniMed();
            tb_produccion.Focus();
            mostrar_datagridview();
        }
        

        public void listaProductos()
        {
            costeoEntities db = new costeoEntities();
            var lista = db.producto.ToList();
            if (lista.Count > 0)
            {
                cm_producto.DataSource = lista;
                cm_producto.DisplayMember = "nombre";
                cm_producto.ValueMember = "id";
            }
        }

        public void listaUniMed()
        {
            costeoEntities db = new costeoEntities();
            var lista = db.unidad_medida.ToList();
            if (lista.Count > 0)
            {
                cm_unimed.DataSource = lista;
                cm_unimed.DisplayMember = "descripcion";
                cm_unimed.ValueMember = "id";
            }
        }



        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (tb_produccion.Text == "") 
            {
                    MessageBox.Show("Debe Ingresar Produccion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_produccion.Focus();
                
            }
            else
            {

                if (tb_id.Text == "")
                {
                    costeoEntities dbp = new costeoEntities();
                    String fecval_ex = "N";
                    foreach (var dato in dbp.produccion_diaria.ToList())
                    {
                        if ((dato.fecha == DateTime.Today) && (dato.produccion == Convert.ToString(tb_produccion.Text)))
                        {
                            fecval_ex = "S";
                        }
                    }
                    if (fecval_ex == "S")
                    {
                        MessageBox.Show("Registro Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_produccion.Text = "";
                        tb_id.Text = "";
                        tb_produccion.Focus();
                        mostrar_datagridview();
                    }
                    else
                    {
                        costeoEntities db = new costeoEntities();
                        producto pro = new producto();
                        var codigo_pro = Convert.ToInt16(cm_producto.SelectedValue);
                        unidad_medida um = new unidad_medida();
                        var codigo_um = Convert.ToInt16(cm_unimed.SelectedValue);
                        var unimed = db.unidad_medida.FirstOrDefault(codigol => codigol.id == codigo_um);
                        produccion_diaria pd = new produccion_diaria();
                        pd.unidad_medida = Convert.ToString(unimed.descripcion);
                        pd.produccion = Convert.ToString(tb_produccion.Text);
                        pd.fecha = DateTime.Today;
                        pd.producto_id = Convert.ToInt16(codigo_pro);
                        pd.creado_el = DateTime.Today;
                        pd.modicifado_el = null;
                        pd.eliminado_el = null;
                        db.produccion_diaria.Add(pd);
                        db.SaveChanges();
                        MessageBox.Show("Registro Guardado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_produccion.Text = "";
                        tb_id.Text = "";
                        tb_produccion.Focus();
                        mostrar_datagridview();
                    }
                }
                else
                {
                    MessageBox.Show("Registro Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_produccion.Text = "";
                    tb_id.Text = "";
                    tb_produccion.Focus();
                    mostrar_datagridview();
                }
            }
        }

        

        private void cm_producto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cm_unimed.Focus();
        }

        private void cm_unimed_SelecionChangeCommited(object sender, EventArgs e)
        {
            tb_produccion.Focus();
        }

        private void tb_produccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                if (e.KeyChar == '\r')
                {
                    if (string.IsNullOrEmpty(tb_produccion.Text))
                    {
                        MessageBox.Show("Debe Ingresar Produccion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_produccion.Focus();
                    }
                    else
                    {
                        bt_guardar.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Solo se Permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }

            }

        }


        private void mostrar_datagridview()
        {
            costeoEntities dbproduccion_diaria = new costeoEntities();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Producto");
            tabla.Columns.Add("U.M.");
            tabla.Columns.Add("Produccion");
            tabla.Columns.Add("Id");
            foreach (var dato in dbproduccion_diaria.produccion_diaria.ToList())
            {
                if (dato.eliminado_el == null)
                {
                    DataRow row = tabla.NewRow();
                    row["Fecha"] = dato.fecha.ToShortDateString();
                    costeoEntities db = new costeoEntities();
                    var producto = db.producto.FirstOrDefault(codigo => codigo.id == dato.producto_id);
                    row["Producto"] = producto.nombre;
                    row["U.M."] = dato.unidad_medida.ToString();
                    row["Produccion"] = dato.produccion.ToString();
                    row["Id"] = Convert.ToString(dato.id);
                    tabla.Rows.Add(row);
                }
            }
            tabla.DefaultView.Sort = "[Fecha] DESC";
            dg_mostrar.DataSource = tabla;
            dg_mostrar.Columns["Producto"].Width = 226;
            dg_mostrar.Columns["Id"].Visible = false;

            dg_mostrar.Columns["Fecha"].ReadOnly = true;
            dg_mostrar.Columns["Producto"].ReadOnly = true;
            dg_mostrar.Columns["U.M."].ReadOnly = true;
            dg_mostrar.Columns["Produccion"].ReadOnly = true;

            dg_mostrar.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_mostrar.Columns["Produccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dg_mostrar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_mostrar.Refresh();

            

        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (tb_produccion.Text == "") 
            {
                MessageBox.Show("Para Eliminar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_produccion.Focus();
            }
            else
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Eliminar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_produccion.Focus();
                }
                else
                {

                    if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        costeoEntities db = new costeoEntities();
                        produccion_diaria pro = new produccion_diaria();
                        pro = db.produccion_diaria.Find(Convert.ToInt16(tb_id.Text));

                        if (pro == null)
                        {
                            MessageBox.Show("ERROR : No Permite Eliminar Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            pro.eliminado_el = DateTime.Today;
                            db.SaveChanges();
                            MessageBox.Show("Registro Eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_produccion.Text = "";
                            tb_id.Text = "";
                            tb_produccion.Focus();
                            mostrar_datagridview();
                        }
                    }
                    else
                    {
                        tb_produccion.Text = "";
                        tb_id.Text = "";
                        tb_produccion.Focus();
                        mostrar_datagridview();

                    }
                }
            }
        }

        private void dg_mostrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dg_mostrar.CurrentRow.Cells["Id"].Value.ToString();
            costeoEntities db = new costeoEntities();
            produccion_diaria pro = new produccion_diaria();
            pro = db.produccion_diaria.Find(Convert.ToInt16(tb_id.Text));

            tb_produccion.Text = Convert.ToString(pro.produccion);

            int index = cm_producto.FindString(dg_mostrar.CurrentRow.Cells["Producto"].Value.ToString()); 
            var lista = db.producto.ToList();
            if (lista.Count > 0)
            {   cm_producto.DataSource = lista;
                cm_producto.DisplayMember = "nombre";
                cm_producto.ValueMember = "id";
            }
            cm_producto.SelectedIndex = index;

            int indexum = cm_unimed.FindString(dg_mostrar.CurrentRow.Cells["U.M."].Value.ToString());
            var listaum = db.unidad_medida.ToList();
            if (listaum.Count > 0)
            {   cm_unimed.DataSource = listaum;
                cm_unimed.DisplayMember = "descripcion";
                cm_unimed.ValueMember = "id";
            }
            cm_unimed.SelectedIndex = indexum;
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (tb_produccion.Text == "")
            {
                MessageBox.Show("Para Editar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_produccion.Focus();
            }
            else
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Modificar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_produccion.Focus();
                }
                else
                {
                    costeoEntities db = new costeoEntities();
                    produccion_diaria pd = new produccion_diaria();
                    pd = db.produccion_diaria.Find(Convert.ToInt16(tb_id.Text));

                    if (pd == null)
                    {
                        MessageBox.Show("ERROR : No Permite Modificar Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        producto pro = new producto();
                        var codigo_pro = Convert.ToInt16(cm_producto.SelectedValue);
                        unidad_medida um = new unidad_medida();
                        var codigo_um = Convert.ToInt16(cm_unimed.SelectedValue);
                        var unimed = db.unidad_medida.FirstOrDefault(codigol => codigol.id == codigo_um);

                        if ((pd.produccion != Convert.ToString(tb_produccion.Text)) ||
                            (pd.producto_id != Convert.ToInt16(codigo_pro)) ||
                            (pd.unidad_medida != Convert.ToString(unimed.descripcion))
                            )
                        {
                            pd.unidad_medida = Convert.ToString(unimed.descripcion);
                            pd.produccion = Convert.ToString(tb_produccion.Text);
                            pd.producto_id = Convert.ToInt16(codigo_pro);
                            pd.modicifado_el = DateTime.Today;
                            db.SaveChanges();
                            MessageBox.Show("Registro Modificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_produccion.Text = "";
                            tb_id.Text = "";
                            tb_produccion.Focus();
                            mostrar_datagridview();
                        }
                        else
                        {
                            MessageBox.Show("No Modificó Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_produccion.Text = "";
                            tb_id.Text = "";
                            tb_produccion.Focus();
                            mostrar_datagridview();
                        }
                    }
                }

            }
        }
    }
}
