using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2G2
{
    public partial class Disciplina : Form
    {
        public Disciplina()
        {
            InitializeComponent();
        }

        private void disciplinaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplinaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseAvaliacao2DataSet);

        }

        private void Disciplina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseAvaliacao2DataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.databaseAvaliacao2DataSet.Curso);
            // TODO: This line of code loads data into the 'databaseAvaliacao2DataSet.Disciplina' table. You can move, or remove it, as needed.
            this.disciplinaTableAdapter.Fill(this.databaseAvaliacao2DataSet.Disciplina);

        }
    }
}
