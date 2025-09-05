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
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        ClsArticulo a = new ClsArticulo();

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
            frmMenu fm = new frmMenu();
            fm.Show();
        }

        public void EstadoInicial()
        {
            txtcodigo.TabIndex = 0;
            txtdescripcion.Enabled = false;
            txtpcompra.Enabled = false;
            txtpventa.Enabled = false;
            txtexistencia.Enabled = false;
            txtminimo.Enabled = false;
            txtmaximo.Enabled = false;
            txtcodigoproveedor.Enabled = false;
            btnguardar.Enabled = false;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
        }

        public void ActualizaDgArticulos()
        {
            dgarticulos.DataSource = a.Listado();
        }
       
        private void frmArticulos_Load_2(object sender, EventArgs e)
        {
            EstadoInicial();
            ActualizaDgArticulos();
            dgarticulos.AllowUserToAddRows = false;
        }
        public void habilita()
        {
            txtdescripcion.Enabled = true;
            txtpcompra.Enabled = true;
            txtpventa.Enabled = true;
            txtexistencia.Enabled = true;
            txtminimo.Enabled = true;
            txtmaximo.Enabled = true;
            txtcodigoproveedor.Enabled = true;
        }



        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable dt = a.Consultar(int.Parse(txtcodigo.Text));
                if (dt.Rows.Count > 0)
                {
                    txtdescripcion.Text = dt.Rows[0][1].ToString();
                    txtpcompra.Text = dt.Rows[0][2].ToString();
                    txtpventa.Text = dt.Rows[0][3].ToString();
                    txtexistencia.Text = dt.Rows[0][4].ToString();
                    txtminimo.Text = dt.Rows[0][5].ToString();
                    txtmaximo.Text = dt.Rows[0][6].ToString();
                    txtcodigoproveedor.Text = dt.Rows[0][7].ToString();
                    habilita();
                    txtcodigo.Enabled = false;
                    btnmodificar.Enabled = true;
                    btneliminar.Enabled = true;
                }
                else
                {
                    habilita();
                    txtdescripcion.Focus();
                    txtcodigo.Enabled = false;
                    btnguardar.Enabled = true;
                }
            }
        }
        
        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtpcompra.Focus();

        }
        private void txtpcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtpventa.Focus();
        }
    
        private void txtpventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtexistencia.Focus();
        }
        private void txtexistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtminimo.Focus();
        }
        private void txtminimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtmaximo.Focus();
        }
        private void txtmaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) txtcodigoproveedor.Focus();
        }
        
       private void txtcodigopproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                if (btnguardar.Enabled == true) btnguardar.Focus(); else btnmodificar.Focus();
        }
   
        private void dgarticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        public void limpiar()
        {
            txtcodigo.Clear();
            txtdescripcion.Clear();
            txtpcompra.Clear();
            txtpventa.Clear();
            txtexistencia.Clear();
            txtminimo.Clear();
            txtmaximo.Clear();
            txtcodigoproveedor.Clear();
        
        }

        public void deshabilitar()
        {
           
            txtdescripcion.Enabled = false;
            txtpcompra.Enabled = false;
            txtpventa.Enabled = false;
            txtexistencia.Enabled = false;
            txtminimo.Enabled = false;
            txtmaximo.Enabled = false;
            txtcodigoproveedor.Enabled = false;
        }
        
        private void btnguardar_Click(object sender, EventArgs e)
        {
            float pcompra, pventa, existencia, minimo, maximo;
            int codProveedor;

            // Intentamos convertir los campos numéricos, y si alguno falla, mostramos el mensaje de error
            if (!float.TryParse(txtpcompra.Text, out pcompra) ||
                !float.TryParse(txtpventa.Text, out pventa) ||
                !float.TryParse(txtexistencia.Text, out existencia) ||
                !float.TryParse(txtminimo.Text, out minimo) ||
                !float.TryParse(txtmaximo.Text, out maximo) ||
                !int.TryParse(txtcodigoproveedor.Text, out codProveedor))
            {
                MessageBox.Show("Tipo de dato no válido");
                return; // No continúa con el guardado
            }

            // Si todo es válido, asignamos los valores
            a.codigo = txtcodigo.Text;
            a.descripcion = txtdescripcion.Text;
            a.pcompra = pcompra;
            a.pventa = pventa;
            a.existencia = existencia;
            a.mínimo = minimo;
            a.máximo = maximo;
            a.códigoproveedor = codProveedor;

            if (a.Guardar())
            {
                dgarticulos.DataSource = a.Listado();
                MessageBox.Show("Guardado con éxito");
                btnguardar.Enabled = false;
                limpiar();
                deshabilitar();
                txtcodigo.Enabled = true;
                txtcodigo.Focus();
            }
        }


      
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            a.codigo = txtcodigo.Text;
            a.descripcion = txtdescripcion.Text;
            a.pcompra = float.Parse(txtpcompra.Text);
            a.pventa = float.Parse(txtpventa.Text);
            a.existencia = float.Parse(txtexistencia.Text);
            a.mínimo = float.Parse(txtminimo.Text);
            a.máximo = float.Parse(txtmaximo.Text);
            a.códigoproveedor = int.Parse(txtcodigoproveedor.Text);
            if (a.Modificar())
            {
                dgarticulos.DataSource = a.Listado();
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
            a.codigo = txtcodigo.Text;
            int codigoInt;
            if (int.TryParse(a.codigo, out codigoInt))
            {
                if (a.Eliminar(codigoInt))
                {
                    dgarticulos.DataSource = a.Listado();
                    MessageBox.Show("Eliminado con éxito");
                    btnmodificar.Enabled = false;
                    btneliminar.Enabled = false;
                    limpiar();
                    deshabilitar();
                    txtcodigo.Enabled = true;
                    txtcodigo.Focus();
                }

                   
            }

            else
            {
                MessageBox.Show("El código ingresado no es un número válido.");
            }
        }

       private void dgarticulos_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           txtcodigo.Text = dgarticulos.CurrentRow.Cells[0].Value.ToString();
           txtdescripcion.Text = dgarticulos.CurrentRow.Cells[1].Value.ToString();
           txtpcompra.Text = dgarticulos.CurrentRow.Cells[2].Value.ToString();
           txtpventa.Text = dgarticulos.CurrentRow.Cells[3].Value.ToString();
           txtexistencia.Text = dgarticulos.CurrentRow.Cells[4].Value.ToString();
           txtminimo.Text = dgarticulos.CurrentRow.Cells[5].Value.ToString();
           txtmaximo.Text = dgarticulos.CurrentRow.Cells[6].Value.ToString();
           txtcodigoproveedor.Text = dgarticulos.CurrentRow.Cells[7].Value.ToString();
           habilita();
           btnmodificar.Enabled = true;
           btneliminar.Enabled = true;
           txtcodigo.Enabled = false;
           txtdescripcion.Focus();

       }
         
        

    }
}

