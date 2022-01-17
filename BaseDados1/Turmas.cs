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
    public partial class formTurmas : Form
    {
        public formTurmas()
        {
            InitializeComponent();
        }

        private void turmasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.turmasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdalunosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdalunosDataSet.Turmas'. Você pode movê-la ou removê-la conforme necessário.
            this.turmasTableAdapter.Fill(this.bdalunosDataSet.Turmas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAlunos f1 = new formAlunos();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formNotas f2 = new formNotas();
            f2.ShowDialog();
        }
    }
}
