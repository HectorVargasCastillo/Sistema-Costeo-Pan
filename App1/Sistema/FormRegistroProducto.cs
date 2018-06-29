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
        public void unidad_medida()

        {
            costeoEntities db = new costeoEntities();
            var lista = db.unidad_medida.ToList();
            if (lista.Count > 0)
            {
                cm_unidadmedida.DataSource = lista;
                cm_unidadmedida.DisplayMember = "codigo";
                cm_unidadmedida.ValueMember = "id";
            }

        }
        
        public void familia()

        {
            costeoEntities db = new costeoEntities();
            var lista2 = db.familia.ToList();
            if (lista2.Count > 0)
            {
                cm_familia.DataSource = lista2;
                cm_familia.DisplayMember = "nombre";
                cm_familia.ValueMember = "id";
            }

        }
        public FormRegistroProducto()
        {
            InitializeComponent();
           
            mostrar_datagridview();
            tb_codigobarra.Focus();
            unidad_medida();
            familia();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_codigobarra.Text == "")
            {
                // MessageBox.Show("Debe Ingresar Descripcion Familia");
                MessageBox.Show("Debe Ingresar codigo de barra ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_codigobarra.Focus();
            }
            if (tb_nombre.Text == "")
            {
                // MessageBox.Show("Debe Ingresar Descripcion Familia");
                MessageBox.Show("Debe Ingresar nombre  ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_codigobarra.Focus();
            }
            if (tb_marca.Text == "")
            {
                // MessageBox.Show("Debe Ingresar Descripcion Familia");
                MessageBox.Show("Debe Ingresar marca  ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_marca.Focus();
            }
            if (tb_formato.Text == "")
            {
                // MessageBox.Show("Debe Ingresar Descripcion Familia");
                MessageBox.Show("Debe Ingresar marca  ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_marca.Focus();
            }
            else
            {
                costeoEntities db = new costeoEntities();
                producto pro = new producto();


                
               
                //var linea = Convert.ToInt32(cm_linea.SelectedValue);
               // var familiaa = Convert.ToInt32(cm_familia.SelectedValue);
                pro.unidad_medida_id = Convert.ToInt32(cm_unidadmedida.SelectedValue);
                pro.nombre = tb_nombre.Text;
                pro.marca = tb_marca.Text;
                
                pro.fomato = Convert.ToInt32(tb_formato.Text); 
                pro.familia_id = Convert.ToInt32(cm_familia.SelectedValue);
                pro.creado_el = DateTime.Today;
                pro.modificado_el = null;
                pro.eliminado_el = null;
                db.producto.Add(pro);
                db.SaveChanges();
                MessageBox.Show("Registro Guardado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_codigobarra.Focus();
            }
        }

        private void mostrar_datagridview()
        {
            //var codigo_lin = Convert.ToInt16(tb_descripcionlinea.Text);
            costeoEntities dbproducto = new costeoEntities();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("Formato");
            tabla.Columns.Add("Familia");
            tabla.Columns.Add("Unidad de medida");
           

            foreach (var dato in dbproducto.producto.ToList())
            {

                if (dato.eliminado_el == null)
                {
                    DataRow row = tabla.NewRow();
                    row["Id"] = Convert.ToString(dato.id);
                    row["Nombre"] = Convert.ToString(dato.nombre);
                    row["Marca"] = Convert.ToString(dato.marca);
                    row["Formato"] = Convert.ToInt16(dato.fomato);
                    
                    
                    costeoEntities dbfamilia = new costeoEntities();
                    var familia = dbfamilia.familia.FirstOrDefault(codigo => codigo.id == dato.familia_id);
                    row["Familia"] = familia.nombre;
                    costeoEntities dbunidad_medida = new costeoEntities();
                    var unidad_medida = dbunidad_medida.unidad_medida.FirstOrDefault(codigo => codigo.id == dato.unidad_medida_id);
                    row["Unidad de medida"] = unidad_medida.descripcion;

                    tabla.Rows.Add(row);
                }

            }
            tabla.DefaultView.Sort = "[Id] DESC";
            dg_producto.DataSource = tabla;
            dg_producto.Columns["Id"].ReadOnly = true;
            dg_producto.Columns["Nombre"].ReadOnly = true;
            dg_producto.Columns["Marca"].ReadOnly = true;
            dg_producto.Columns["Formato"].ReadOnly = true;
            dg_producto.Columns["Familia"].ReadOnly = true;
            dg_producto.Columns["Unidad de medida"].ReadOnly = true;
            dg_producto.Refresh();
        }
               private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
       
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
        
        }

        private void tb_formato_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            {
                if (tb_nombre.Text == "")
                {
                    MessageBox.Show("Para Eliminar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_codigobarra.Focus();
                }
                else
                {
                    if (tb_id.Text == "")
                    {
                        MessageBox.Show("ERROR : No Permite Eliminar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tb_codigobarra.Focus();
                    }
                    else
                    {

                        if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            costeoEntities db = new costeoEntities();
                            producto pro = new producto();
                            pro = db.producto.Find(Convert.ToInt16(tb_id.Text));

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
                                tb_codigobarra.Text = "";
                                tb_id.Text = "";
                                mostrar_datagridview();
                                tb_codigobarra.Focus();
                            }
                        }
                        else
                        {
                            tb_codigobarra.Text = "";
                            tb_id.Text = "";
                            mostrar_datagridview();
                            tb_codigobarra.Focus();
                        }
                    }

                }
            }
        }

        private void dg_producto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dg_producto.CurrentRow.Cells["Id"].Value.ToString();
            tb_nombre.Text = dg_producto.CurrentRow.Cells["Nombre"].Value.ToString();

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            
            {

            if (tb_codigobarra.Text == "")
            {
                MessageBox.Show("Para Editar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_codigobarra.Focus();
            }
            else
            {
                if (tb_id.Text == "")
                {
                    MessageBox.Show("ERROR : No Permite Modificar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_codigobarra.Focus();
                }
                else
                {
                    costeoEntities db = new costeoEntities();
                        producto prod = new producto();
                        prod = db.producto.Find(Convert.ToInt16(tb_id.Text));

                        {

            if (tb_codigobarra.Text == "")
                        {
                            MessageBox.Show("Para Editar, Debe Pinchar Celda de Grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                tb_codigobarra.Focus();
                        }
                        else
                        {
                            if (tb_id.Text == "")
                            {
                                MessageBox.Show("ERROR : No Permite Modificar Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tb_codigobarra.Focus();
                            }
                            else
                            {
                                costeoEntities dbcamila = new costeoEntities();
                                producto pro = new producto();
                                pro = db.producto.Find(Convert.ToInt16(tb_id.Text));

                                if (pro == null)
                                {
                                    MessageBox.Show("ERROR : No Permite Modificar Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                                else
                                {
                                    if (pro.codigo_barra != Convert.ToInt16(tb_codigobarra.Text))
                                    {
                                        pro.codigo_barra = Convert.ToInt16(tb_codigobarra.Text);
                                        //pro.nombre = Convert.ToInt16(tb_nombre.Text);
                                        //pro.marca = Convert.ToInt16(tb_marca.Text);
                                        //pro.fomato = Convert.toInt16(tb_formato.Text);
                                        

                                        var codigo_fam = Convert.ToInt16(cm_familia.SelectedValue);
                                        var familia = db.familia.FirstOrDefault(codigol => codigol.id == codigo_fam);
                                        pro.familia = familia;
                                            var codigo_udm = Convert.ToInt16(cm_unidadmedida.SelectedValue);
                                            var unidad_medida = db.unidad_medida.FirstOrDefault(codigol => codigol.id == codigo_udm);
                                            pro.unidad_medida = unidad_medida;
                                            
                                           pro.modificado_el = DateTime.Today;
                                           db.SaveChanges();
                                           MessageBox.Show("Registro Modificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                           tb_codigobarra.Text = "";
                                           tb_id.Text = "";
                                           mostrar_datagridview();
                                           tb_codigobarra.Focus();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No Modificó Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        tb_codigobarra.Text = "";
                                        tb_id.Text = "";
                                        mostrar_datagridview();
                                        tb_codigobarra.Focus();
                                    }
                                }
                            }

                        }
                        }
                    }
                }
            }
        }

        private void dg_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_marca_TextChanged(object sender, EventArgs e)
        {

        }
    }

}



