namespace Avaliacao2G2
{
    partial class BuscaProfessores
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
            this.tbxAnoSemestre = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgrProfessores = new System.Windows.Forms.DataGrid();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseAvaliacao2DataSet = new Avaliacao2G2.DatabaseAvaliacao2DataSet();
            this.professorTableAdapter = new Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.ProfessorTableAdapter();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProfessores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAvaliacao2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busca de professores alocados no semestre:";
            // 
            // tbxAnoSemestre
            // 
            this.tbxAnoSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAnoSemestre.Location = new System.Drawing.Point(405, 6);
            this.tbxAnoSemestre.Mask = "0000/0";
            this.tbxAnoSemestre.Name = "tbxAnoSemestre";
            this.tbxAnoSemestre.Size = new System.Drawing.Size(154, 29);
            this.tbxAnoSemestre.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(472, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgrProfessores
            // 
            this.dgrProfessores.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dgrProfessores.BackColor = System.Drawing.Color.DarkGray;
            this.dgrProfessores.CaptionBackColor = System.Drawing.Color.White;
            this.dgrProfessores.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgrProfessores.CaptionForeColor = System.Drawing.Color.Navy;
            this.dgrProfessores.CaptionText = "Professores alocados";
            this.dgrProfessores.DataMember = "";
            this.dgrProfessores.DataSource = this.professorBindingSource;
            this.dgrProfessores.ForeColor = System.Drawing.Color.Black;
            this.dgrProfessores.GridLineColor = System.Drawing.Color.Black;
            this.dgrProfessores.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgrProfessores.HeaderBackColor = System.Drawing.Color.Silver;
            this.dgrProfessores.HeaderForeColor = System.Drawing.Color.Black;
            this.dgrProfessores.LinkColor = System.Drawing.Color.Navy;
            this.dgrProfessores.Location = new System.Drawing.Point(12, 138);
            this.dgrProfessores.Name = "dgrProfessores";
            this.dgrProfessores.ParentRowsBackColor = System.Drawing.Color.White;
            this.dgrProfessores.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dgrProfessores.RowHeadersVisible = false;
            this.dgrProfessores.SelectionBackColor = System.Drawing.Color.Navy;
            this.dgrProfessores.SelectionForeColor = System.Drawing.Color.White;
            this.dgrProfessores.Size = new System.Drawing.Size(547, 252);
            this.dgrProfessores.TabIndex = 3;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataMember = "Professor";
            this.professorBindingSource.DataSource = this.databaseAvaliacao2DataSet;
            // 
            // databaseAvaliacao2DataSet
            // 
            this.databaseAvaliacao2DataSet.DataSetName = "DatabaseAvaliacao2DataSet";
            this.databaseAvaliacao2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professorTableAdapter
            // 
            this.professorTableAdapter.ClearBeforeFill = true;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Professor.*\r\nFROM            Professor";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Professor` (`nomep`, `dataadmissao`) VALUES (?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("nomep", System.Data.OleDb.OleDbType.VarWChar, 0, "nomep"),
            new System.Data.OleDb.OleDbParameter("dataadmissao", System.Data.OleDb.OleDbType.Date, 0, "dataadmissao")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE `Professor` SET `nomep` = ?, `dataadmissao` = ? WHERE ((`codigop` = ?) AND" +
    " ((? = 1 AND `nomep` IS NULL) OR (`nomep` = ?)) AND ((? = 1 AND `dataadmissao` I" +
    "S NULL) OR (`dataadmissao` = ?)))";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("nomep", System.Data.OleDb.OleDbType.VarWChar, 0, "nomep"),
            new System.Data.OleDb.OleDbParameter("dataadmissao", System.Data.OleDb.OleDbType.Date, 0, "dataadmissao"),
            new System.Data.OleDb.OleDbParameter("Original_codigop", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codigop", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_nomep", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "nomep", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_nomep", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nomep", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_dataadmissao", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "dataadmissao", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_dataadmissao", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dataadmissao", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `Professor` WHERE ((`codigop` = ?) AND ((? = 1 AND `nomep` IS NULL) O" +
    "R (`nomep` = ?)) AND ((? = 1 AND `dataadmissao` IS NULL) OR (`dataadmissao` = ?)" +
    "))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_codigop", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codigop", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_nomep", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "nomep", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_nomep", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nomep", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_dataadmissao", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "dataadmissao", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_dataadmissao", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dataadmissao", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Professor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("codigop", "codigop"),
                        new System.Data.Common.DataColumnMapping("nomep", "nomep"),
                        new System.Data.Common.DataColumnMapping("dataadmissao", "dataadmissao")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\DatabaseAvaliacao2.m" +
    "db";
            // 
            // BuscaProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 402);
            this.Controls.Add(this.dgrProfessores);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbxAnoSemestre);
            this.Controls.Add(this.label1);
            this.Name = "BuscaProfessores";
            this.Text = "BuscaProfessores";
            this.Load += new System.EventHandler(this.BuscaProfessores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrProfessores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAvaliacao2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbxAnoSemestre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGrid dgrProfessores;
        private DatabaseAvaliacao2DataSet databaseAvaliacao2DataSet;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private DatabaseAvaliacao2DataSetTableAdapters.ProfessorTableAdapter professorTableAdapter;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
    }
}