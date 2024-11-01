using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPacientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por Oscar Alvardo");
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtFechaNacimiento.Clear();
            txtMotivoConsulta.Clear();
            cmbGenero.Text = string.Empty;
            cmbDptMedico.Text = string.Empty;   
            cbxSi.Checked = false;
            cbxNo.Checked = false;
         
   
        }

        private void cbxSi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSi.Checked)
            {
                cbxNo.Enabled = false;
            } else
            {
                cbxNo.Enabled = true;
            }
        }

        private void cbxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNo.Checked)
            {
                cbxSi.Enabled = false;
            } else
            {
                cbxSi.Enabled = true;
            }
        }
    }
}
