using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _422654
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 frmb = new Form2();
            //AO CLICAR NA LINHA CHAMA OS DADOS DO BANCO DE DADOS
            frmb.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmb.comboBox1.SelectedIndex = frmb.comboBox1.FindString(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            frmb.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //COLOCA O BOTÃO ADD  EM DISABLE
            //frmb.alterabotoes(2);
            //E ABRE A JENELA
            frmb.ShowDialog();
        }
    }
}
