using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmacia_ped
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = false;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                // txtUsuario.Text = String.Empty;
                //if(txtUsuario == null)
                //{

                //}
                //else
                //{
                //    string texto=  txtUsuario.Text;

                //}
            }
            //para backspace          
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                txtUsuario.Text = String.Empty;
            }
            //para que admita tecla de espacio      
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                txtUsuario.Text = String.Empty;
            }
            //si no cumple nada de lo anterior que no lo deje pasar    
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = String.Empty;
                txtUsuario.ForeColor = Color.LightGray;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == String.Empty)
            {
                txtUsuario.Text = "USUARIO";

            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = String.Empty;
                txtContraseña.ForeColor = Color.LightGray;
                //  txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recuperar recuperar = new recuperar();
            recuperar.Show(); 
        }
    }
}
