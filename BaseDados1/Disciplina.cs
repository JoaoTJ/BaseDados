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
    public partial class formDisci : Form
    {
        public formDisci()
        {
            InitializeComponent();
        }

        private void disciplinasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplinasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdalunosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdalunosDataSet.Disciplinas'. Você pode movê-la ou removê-la conforme necessário.
            this.disciplinasTableAdapter.Fill(this.bdalunosDataSet.Disciplinas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formFuncionários f1 = new formFuncionários();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAlunos f2 = new formAlunos();
            f2.ShowDialog();
        }
    }
}
