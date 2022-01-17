using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDados1
{
    public partial class formFuncionários : Form
    {
        public formFuncionários()
        {
            InitializeComponent();
        }

        private void funcionáriosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionáriosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdalunosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdalunosDataSet.Funcionários'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionáriosTableAdapter.Fill(this.bdalunosDataSet.Funcionários);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formNotas f1 = new formNotas();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDisci f2 = new formDisci();
            f2.ShowDialog();
        }
    }
}
