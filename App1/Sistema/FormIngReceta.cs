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
    public partial class FormIngReceta : Form
    {
        public FormIngReceta()
        {
            InitializeComponent();
            listaProductos();
            listaInsumos();
            listaUniMed();
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

        public void listaInsumos()
        {
            costeoEntities db = new costeoEntities();
            var lista = db.producto.ToList();
            if (lista.Count > 0)
            {
                cm_insumo.DataSource = lista;
                cm_insumo.DisplayMember = "nombre";
                cm_insumo.ValueMember = "id";
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

        private void mostrar_datagridview()
        {
            costeoEntities db = new costeoEntities();
            var id_receta = 0;
            foreach (var dato in db.receta.ToList())
            {
                if (dato.eliminado_el == null)
                {
                    if (dato.producto_id == Convert.ToInt16(cm_producto.SelectedValue))
                    { 
                       id_receta = dato.id;
                    }                 
                }
            }

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Insumo");
            tabla.Columns.Add("U.M.");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Id");
            tabla.Columns.Add("IdReceta");
            foreach (var dato in db.detalle_receta.ToList())
            {
                if (dato.eliminado_el == null)
                {
                    if (dato.receta_id == id_receta)
                    {
                        DataRow row = tabla.NewRow();
                        var insumo = db.producto.FirstOrDefault(codigo => codigo.id == dato.producto_id);
                        row["Insumo"] = insumo.nombre;
                        row["U.M."] = "HOLI";// dato.unidad_medida.ToString();
                        row["Cantidad"] = dato.cantidad.ToString();
                        row["Id"] = Convert.ToInt16(dato.id);
                        //var receta = db.receta.FirstOrDefault(codigo => codigo.id == dato.receta_id);
                        row["IdReceta"] = Convert.ToInt16(dato.receta_id);
                        tabla.Rows.Add(row);
                    }
                }
            }
            tabla.DefaultView.Sort = "[Insumo] DESC";
            dg_mostrar.DataSource = tabla;
            dg_mostrar.Columns["Insumo"].Width = 226;
            dg_mostrar.Columns["Id"].Visible = false;
            dg_mostrar.Columns["IdReceta"].Visible = false;
            
            dg_mostrar.Columns["Insumo"].ReadOnly = true;
            dg_mostrar.Columns["U.M."].ReadOnly = true;
            dg_mostrar.Columns["Cantidad"].ReadOnly = true;

            dg_mostrar.Columns["Insumo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_mostrar.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dg_mostrar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_mostrar.Refresh();
        }


        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (tb_cantidad.Text == "")
            {
                MessageBox.Show("Debe Ingresar Cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_cantidad.Focus();

            }
            else
            {

                if (tb_id.Text == "")
                {
                    var id_receta = 0;
                    costeoEntities db = new costeoEntities();
                    foreach (var dato in db.receta.ToList())
                    {
                        if (dato.producto_id == Convert.ToInt16(cm_producto.SelectedValue))
                        {
                            id_receta = dato.id;
                        }
                    }
                    if (id_receta > 0)
                    {
                        String fecval_ex = "N";
                        var codigo_ins = Convert.ToInt16(cm_insumo.SelectedValue);
                        foreach (var dato in db.detalle_receta.ToList())
                        {
                            if ((dato.cantidad == Convert.ToInt16(tb_cantidad.Text) && (dato.producto_id == codigo_ins)))
                            {
                                fecval_ex = "S";
                            }
                        }
                        if (fecval_ex == "S")
                        {
                            MessageBox.Show("Registro Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_cantidad.Text = "";
                            tb_id.Text = "";
                            tb_cantidad.Focus();
                            mostrar_datagridview();
                        }
                        else
                        {
                           
                            detalle_receta detalle = new detalle_receta();
                            detalle.receta_id = id_receta;
                            detalle.producto_id = codigo_ins;
                            detalle.cantidad = Convert.ToInt16(tb_cantidad.Text);
                            detalle.creado_el = DateTime.Today;
                            detalle.modificado_el = null;
                            detalle.eliminado_el = null;
                            db.detalle_receta.Add(detalle);
                            db.SaveChanges();
                            MessageBox.Show("Registro Detalle Guardado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_cantidad.Text = "";
                            tb_id.Text = "";
                            tb_cantidad.Focus();
                            mostrar_datagridview();
                        }

                    }
                    else
                    {
                        var codigo_pro = Convert.ToInt16(cm_producto.SelectedValue);
                        var codigo_ins = Convert.ToInt16(cm_insumo.SelectedValue);
                        //costeoEntities db = new costeoEntities();
                        String fecval_ex = "N";
                        /*foreach (var dato in db.receta.ToList())
                        {
                           if ((dato.fecha == DateTime.Today) && (dato.producto_id == codigo_pro))
                           {
                             fecval_ex = "S";
                           }
                        }*/
                        foreach (var dato in db.detalle_receta.ToList())
                        {
                            if ((dato.cantidad == Convert.ToInt16(tb_cantidad.Text) && (dato.producto_id == codigo_ins)))
                            {
                                fecval_ex = "S";
                            }
                        }
                        if (fecval_ex == "S")
                        {
                            MessageBox.Show("Registro Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_cantidad.Text = "";
                            tb_id.Text = "";
                            tb_cantidad.Focus();
                            mostrar_datagridview();
                        }
                        else
                        {
                            //var codigo_pro = Convert.ToInt16(cm_producto.SelectedValue);
                            //var codigo_ins = Convert.ToInt16(cm_insumo.SelectedValue);
                            var codigo_um = Convert.ToInt16(cm_unimed.SelectedValue);
                            var unimed = db.unidad_medida.FirstOrDefault(codigol => codigol.id == codigo_um);
                            //pro.unidad_medida = Convert.ToString(unimed.descripcion);

                            receta encabezado = new receta();
                            encabezado.producto_id = codigo_pro;
                            encabezado.es_actual = 0;
                            encabezado.fecha = DateTime.Today;
                            encabezado.creado_el = DateTime.Today;
                            encabezado.modificado_el = null;
                            encabezado.eliminado_el = null;
                            db.receta.Add(encabezado);
                            db.SaveChanges();
                            MessageBox.Show("Registro Encabezado Guardado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                            detalle_receta detalle = new detalle_receta();
                            detalle.receta_id = encabezado.id;
                            detalle.producto_id = codigo_ins;
                            detalle.cantidad = Convert.ToInt16(tb_cantidad.Text);
                            detalle.creado_el = DateTime.Today;
                            detalle.modificado_el = null;
                            detalle.eliminado_el = null;
                            db.detalle_receta.Add(detalle);
                            db.SaveChanges();
                            MessageBox.Show("Registro Detalle Guardado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_cantidad.Text = "";
                            tb_id.Text = "";
                            tb_cantidad.Focus();
                            mostrar_datagridview();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Registro Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_cantidad.Text = "";
                    tb_id.Text = "";
                    tb_cantidad.Focus();
                    mostrar_datagridview();
                }

            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (tb_cantidad.Text == "")
            {
                MessageBox.Show("Para Editar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_cantidad.Focus();
            }
            else
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Modificar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_cantidad.Focus();
                }
                else
                {
                    costeoEntities db = new costeoEntities();
                    receta encabezado = new receta();
                    detalle_receta detalle = new detalle_receta();
                    encabezado = db.receta.Find(Convert.ToInt16(tb_id_receta.Text));
                    detalle = db.detalle_receta.Find(Convert.ToInt16(tb_id.Text));

                    if ((encabezado == null) || (detalle == null))
                    {
                        MessageBox.Show("ERROR : No Permite Modificar Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {

                        var codigo_pro = Convert.ToInt16(cm_producto.SelectedValue);
                        var codigo_ins = Convert.ToInt16(cm_insumo.SelectedValue);
                        var codigo_um = Convert.ToInt16(cm_unimed.SelectedValue);
                        var unimed = db.unidad_medida.FirstOrDefault(codigol => codigol.id == codigo_um);
                        //pro.unidad_medida = Convert.ToString(unimed.descripcion);

                        if ((encabezado.producto_id != Convert.ToInt16(codigo_pro)) ||
                            (detalle.producto_id != Convert.ToInt16(codigo_ins)) ||
                            //(detalle.unidad_medida != Convert.ToString(unimed.descripcion)
                            (detalle.cantidad != Convert.ToInt16(tb_cantidad.Text))
                            )
                        {
                            
                            encabezado.producto_id = codigo_pro;
                            encabezado.modificado_el = DateTime.Today;
                            db.SaveChanges();

                            detalle.producto_id = codigo_ins;
                            detalle.cantidad = Convert.ToInt16(tb_cantidad.Text);
                            detalle.modificado_el = DateTime.Today;
                            

                            MessageBox.Show("Registro Modificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            tb_cantidad.Text = "";
                            tb_id.Text = "";
                            tb_cantidad.Focus();
                            mostrar_datagridview();
                        }
                        else
                        {
                            MessageBox.Show("No Modificó Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_cantidad.Text = "";
                            tb_id.Text = "";
                            tb_cantidad.Focus();
                            mostrar_datagridview();
                        }
                    }
                }

            }
        }
        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (tb_cantidad.Text == "")
            {
                MessageBox.Show("Para Eliminar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_cantidad.Focus();
            }
            else
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Eliminar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_cantidad.Focus();
                }
                else
                {

                    if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        costeoEntities db = new costeoEntities();
                        receta encabezado = new receta();
                        encabezado = db.receta.Find(Convert.ToInt16(tb_id_receta.Text));

                        if (encabezado == null)
                        {
                            MessageBox.Show("ERROR : No Permite Eliminar Registro Encabezado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            encabezado.eliminado_el = DateTime.Today;
                            db.SaveChanges();
                            MessageBox.Show("Registro Encabezado Eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            detalle_receta detalle = new detalle_receta();
                            detalle = db.detalle_receta.Find(Convert.ToInt16(tb_id.Text));

                            if (detalle == null)
                            {
                                MessageBox.Show("ERROR : No Permite Eliminar Registro Detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            else
                            {
                                detalle.eliminado_el = DateTime.Today;
                                db.SaveChanges();
                                MessageBox.Show("Registro Detalle Eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                tb_cantidad.Text = "";
                                tb_id.Text = "";
                                tb_cantidad.Focus();
                                mostrar_datagridview();
                            }
                        }
                    }
                    else
                    {
                        tb_cantidad.Text = "";
                        tb_id.Text = "";
                        tb_cantidad.Focus();
                        mostrar_datagridview();

                    }
                }
            }
        }

        private void cm_producto_SelectionChangedCommited(object sender, EventArgs e)
        {
            //cm_insumo.Focus();
            mostrar_datagridview();
        }

        private void cm_insumo_SelectedChangedCommited(object sender, EventArgs e)
        {
            cm_unimed.Focus();
        }

        private void cm_unimed_SelectedChangedCommited(object sender, EventArgs e)
        {
            tb_cantidad.Focus();
        }

        private void tb_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                if (e.KeyChar == '\r')
                {
                    if (string.IsNullOrEmpty(tb_cantidad.Text))
                    {
                        MessageBox.Show("Debe Ingresar Produccion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_cantidad.Focus();
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

        private void gd_mostrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dg_mostrar.CurrentRow.Cells["Id"].Value.ToString();
            tb_id_receta.Text = dg_mostrar.CurrentRow.Cells["IdReceta"].Value.ToString();
            costeoEntities db = new costeoEntities();

            detalle_receta det = new detalle_receta();
            det = db.detalle_receta.Find(Convert.ToInt16(tb_id.Text));

            tb_cantidad.Text = Convert.ToString(det.cantidad);

            int index = cm_insumo.FindString(dg_mostrar.CurrentRow.Cells["Insumo"].Value.ToString());
            var lista = db.producto.ToList();
            if (lista.Count > 0)
            {
                cm_insumo.DataSource = lista;
                cm_insumo.DisplayMember = "nombre";
                cm_insumo.ValueMember = "id";
            }
            cm_insumo.SelectedIndex = index;

            /*int indexum = cm_unimed.FindString(dg_mostrar.CurrentRow.Cells["U.M."].Value.ToString());
            var listaum = db.unidad_medida.ToList();
            if (listaum.Count > 0)
            {
                cm_unimed.DataSource = listaum;
                cm_unimed.DisplayMember = "descripcion";
                cm_unimed.ValueMember = "id";
            }
            cm_unimed.SelectedIndex = indexum;*/

           /* var receta = db.receta.FirstOrDefault(codigo => codigo.id == det.receta_id);
            var producto = db.producto.FirstOrDefault(codigo => codigo.id == receta.producto_id);

            int indexpro = cm_producto.FindString(producto.nombre);
            var listapro = db.producto.ToList();
            if (listapro.Count > 0)
            {
                cm_producto.DataSource = listapro;
                cm_producto.DisplayMember = "nombre";
                cm_producto.ValueMember = "id";
            }
            cm_producto.SelectedIndex = indexpro;*/
            


        }
    }
}
