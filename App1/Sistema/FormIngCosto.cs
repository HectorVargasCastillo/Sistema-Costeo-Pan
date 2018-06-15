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
    public partial class FormIngCosto : Form
    {
        public FormIngCosto()
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
                            //tb_linea.Text = Convert.ToString(producto.familia_id);
                            //tb_familia.Text = Convert.ToString(producto.familia_id);
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

        private void tb_nuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) 
            {

                if (e.KeyChar == '\r')
                {
                    if (string.IsNullOrEmpty(tb_nuevo.Text))
                    {
                        MessageBox.Show("Debe Ingresar Nuevo Costo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    //tb_linea.Text = Convert.ToString(producto.familia_id);
                    //tb_familia.Text = Convert.ToString(producto.familia_id);
                    //MessageBox.Show(linea.nombre, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show(familia.nombre, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void mostrar_datagridview()
        {
            costeoEntities dbcosto = new costeoEntities();
            BindingSource bi = new BindingSource();
            bi.DataSource = dbcosto.costo.ToList();

            dg_mostrar.DataSource = bi;

            dg_mostrar.Columns[0].Visible = false;
            dg_mostrar.Columns[3].Visible = false;
            dg_mostrar.Columns[5].Visible = false;
            dg_mostrar.Columns[6].Visible = false;
            dg_mostrar.Columns[7].Visible = false;
            dg_mostrar.Columns[8].Visible = false;

            dg_mostrar.Columns[1].HeaderText = "Fecha";
            dg_mostrar.Columns[2].HeaderText = "Costo";
            dg_mostrar.Columns[4].HeaderText = "Producto";

            dg_mostrar.Columns[4].Width = 226;

            dg_mostrar.Columns[2].DisplayIndex = 4;
            dg_mostrar.Columns[4].DisplayIndex = 2;



            dg_mostrar.Refresh();
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
                     MessageBox.Show("Debe Ingresar Nuevo Costo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     tb_nuevo.Focus();
                    }
                }
            }
            else
            {
                costeoEntities dbp = new costeoEntities();
                var codigo_int = Convert.ToInt64(tb_codigo.Text);
                var producto = dbp.producto.FirstOrDefault(codigo => codigo.codigo_barra == codigo_int);

                costo cos = new costo();
                cos.fecha = DateTime.Today;                 
                cos.valor = Convert.ToInt16(tb_nuevo.Text);
                cos.es_actual = 0; 
                cos.producto_id = Convert.ToInt16(producto.id);
                cos.creado_el = DateTime.Today;
                cos.modificado_el = null;
                cos.eliminado_el = null;

                costeoEntities db = new costeoEntities();
                db.costo.Add(cos);
                db.SaveChanges();
                

                //*costeoEntities dbcosto = new costeoEntities();
                //*BindingSource bi = new BindingSource();
                //bi.DataSource = dbcosto.costo.ToList();

                //*bi.Add(Convert.ToString(cos.fecha));
                //*bi.Add(Convert.ToString(cos.producto_id));
                //*bi.Add(Convert.ToString(cos.valor));



                //this.dg_mostrar.Columns["id"].Visible = false;
                //this.dg_mostrar.Columns["es_actual"].Visible = false;
                //this.dg_mostrar.Columns["creado_el"].Visible = false;
                //this.dg_mostrar.Columns["modificado_el"].Visible = false;
                //this.dg_mostrar.Columns["eliminado_el"].Visible = false;
                //*dg_mostrar.DataSource = bi;
                //*dg_mostrar.Refresh();


                tb_codigo.Text = "";
                tb_nombre.Text = "";
                tb_unidad.Text = "";
                tb_marca.Text = "";
                tb_formato.Text = "";
                tb_linea.Text = "";
                tb_familia.Text = "";
                tb_nuevo.Text = "";
                tb_codigo.Focus();
                mostrar3_datagridview();



            }
        }


        private void mostrar3_datagridview()
        {
            costeoEntities dbcosto = new costeoEntities();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Producto");
            tabla.Columns.Add("Costo");
            foreach (var dato in dbcosto.costo.ToList())
            {
                DataRow row = tabla.NewRow();
                row["Fecha"] = Convert.ToString(dato.fecha);
                costeoEntities db = new costeoEntities();
                var producto = db.producto.FirstOrDefault(codigo => codigo.id == dato.producto_id);
                row["Producto"] = producto.nombre;
                row["Costo"] = Convert.ToString(dato.valor);
                tabla.Rows.Add(row);

            }
            dg_mostrar.DataSource = tabla;
            dg_mostrar.Columns["Producto"].Width = 226;
            dg_mostrar.Refresh();
        }


    }
}
