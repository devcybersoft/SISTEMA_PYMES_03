using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISTEMA_PYMES_03
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // creamos un objeto que represente frmClientes
            frmClientes fc = new frmClientes();
            // muestra el formulario (frmClientes)
            fc.Show();
            // oculta este formulario (frmMenu)
            this.Hide(); 
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // creamos un objeto que represente frmProveedores
            frmProveedores fa = new frmProveedores();
            // muestra el formulario (frmProveedores)
            fa.Show();
            // oculta este formulario (frmMenu)
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos fa = new frmArticulos();
            fa.Show();
            this.Hide();
        }
    }
}
