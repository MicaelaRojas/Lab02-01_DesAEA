using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string[] usuarios = { "usuario", "Micaela", "usuario" };
            string[] contraseñas = { "contra"};

            
            string value1 = txtUsuario.Text;
            string value2 = txtPassword.Text;


            var index1 = Array.FindIndex(usuarios, u => u == value1); 
            if (!(index1 == -1))
            {
                var index2 = Array.FindIndex(contraseñas, u => u == value2);
                if (!(index2 == -1))
                {
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
