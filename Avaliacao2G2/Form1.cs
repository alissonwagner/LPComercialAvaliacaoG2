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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Professores professores = new Professores();
            professores.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Show();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = new Disciplina();
            disciplina.Show();
        }

        private void alocaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alocado alocado = new Alocado();
            alocado.Show();
        }

        private void disciplinasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscaDisciplina busca = new BuscaDisciplina();
            busca.Show();
        }
    }
}
