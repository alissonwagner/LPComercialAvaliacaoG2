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
    public partial class Alocado : Form
    {
        public Alocado()
        {
            InitializeComponent();
        }

        private void alocadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alocadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseAvaliacao2DataSet);

        }

        private void Alocado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseAvaliacao2DataSet.Disciplina' table. You can move, or remove it, as needed.
            this.disciplinaTableAdapter.Fill(this.databaseAvaliacao2DataSet.Disciplina);
            // TODO: This line of code loads data into the 'databaseAvaliacao2DataSet.DisciplinaAlocado' table. You can move, or remove it, as needed.
            this.disciplinaAlocadoTableAdapter.Fill(this.databaseAvaliacao2DataSet.DisciplinaAlocado);
            // TODO: This line of code loads data into the 'databaseAvaliacao2DataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this.databaseAvaliacao2DataSet.Professor);
            // TODO: This line of code loads data into the 'databaseAvaliacao2DataSet.Alocado' table. You can move, or remove it, as needed.
            this.alocadoTableAdapter.Fill(this.databaseAvaliacao2DataSet.Alocado);

        }
    }
}
