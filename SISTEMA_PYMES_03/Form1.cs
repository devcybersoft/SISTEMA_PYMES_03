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
    public partial class Form1 : Form
    {
        private bool showPassword = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaccesar_Click_1(object sender, EventArgs e)
        {
            frmMenu fm = new frmMenu();
            fm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtcontraseña.Focus();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                txtcontraseña.PasswordChar = '\0';
                pictureBox1.Image = SISTEMA_PYMES_03.Properties.Resources.VerContraseña;
            }
            else
            {
                txtcontraseña.PasswordChar = '*';
                pictureBox1.Image = SISTEMA_PYMES_03.Properties.Resources.OcultarContraseña;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
