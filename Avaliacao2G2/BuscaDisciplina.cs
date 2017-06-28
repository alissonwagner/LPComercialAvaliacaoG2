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
    public partial class BuscaDisciplina : Form
    {
        public BuscaDisciplina()
        {
            InitializeComponent();
        }

        private void cursoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseAvaliacao2DataSet);

        }

        private void BuscaDisciplina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseAvaliacao2DataSet.Disciplina' table. You can move, or remove it, as needed.
            this.disciplinaTableAdapter.Fill(this.databaseAvaliacao2DataSet.Disciplina);
            // TODO: This line of code loads data into the 'databaseAvaliacao2DataSet.Curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.databaseAvaliacao2DataSet.Curso);

        }

        private void oleDbDataAdapter1_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbxCurso.SelectedValue != null)
            {

                oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM Disciplina where curso =" +

               cbxCurso.SelectedValue + ";";

                if (oleDbDataAdapter1.Fill(databaseAvaliacao2DataSet, "Disciplina") != 0)

                {

                    databaseAvaliacao2DataSet.Clear();

                    oleDbDataAdapter1.Fill(databaseAvaliacao2DataSet, "Disciplina");
                    this.cursoTableAdapter.Fill(this.databaseAvaliacao2DataSet.Curso);


                    dgrDisciplinas.SetDataBinding(databaseAvaliacao2DataSet, "Disciplina");

                    MessageBox.Show("Disciplinas do curso " + cbxCurso.Text + " encontradas!");

                }

                else

                    MessageBox.Show("Disciplinas do curso " + cbxCurso.Text + " NÃO encontradas!");

            }

            else

                MessageBox.Show("Selecione uma disciplina a pesquisar!!!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
