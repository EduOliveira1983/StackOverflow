using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _423320
{
    public partial class PDVForm : Form
    {
        private string operador;

        public PDVForm(string Operador)
        {
            operador = Operador;
            InitializeComponent();
        }

        private void PDVForm_Load(object sender, EventArgs e)
        {            
            MessageBox.Show("Olá " + operador, "Bem-Vindo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
