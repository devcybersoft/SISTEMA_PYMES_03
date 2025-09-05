using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
namespace SISTEMA_PYMES_03
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        ClsCliente c = new ClsCliente();
       

        void validarNumeros(KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (e.KeyChar == 8 || char.IsNumber(e.KeyChar)) // sin punto decimal-> || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            { e.Handled = false; }
            else e.Handled = true;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenu fm = new frmMenu();
            fm.Show();
        }

        public void EstadoInicial()
        {
            txtcodigo.TabIndex = 0;
            txtrfc.Enabled = false;
            txtnombre.Enabled = false;
            txtdireccion.Enabled = false;
            txttelefono.Enabled = false;
            txtemail.Enabled = false;
            btnguardar.Enabled = false;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
        }

        public void ActualizaDgClientes()
        {
            dgclientes.DataSource = c.Listado();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            ActualizaDgClientes();
            dgclientes.AllowUserToAddRows = false;
        }

        public void habilita()
        {
            txtrfc.Enabled = true;
            txtnombre.Enabled = true;
            txtdireccion.Enabled = true;
            txttelefono.Enabled = true;
            txtemail.Enabled = true;
        }

        private void dgclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgclientes.CurrentRow.Cells[0].Value.ToString();
            txtrfc.Text = dgclientes.CurrentRow.Cells[1].Value.ToString();
            txtnombre.Text = dgclientes.CurrentRow.Cells[2].Value.ToString();
            txtdireccion.Text = dgclientes.CurrentRow.Cells[3].Value.ToString();
            txttelefono.Text = dgclientes.CurrentRow.Cells[4].Value.ToString();
            txtemail.Text = dgclientes.CurrentRow.Cells[5].Value.ToString();
            habilita();
            txtcodigo.Enabled = false;
            txtrfc.Focus();
        }
        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable dt = c.Consultar(int.Parse(txtcodigo.Text));
                if (dt.Rows.Count > 0)
                {
                    txtrfc.Text = dt.Rows[0][1].ToString();
                    txtnombre.Text = dt.Rows[0][2].ToString();
                    txtdireccion.Text = dt.Rows[0][3].ToString();
                    txttelefono.Text = dt.Rows[0][4].ToString();
                    txtemail.Text = dt.Rows[0][5].ToString();
                    habilita();
                    txtcodigo.Enabled = false;
                    btnmodificar.Enabled = true;
                    btneliminar.Enabled = true;
                }
                else
                {
                    habilita();
                    txtrfc.Focus();
                    txtcodigo.Enabled = false;
                    btnguardar.Enabled = true;
                }
            }
        }
        private void txtrfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtnombre.Focus();
        }
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtdireccion.Focus();
        }
        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txttelefono.Focus();
        }       
        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtemail.Focus();
        }
        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                if (btnguardar.Enabled == true) btnguardar.Focus(); else btnmodificar.Focus();
        }

       

       
        
        public void limpiar()
        {
            txtcodigo.Clear();
            txtrfc.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtemail.Clear();
        }

        public void deshabilitar()
        {
            txtrfc.Enabled = false;
            txtnombre.Enabled = false;
            txtdireccion.Enabled = false;
            txttelefono.Enabled = false;
            txtemail.Enabled = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            c.codigo = int.Parse(txtcodigo.Text);
            c.rfc = txtrfc.Text;
            c.nombre = txtnombre.Text;
            c.direccion = txtdireccion.Text;
            c.telefono = txttelefono.Text;
            c.email = txtemail.Text;
            if (c.Guardar())
            {
                dgclientes.DataSource = c.Listado();
                MessageBox.Show("Guardado con exito");
                btnguardar.Enabled = false;
                limpiar();
                deshabilitar();
                txtcodigo.Enabled = true;
                txtcodigo.Focus();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            c.codigo = int.Parse(txtcodigo.Text);
            c.rfc = txtrfc.Text;
            c.nombre = txtnombre.Text;
            c.direccion = txtdireccion.Text;
            c.telefono = txttelefono.Text;
            c.email = txtemail.Text;
            if (c.Modificar())
            {
                dgclientes.DataSource = c.Listado();
                MessageBox.Show("Modificado con exito");
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
                limpiar();
                deshabilitar();
                txtcodigo.Enabled = true;
                txtcodigo.Focus();
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            c.codigo = int.Parse(txtcodigo.Text);
            if (c.Eliminar(c.codigo))
            {
                dgclientes.DataSource = c.Listado();
                MessageBox.Show("Eiminado con exito");
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
                limpiar();
                deshabilitar();
                txtcodigo.Enabled = true;
                txtcodigo.Focus();
            }
        }

        private void frmClientes_Load_1(object sender, EventArgs e)
        {
            EstadoInicial(); // desactiva textbox y botones
            ActualizaDgClientes(); // cargar los clientes registrados
            dgclientes.AllowUserToAddRows = false; // quitar la ultima fila en blanco
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}