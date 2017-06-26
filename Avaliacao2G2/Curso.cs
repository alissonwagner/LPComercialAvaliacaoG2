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
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
        }

        private void cursoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseAvaliacao2DataSet);

        }

        private void cursoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cursoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseAvaliacao2DataSet);

        }

        private void Curso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseAvaliacao2DataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this.databaseAvaliacao2DataSet.Professor);
            // TODO: This line of code loads data into the 'databaseAvaliacao2DataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.databaseAvaliacao2DataSet.Curso);

        }
    }
}
