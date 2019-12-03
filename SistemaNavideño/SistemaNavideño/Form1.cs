using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNavideño
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "AdminTarjetas" && textBox2.Text == "navidad")
            {
                FormGerente adm= new FormGerente();
                adm.ShowDialog();
            }
            else if (textBox1.Text == "EmpTarjetas" && textBox2.Text == "tarjetas")
            {
                FormEmpleado femp = new FormEmpleado();
                femp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error en el usuario o contraseña");
            }
        }
    }
}
