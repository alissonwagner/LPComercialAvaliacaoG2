namespace Avaliacao2G2
{
    partial class BuscaDisciplina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.databaseAvaliacao2DataSet = new Avaliacao2G2.DatabaseAvaliacao2DataSet();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.CursoTableAdapter();
            this.tableAdapterManager = new Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.TableAdapterManager();
            this.dgrDisciplinas = new System.Windows.Forms.DataGrid();
            this.disciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinaTableAdapter = new Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.DisciplinaTableAdapter();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAvaliacao2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDisciplinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar disciplinas por curso:";
            // 
            // cbxCurso
            // 
            this.cbxCurso.DataSource = this.cursoBindingSource;
            this.cbxCurso.DisplayMember = "nomec";
            this.cbxCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(268, 25);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(371, 32);
            this.cbxCurso.TabIndex = 1;
            this.cbxCurso.ValueMember = "codigoc";
            this.cbxCurso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(548, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // databaseAvaliacao2DataSet
            // 
            this.databaseAvaliacao2DataSet.DataSetName = "DatabaseAvaliacao2DataSet";
            this.databaseAvaliacao2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.databaseAvaliacao2DataSet;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlocadoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursoTableAdapter = this.cursoTableAdapter;
            this.tableAdapterManager.DisciplinaAlocadoTableAdapter = null;
            this.tableAdapterManager.DisciplinaTableAdapter = this.disciplinaTableAdapter;
            this.tableAdapterManager.ProfessorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgrDisciplinas
            // 
            this.dgrDisciplinas.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dgrDisciplinas.BackColor = System.Drawing.Color.DarkGray;
            this.dgrDisciplinas.CaptionBackColor = System.Drawing.Color.White;
            this.dgrDisciplinas.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgrDisciplinas.CaptionForeColor = System.Drawing.Color.Navy;
            this.dgrDisciplinas.CaptionText = "Busca de disciplinas";
            this.dgrDisciplinas.DataMember = "";
            this.dgrDisciplinas.DataSource = this.disciplinaBindingSource;
            this.dgrDisciplinas.ForeColor = System.Drawing.Color.Black;
            this.dgrDisciplinas.GridLineColor = System.Drawing.Color.Black;
            this.dgrDisciplinas.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgrDisciplinas.HeaderBackColor = System.Drawing.Color.Silver;
            this.dgrDisciplinas.HeaderForeColor = System.Drawing.Color.Black;
            this.dgrDisciplinas.LinkColor = System.Drawing.Color.Navy;
            this.dgrDisciplinas.Location = new System.Drawing.Point(12, 153);
            this.dgrDisciplinas.Name = "dgrDisciplinas";
            this.dgrDisciplinas.ParentRowsBackColor = System.Drawing.Color.White;
            this.dgrDisciplinas.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dgrDisciplinas.RowHeadersVisible = false;
            this.dgrDisciplinas.SelectionBackColor = System.Drawing.Color.Navy;
            this.dgrDisciplinas.SelectionForeColor = System.Drawing.Color.White;
            this.dgrDisciplinas.Size = new System.Drawing.Size(627, 237);
            this.dgrDisciplinas.TabIndex = 3;
            // 
            // disciplinaBindingSource
            // 
            this.disciplinaBindingSource.DataMember = "Disciplina";
            this.disciplinaBindingSource.DataSource = this.databaseAvaliacao2DataSet;
            // 
            // disciplinaTableAdapter
            // 
            this.disciplinaTableAdapter.ClearBeforeFill = true;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        codigod, nomed, curso\r\nFROM            Disciplina";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Disciplina` (`nomed`, `curso`) VALUES (?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("nomed", System.Data.OleDb.OleDbType.VarWChar, 0, "nomed"),
            new System.Data.OleDb.OleDbParameter("curso", System.Data.OleDb.OleDbType.Integer, 0, "curso")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE `Disciplina` SET `nomed` = ?, `curso` = ? WHERE ((`codigod` = ?) AND ((? =" +
    " 1 AND `nomed` IS NULL) OR (`nomed` = ?)) AND ((? = 1 AND `curso` IS NULL) OR (`" +
    "curso` = ?)))";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("nomed", System.Data.OleDb.OleDbType.VarWChar, 0, "nomed"),
            new System.Data.OleDb.OleDbParameter("curso", System.Data.OleDb.OleDbType.Integer, 0, "curso"),
            new System.Data.OleDb.OleDbParameter("Original_codigod", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codigod", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_nomed", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "nomed", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_nomed", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nomed", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_curso", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "curso", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_curso", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "curso", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `Disciplina` WHERE ((`codigod` = ?) AND ((? = 1 AND `nomed` IS NULL) " +
    "OR (`nomed` = ?)) AND ((? = 1 AND `curso` IS NULL) OR (`curso` = ?)))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_codigod", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codigod", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_nomed", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "nomed", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_nomed", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nomed", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_curso", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "curso", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_curso", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "curso", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Disciplina", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("codigod", "codigod"),
                        new System.Data.Common.DataColumnMapping("nomed", "nomed"),
                        new System.Data.Common.DataColumnMapping("curso", "curso")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            this.oleDbDataAdapter1.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.oleDbDataAdapter1_RowUpdated);
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\DatabaseAvaliacao2.m" +
    "db";
            // 
            // BuscaDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 402);
            this.Controls.Add(this.dgrDisciplinas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.label1);
            this.Name = "BuscaDisciplina";
            this.Text = "BuscaDisciplina";
            this.Load += new System.EventHandler(this.BuscaDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseAvaliacao2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDisciplinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.Button btnBuscar;
        private DatabaseAvaliacao2DataSet databaseAvaliacao2DataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private DatabaseAvaliacao2DataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private DatabaseAvaliacao2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseAvaliacao2DataSetTableAdapters.DisciplinaTableAdapter disciplinaTableAdapter;
        private System.Windows.Forms.DataGrid dgrDisciplinas;
        private System.Windows.Forms.BindingSource disciplinaBindingSource;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
    }
}