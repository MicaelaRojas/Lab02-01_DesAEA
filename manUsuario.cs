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
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string direccion = txtDireccion.Text;
            string fecha = dtpFecha.Text;

            dgvUsuarios.Rows.Add( dni, nombre, apellido, telefono, email, direccion, fecha);
        }
    }
}
