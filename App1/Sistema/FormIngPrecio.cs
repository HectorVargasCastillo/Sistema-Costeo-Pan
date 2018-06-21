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





    public partial class FormIngPrecio : Form
    {


        public class Datos
        {

            public DateTime fecha;
            public string producto;
            public int valor;

        }




        public FormIngPrecio()
        {
            InitializeComponent();
            tb_codigo.MaxLength = 13;
            tb_nuevo.MaxLength = 10;
            tb_codigo.Select();
            mostrar3_datagridview();
        }



        private void tb_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                if (e.KeyChar == '\r')
                {
                    if (string.IsNullOrEmpty(tb_codigo.Text))
                    {
                        MessageBox.Show("Debe Ingresar Codigo Barra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_codigo.Text = "";
                        tb_codigo.Focus();
                    }
                    else
                    {
                        //******MessageBox.Show("PressKey-Codigo-2");
                        costeoEntities db = new costeoEntities();
                        var codigo_int = Convert.ToInt64(tb_codigo.Text);
                        var producto = db.producto.FirstOrDefault(codigo => codigo.codigo_barra == codigo_int);

                        if (producto != null)
                        {

                            costeoEntities dbf = new costeoEntities();
                            var familia = dbf.familia.FirstOrDefault(codigof => codigof.id == producto.familia_id);
                            var linea_id = familia.linea_id;

                            costeoEntities dbl = new costeoEntities();
                            var linea = dbl.linea.FirstOrDefault(codigol => codigol.id == linea_id);

                            tb_nombre.Text = producto.nombre;
                            tb_unidad.Text = Convert.ToString(producto.unidad_medida_id);
                            tb_marca.Text = producto.marca;
                            tb_formato.Text = Convert.ToString(producto.fomato);
                            tb_linea.Text = linea.nombre;
                            tb_familia.Text = familia.nombre;
                            tb_nuevo.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Codigo Barra NO Encontrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_codigo.Text = "";
                            tb_codigo.Focus();
                        }

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


        private void bt_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_codigo.Text))
            {
                MessageBox.Show("Debe Ingresar Codigo Barra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_codigo.Text = "";
                tb_codigo.Focus();
            }
            else
            {
                //MessageBox.Show("Mostrar Datos");
                costeoEntities db = new costeoEntities();
                var codigo_int = Convert.ToInt64(tb_codigo.Text);
                var producto = db.producto.FirstOrDefault(codigo => codigo.codigo_barra == codigo_int);

                if (producto != null)
                {

                    costeoEntities dbf = new costeoEntities();
                    var familia = dbf.familia.FirstOrDefault(codigof => codigof.id == producto.familia_id);
                    var linea_id = familia.linea_id;

                    costeoEntities dbl = new costeoEntities();
                    var linea = dbl.linea.FirstOrDefault(codigol => codigol.id == linea_id);

                    tb_nombre.Text = producto.nombre;
                    tb_unidad.Text = Convert.ToString(producto.unidad_medida_id);
                    tb_marca.Text = producto.marca;
                    tb_formato.Text = Convert.ToString(producto.fomato);
                    tb_linea.Text = linea.nombre;
                    tb_familia.Text = familia.nombre;
                    tb_nuevo.Focus();
                }
                else
                {
                    MessageBox.Show("Codigo Barra NO Encontrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_codigo.Text = "";
                    tb_codigo.Focus();
                }

            }

        }

        private void tb_nuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                if (e.KeyChar == '\r')
                {
                    if (string.IsNullOrEmpty(tb_nuevo.Text))
                    {
                        MessageBox.Show("Debe Ingresar Nuevo Precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_nuevo.Focus();
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

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if ((tb_codigo.Text == "") || (tb_nuevo.Text == ""))
            {
                if (tb_codigo.Text == "")
                {
                    MessageBox.Show("Debe Ingresar Codigo Barra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_codigo.Focus();
                }
                else
                {
                    if (tb_nuevo.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar Nuevo Precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_nuevo.Focus();
                    }
                }
            }
            else
            {
                if (tb_id.Text == "")
                {
                    costeoEntities dbp = new costeoEntities();
                    String fecval_ex = "N";
                    foreach (var dato in dbp.costo.ToList())
                    {
                        if ((dato.fecha == DateTime.Today) && (dato.valor == Convert.ToInt16(tb_nuevo.Text)))
                        {
                            fecval_ex = "S";
                        }
                    }
                    if (fecval_ex == "S")
                    {
                        MessageBox.Show("Registro Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_codigo.Text = "";
                        tb_nombre.Text = "";
                        tb_unidad.Text = "";
                        tb_marca.Text = "";
                        tb_formato.Text = "";
                        tb_linea.Text = "";
                        tb_familia.Text = "";
                        tb_nuevo.Text = "";
                        tb_id.Text = "";
                        tb_codigo.Focus();
                        mostrar3_datagridview();
                    }
                    else
                    {
                        var codigo_int = Convert.ToInt64(tb_codigo.Text);
                        var producto = dbp.producto.FirstOrDefault(codigo => codigo.codigo_barra == codigo_int);

                        precio_venta pre = new precio_venta();
                        pre.fecha = DateTime.Today;
                        pre.valor = Convert.ToInt16(tb_nuevo.Text);
                        pre.es_actual = 0;
                        pre.producto_id = Convert.ToInt16(producto.id);
                        pre.creado_el = DateTime.Today;
                        pre.modificado_el = null;
                        pre.eliminado_el = null;
                        costeoEntities db = new costeoEntities();
                        db.precio_venta.Add(pre);
                        db.SaveChanges();
                        tb_codigo.Text = "";
                        tb_nombre.Text = "";
                        tb_unidad.Text = "";
                        tb_marca.Text = "";
                        tb_formato.Text = "";
                        tb_linea.Text = "";
                        tb_familia.Text = "";
                        tb_nuevo.Text = "";
                        tb_id.Text = "";
                        tb_codigo.Focus();
                        mostrar3_datagridview();

                    }
                }
                else
                {
                    MessageBox.Show("Registro Ya Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_codigo.Text = "";
                    tb_nombre.Text = "";
                    tb_unidad.Text = "";
                    tb_marca.Text = "";
                    tb_formato.Text = "";
                    tb_linea.Text = "";
                    tb_familia.Text = "";
                    tb_nuevo.Text = "";
                    tb_id.Text = "";
                    tb_codigo.Focus();
                    mostrar3_datagridview();
                }

            }
        }



        private void mostrar3_datagridview()
        {
            costeoEntities dbprecio_venta = new costeoEntities();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Producto");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Id");
            foreach (var dato in dbprecio_venta.precio_venta.ToList())
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

            }
            tabla.DefaultView.Sort = "[Fecha] DESC";
            dg_mostrar.DataSource = tabla;
            dg_mostrar.Columns["Producto"].Width = 226;
            dg_mostrar.Columns["Id"].Visible = false;
            dg_mostrar.Refresh();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if ((tb_codigo.Text == "") || (tb_nuevo.Text == ""))
            {
                MessageBox.Show("Para Eliminar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_nombre.Focus();
            }
            else
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Eliminar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_nombre.Focus();
                }
                else
                {

                    if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        costeoEntities db = new costeoEntities();
                        precio_venta pre = new precio_venta();
                        pre = db.precio_venta.Find(Convert.ToInt16(tb_id.Text));

                        if (pre == null)
                        {
                            MessageBox.Show("ERROR : No Permite Eliminar Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            pre.eliminado_el = DateTime.Today;
                            db.SaveChanges();
                            MessageBox.Show("Registro Eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_codigo.Text = "";
                            tb_nombre.Text = "";
                            tb_unidad.Text = "";
                            tb_marca.Text = "";
                            tb_formato.Text = "";
                            tb_linea.Text = "";
                            tb_familia.Text = "";
                            tb_nuevo.Text = "";
                            tb_id.Text = "";
                            tb_codigo.Focus();
                            mostrar3_datagridview();
                        }
                    }
                    else
                    {
                        tb_codigo.Text = "";
                        tb_nombre.Text = "";
                        tb_unidad.Text = "";
                        tb_marca.Text = "";
                        tb_formato.Text = "";
                        tb_linea.Text = "";
                        tb_familia.Text = "";
                        tb_nuevo.Text = "";
                        tb_id.Text = "";
                        tb_codigo.Focus();
                        mostrar3_datagridview();
                    }
                }
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if ((tb_codigo.Text == "") || (tb_nuevo.Text == ""))
            {
                MessageBox.Show("Para Editar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_nombre.Focus();
            }
            else
            {

                //MessageBox.Show(tb_id.Text, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Modificar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_nombre.Focus();
                }
                else
                {
                    costeoEntities db = new costeoEntities();
                    precio_venta pre = new precio_venta();
                    pre = db.precio_venta.Find(Convert.ToInt16(tb_id.Text));

                    if (pre == null)
                    {
                        MessageBox.Show("ERROR : No Permite Modificar Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        var codigo_int = Convert.ToInt64(tb_codigo.Text);
                        var producto = db.producto.FirstOrDefault(codigo => codigo.codigo_barra == codigo_int);

                        if ((pre.producto_id != Convert.ToInt16(producto.id)) && (pre.valor != Convert.ToInt16(tb_nuevo.Text)))
                        {
                            pre.producto_id = Convert.ToUInt16(tb_codigo.Text);
                            pre.valor = Convert.ToInt16(tb_nuevo.Text);
                            pre.modificado_el = DateTime.Today;
                            db.SaveChanges();
                            MessageBox.Show("Registro Modificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_codigo.Text = "";
                            tb_nombre.Text = "";
                            tb_unidad.Text = "";
                            tb_marca.Text = "";
                            tb_formato.Text = "";
                            tb_linea.Text = "";
                            tb_familia.Text = "";
                            tb_nuevo.Text = "";
                            tb_id.Text = "";
                            tb_codigo.Focus();
                            mostrar3_datagridview();
                        }
                        else
                        {
                            MessageBox.Show("No Modificó Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tb_codigo.Text = "";
                            tb_nombre.Text = "";
                            tb_unidad.Text = "";
                            tb_marca.Text = "";
                            tb_formato.Text = "";
                            tb_linea.Text = "";
                            tb_familia.Text = "";
                            tb_nuevo.Text = "";
                            tb_id.Text = "";
                            tb_codigo.Focus();
                            mostrar3_datagridview();
                        }
                    }
                }

            }
        }

        private void dg_mostrar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dg_mostrar.CurrentRow.Cells["Id"].Value.ToString();
            tb_nuevo.Text = dg_mostrar.CurrentRow.Cells["Precio"].Value.ToString();
            costeoEntities db = new costeoEntities();
            precio_venta pre = new precio_venta();
            pre = db.precio_venta.Find(Convert.ToInt16(tb_id.Text));
            var codigo_int = Convert.ToInt64(pre.producto_id);
            var producto = db.producto.FirstOrDefault(codigo => codigo.id == codigo_int);
            costeoEntities dbf = new costeoEntities();
            var familia = dbf.familia.FirstOrDefault(codigof => codigof.id == producto.familia_id);
            var linea_id = familia.linea_id;

            costeoEntities dbl = new costeoEntities();
            var linea = dbl.linea.FirstOrDefault(codigol => codigol.id == linea_id);
            tb_codigo.Text = Convert.ToString(producto.codigo_barra);
            tb_nombre.Text = producto.nombre;
            tb_unidad.Text = Convert.ToString(producto.unidad_medida_id);
            tb_marca.Text = producto.marca;
            tb_formato.Text = Convert.ToString(producto.fomato);
            tb_linea.Text = linea.nombre;
            tb_familia.Text = familia.nombre;
        }
    }
}
