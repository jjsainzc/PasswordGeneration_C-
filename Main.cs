using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGeneration
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(this.Width, this.Height);

            longitud.Value = 8;
            longitud.Maximum = 64;
            longitud.Minimum = 8;

            cantidad.Value = 5;
            cantidad.Maximum = 100;
            cantidad.Minimum = 1;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
        }

        private void generar_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            StringBuilder sb = new StringBuilder();

            if (mayusculas.Checked)
            {
                sb.Append("M");
            }
            if (minusculas.Checked)
            {
                sb.Append("m");
            }
            if (numeros.Checked)
            {
                sb.Append("n");
            }
            if (especiales.Checked)
            {
                sb.Append("e");
            }

            int cantidad = Convert.ToInt32(this.cantidad.Value);
            int longitud = Convert.ToInt32(this.longitud.Value);

            String opc = sb.ToString();

            for (int i = 1; i <= cantidad; i++)
            {
                resultado.AppendText(PasswordGenerator.getPassword(longitud, opc));
                resultado.AppendText(Environment.NewLine);

            }
        }
    }
}
