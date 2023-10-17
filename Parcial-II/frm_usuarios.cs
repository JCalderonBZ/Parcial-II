using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_II
{
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnModificarUsuario.Text == "Modificar"){
                btnAgregarUsuario.Text = "Guardar";
                btnEliminarUsuario.Text = "Cancelar";

            }
            else{//guardar

                btnAgregarUsuario.Text = "Nuevo";
                btnModificarUsuario.Text = "Modificar";
            }
        }

          

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnAgregarUsuario.Text == "Nuevo") {
                btnAgregarUsuario.Text = "Guardar";
                btnAgregarUsuario.Text = "Cancelar";

            }else {//guardar


                btnAgregarUsuario.Text = "Nuevo";
                btnModificarUsuario.Text = "Modificar";

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fc = new Form1();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }
    }
}