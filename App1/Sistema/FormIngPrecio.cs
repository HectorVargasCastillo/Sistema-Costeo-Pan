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
            mostrar_datagridview();
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
                costeoEntities dbp = new costeoEntities();
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
                tb_codigo.Focus();
                mostrar_datagridview();

            }
        }


        private void mostrar_datagridview()
        {
            costeoEntities dbprecio_venta = new costeoEntities();
            BindingSource bi = new BindingSource();
            bi.DataSource = dbprecio_venta.precio_venta.ToList();
            dg_mostrar.DataSource = bi;
            
            dg_mostrar.Columns[0].Visible = false;
            dg_mostrar.Columns[3].Visible = false;
            dg_mostrar.Columns[5].Visible = false;
            dg_mostrar.Columns[6].Visible = false;
            dg_mostrar.Columns[7].Visible = false;
            dg_mostrar.Columns[8].Visible = false;

            dg_mostrar.Columns[0].HeaderText = "Fecha";
            dg_mostrar.Columns[1].HeaderText = "Producto";
            dg_mostrar.Columns[2].HeaderText = "Precio Venta";
           
            dg_mostrar.Columns[1].Width = 226;

            dg_mostrar.Columns[2].DisplayIndex = 4;
            dg_mostrar.Columns[4].DisplayIndex = 2;

            dg_mostrar.Refresh();
        }

        private void mostrar2_datagridview()
        {
            costeoEntities dbprecio_venta = new costeoEntities();
            List<Datos> miLista = new List<Datos>();
            foreach (var dato in dbprecio_venta.precio_venta.ToList())
            {
                Datos misDatos = new Datos();
                misDatos.fecha = dato.fecha;
                costeoEntities db = new costeoEntities();
                var producto = db.producto.FirstOrDefault(codigo => codigo.id == dato.producto_id);
                misDatos.producto = producto.nombre;
                misDatos.valor = dato.valor;
                miLista.Add(misDatos);
            }
            dg_mostrar.DataSource = miLista;
            dg_mostrar.Refresh();
        }


    }
}
