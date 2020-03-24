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
    public partial class pantalla : Form
    {
        public pantalla()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void panel_pantalla_c_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void PANTALLA_PANEL(object FORM11)
        {
            if(this.panel_pantalla.Controls.Count>0)
            
                this.panel_pantalla.Controls.RemoveAt(0);
                Form scream = FORM11 as Form;
                scream.TopLevel = false;
            scream.Dock = DockStyle.Fill;
                this.panel_pantalla.Controls.Add(scream);
                this.panel_pantalla.Tag = scream;
                scream.Show();
            
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            PANTALLA_PANEL(new Empleados());
        }
    }
}
