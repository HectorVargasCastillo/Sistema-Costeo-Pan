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
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new FormReporteKilo();
            childForm = new FormReporteKilo();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void formulario2ListarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngresoLineaProducto childForm = new FormIngresoLineaProducto();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }


        private void FormFamilia_Click(object sender, EventArgs e)
        {
            

        }
        private void menuEjemploToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteDiario childForm = new FormReporteDiario();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();

        }

        private void FormUniMed_Click(object sender, EventArgs e)
        {
            FormUniMed childForm = new FormUniMed();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void FormIngCosto_Click(object sender, EventArgs e)
        {
           
        }

        private void FormIngPrecio_Click(object sender, EventArgs e)
        {
           
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFamilia childForm = new FormFamilia();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void familiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormFamilia childForm = new FormFamilia();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void unidadMedidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUniMed childForm = new FormUniMed();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void ingresoCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUniMed childForm = new FormUniMed();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void ingresoPreciosVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUniMed childForm = new FormUniMed();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void ingresoCostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngCosto childForm = new FormIngCosto();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void ingresoPreciosVentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormIngPrecio childForm = new FormIngPrecio();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void produccionDiariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngPrecio childForm = new FormIngPrecio();
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
