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
    public partial class formNotas : Form
    {
        public formNotas()
        {
            InitializeComponent();
        }

        private void notasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdalunosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdalunosDataSet.Notas'. Você pode movê-la ou removê-la conforme necessário.
            this.notasTableAdapter.Fill(this.bdalunosDataSet.Notas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTurmas f1 = new formTurmas();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formFuncionários f2 = new formFuncionários();
            f2.ShowDialog();
        }
    }
}
