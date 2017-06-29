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
    public partial class BuscaProfessores : Form
    {
        public BuscaProfessores()
        {
            InitializeComponent();
        }

        private void BuscaProfessores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseAvaliacao2DataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this.databaseAvaliacao2DataSet.Professor);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tbxAnoSemestre.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (tbxAnoSemestre.Text != "")
            {
                tbxAnoSemestre.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                oleDbDataAdapter1.SelectCommand.CommandText = "SELECT Professor.* FROM Professor " +
                    " INNER JOIN Alocado ON Professor.codigop = Alocado.professor " +
               "WHERE Alocado.anoSemestre ='" + tbxAnoSemestre.Text + "';";

                if (oleDbDataAdapter1.Fill(databaseAvaliacao2DataSet, "Professor") != 0)

                {

                    databaseAvaliacao2DataSet.Clear();

                    oleDbDataAdapter1.Fill(databaseAvaliacao2DataSet, "Professor");

                    dgrProfessores.SetDataBinding(databaseAvaliacao2DataSet, "Professor");

                    MessageBox.Show("Professores alocados em " + tbxAnoSemestre.Text + " encontrados!");

                }

                else

                    MessageBox.Show("Não há professores alocados em  " + tbxAnoSemestre.Text);

            }

            else

                MessageBox.Show("Digite um ano/semestre a pesquisar!!!");
        }
    }
}
