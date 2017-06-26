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
    public partial class Professores : Form
    {
        public Professores()
        {
            InitializeComponent();
        }

        private void professorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseAvaliacao2DataSet);

        }

        private void Professores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseAvaliacao2DataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this.databaseAvaliacao2DataSet.Professor);

        }
    }
}
