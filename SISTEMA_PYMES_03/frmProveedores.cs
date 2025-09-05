using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISTEMA_PYMES_03
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        ClsProveedor p = new ClsProveedor();

        void validarNumeros(KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (e.KeyChar == 8 || char.IsNumber(e.KeyChar)) // sin punto decimal-> || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            { e.Handled = false; }
            else e.Handled = true;
        }

       private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        public void ActualizaDgProveedores()
        {
            dgproveedores.DataSource = p.Listado();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            ActualizaDgProveedores();
            dgproveedores.AllowUserToAddRows = false;
        }

        public void habilita()
        {
            txtrfc.Enabled = true;
            txtnombre.Enabled = true;
            txtdireccion.Enabled = true;
            txttelefono.Enabled = true;
            txtemail.Enabled = true;
        }

        

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable dt = p.Consultar(int.Parse(txtcodigo.Text));
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
        private void dgproveedores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
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

            private void btnguardar_Click_1(object sender, EventArgs e)
        {
            p.codigo = int.Parse(txtcodigo.Text);
            p.rfc = txtrfc.Text;
            p.nombre = txtnombre.Text;
            p.direccion = txtdireccion.Text;
            p.telefono = txttelefono.Text;
            p.email = txtemail.Text;
            if (p.Guardar())
            {
                dgproveedores.DataSource = p.Listado();
                MessageBox.Show("Guardado con exito");
                btnguardar.Enabled = false;
                limpiar();
                deshabilitar();
                txtcodigo.Enabled = true;
                txtcodigo.Focus();
            }
        }

       private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            p.codigo = int.Parse(txtcodigo.Text);
            p.rfc = txtrfc.Text;
            p.nombre = txtnombre.Text;
            p.direccion = txtdireccion.Text;
            p.telefono = txttelefono.Text;
            p.email = txtemail.Text;
            if (p.Modificar())
            {
                dgproveedores.DataSource = p.Listado();
                MessageBox.Show("Modificado con exito");
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
                limpiar();
                deshabilitar();
                txtcodigo.Enabled = true;
                txtcodigo.Focus();
            }
        }

       private void btneliminar_Click_1(object sender, EventArgs e)
        {
            p.codigo = int.Parse(txtcodigo.Text);
            if (p.Eliminar(p.codigo))
            {
                dgproveedores.DataSource = p.Listado();
                MessageBox.Show("Eiminado con exito");
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
                limpiar();
                deshabilitar();
                txtcodigo.Enabled = true;
                txtcodigo.Focus();
            }
        }

        private void frmProveedores_Load_1(object sender, EventArgs e)
        {
            EstadoInicial(); // desactiva textbox y botones
            ActualizaDgProveedores(); // cargar los clientes registrados
            dgproveedores.AllowUserToAddRows = false; // quitar la ultima fila en blanco
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

        private void dgproveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgproveedores.CurrentRow.Cells[0].Value.ToString();
            txtrfc.Text = dgproveedores.CurrentRow.Cells[1].Value.ToString();
            txtnombre.Text = dgproveedores.CurrentRow.Cells[2].Value.ToString();
            txtdireccion.Text = dgproveedores.CurrentRow.Cells[3].Value.ToString();
            txttelefono.Text = dgproveedores.CurrentRow.Cells[4].Value.ToString();
            txtemail.Text = dgproveedores.CurrentRow.Cells[5].Value.ToString();
            habilita();
            txtcodigo.Enabled = false;
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            txtrfc.Focus();
        }
    }
}
