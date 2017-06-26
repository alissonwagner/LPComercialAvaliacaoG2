namespace Avaliacao2G2
{
    partial class Alocado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alocado));
            System.Windows.Forms.Label codigoaLabel;
            System.Windows.Forms.Label anoSemestreLabel;
            System.Windows.Forms.Label professorLabel;
            this.databaseAvaliacao2DataSet = new Avaliacao2G2.DatabaseAvaliacao2DataSet();
            this.alocadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alocadoTableAdapter = new Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.AlocadoTableAdapter();
            this.tableAdapterManager = new Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.TableAdapterManager();
            this.alocadoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.alocadoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoaLabel1 = new System.Windows.Forms.Label();
            this.anoSemestreMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.professorComboBox = new System.Windows.Forms.ComboBox();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professorTableAdapter = new Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.ProfessorTableAdapter();
            this.disciplinaAlocadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinaAlocadoTableAdapter = new Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.DisciplinaAlocadoTableAdapter();
            this.disciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinaTableAdapter = new Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.DisciplinaTableAdapter();
            this.disciplinaAlocadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            codigoaLabel = new System.Windows.Forms.Label();
            anoSemestreLabel = new System.Windows.Forms.Label();
            professorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAvaliacao2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alocadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alocadoBindingNavigator)).BeginInit();
            this.alocadoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaAlocadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaAlocadoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseAvaliacao2DataSet
            // 
            this.databaseAvaliacao2DataSet.DataSetName = "DatabaseAvaliacao2DataSet";
            this.databaseAvaliacao2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alocadoBindingSource
            // 
            this.alocadoBindingSource.DataMember = "Alocado";
            this.alocadoBindingSource.DataSource = this.databaseAvaliacao2DataSet;
            // 
            // alocadoTableAdapter
            // 
            this.alocadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlocadoTableAdapter = this.alocadoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.DisciplinaAlocadoTableAdapter = this.disciplinaAlocadoTableAdapter;
            this.tableAdapterManager.DisciplinaTableAdapter = this.disciplinaTableAdapter;
            this.tableAdapterManager.ProfessorTableAdapter = this.professorTableAdapter;
            this.tableAdapterManager.UpdateOrder = Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alocadoBindingNavigator
            // 
            this.alocadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alocadoBindingNavigator.BindingSource = this.alocadoBindingSource;
            this.alocadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alocadoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alocadoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.alocadoBindingNavigatorSaveItem});
            this.alocadoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.alocadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alocadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alocadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alocadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alocadoBindingNavigator.Name = "alocadoBindingNavigator";
            this.alocadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alocadoBindingNavigator.Size = new System.Drawing.Size(684, 25);
            this.alocadoBindingNavigator.TabIndex = 0;
            this.alocadoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // alocadoBindingNavigatorSaveItem
            // 
            this.alocadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alocadoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alocadoBindingNavigatorSaveItem.Image")));
            this.alocadoBindingNavigatorSaveItem.Name = "alocadoBindingNavigatorSaveItem";
            this.alocadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.alocadoBindingNavigatorSaveItem.Text = "Save Data";
            this.alocadoBindingNavigatorSaveItem.Click += new System.EventHandler(this.alocadoBindingNavigatorSaveItem_Click);
            // 
            // codigoaLabel
            // 
            codigoaLabel.AutoSize = true;
            codigoaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoaLabel.Location = new System.Drawing.Point(91, 102);
            codigoaLabel.Name = "codigoaLabel";
            codigoaLabel.Size = new System.Drawing.Size(63, 20);
            codigoaLabel.TabIndex = 1;
            codigoaLabel.Text = "Código:";
            // 
            // codigoaLabel1
            // 
            this.codigoaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alocadoBindingSource, "codigoa", true));
            this.codigoaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoaLabel1.Location = new System.Drawing.Point(211, 105);
            this.codigoaLabel1.Name = "codigoaLabel1";
            this.codigoaLabel1.Size = new System.Drawing.Size(283, 23);
            this.codigoaLabel1.TabIndex = 2;
            this.codigoaLabel1.Text = "label1";
            // 
            // anoSemestreLabel
            // 
            anoSemestreLabel.AutoSize = true;
            anoSemestreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anoSemestreLabel.Location = new System.Drawing.Point(91, 131);
            anoSemestreLabel.Name = "anoSemestreLabel";
            anoSemestreLabel.Size = new System.Drawing.Size(115, 20);
            anoSemestreLabel.TabIndex = 3;
            anoSemestreLabel.Text = "Ano/Semestre:";
            // 
            // anoSemestreMaskedTextBox
            // 
            this.anoSemestreMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alocadoBindingSource, "anoSemestre", true));
            this.anoSemestreMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoSemestreMaskedTextBox.Location = new System.Drawing.Point(211, 131);
            this.anoSemestreMaskedTextBox.Mask = "0000/0";
            this.anoSemestreMaskedTextBox.Name = "anoSemestreMaskedTextBox";
            this.anoSemestreMaskedTextBox.Size = new System.Drawing.Size(283, 26);
            this.anoSemestreMaskedTextBox.TabIndex = 4;
            // 
            // professorLabel
            // 
            professorLabel.AutoSize = true;
            professorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            professorLabel.Location = new System.Drawing.Point(91, 157);
            professorLabel.Name = "professorLabel";
            professorLabel.Size = new System.Drawing.Size(81, 20);
            professorLabel.TabIndex = 5;
            professorLabel.Text = "Professor:";
            // 
            // professorComboBox
            // 
            this.professorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.alocadoBindingSource, "professor", true));
            this.professorComboBox.DataSource = this.professorBindingSource;
            this.professorComboBox.DisplayMember = "nomep";
            this.professorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professorComboBox.FormattingEnabled = true;
            this.professorComboBox.Location = new System.Drawing.Point(211, 157);
            this.professorComboBox.Name = "professorComboBox";
            this.professorComboBox.Size = new System.Drawing.Size(283, 28);
            this.professorComboBox.TabIndex = 6;
            this.professorComboBox.ValueMember = "codigop";
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataMember = "Professor";
            this.professorBindingSource.DataSource = this.databaseAvaliacao2DataSet;
            // 
            // professorTableAdapter
            // 
            this.professorTableAdapter.ClearBeforeFill = true;
            // 
            // disciplinaAlocadoBindingSource
            // 
            this.disciplinaAlocadoBindingSource.DataMember = "DisciplinaAlocado";
            this.disciplinaAlocadoBindingSource.DataSource = this.databaseAvaliacao2DataSet;
            // 
            // disciplinaAlocadoTableAdapter
            // 
            this.disciplinaAlocadoTableAdapter.ClearBeforeFill = true;
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
            // disciplinaAlocadoBindingSource1
            // 
            this.disciplinaAlocadoBindingSource1.DataMember = "DisciplinaDisciplinaAlocado";
            this.disciplinaAlocadoBindingSource1.DataSource = this.disciplinaBindingSource;
            // 
            // Alocado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 476);
            this.Controls.Add(codigoaLabel);
            this.Controls.Add(this.codigoaLabel1);
            this.Controls.Add(anoSemestreLabel);
            this.Controls.Add(this.anoSemestreMaskedTextBox);
            this.Controls.Add(professorLabel);
            this.Controls.Add(this.professorComboBox);
            this.Controls.Add(this.alocadoBindingNavigator);
            this.Name = "Alocado";
            this.Text = "Alocado";
            this.Load += new System.EventHandler(this.Alocado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseAvaliacao2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alocadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alocadoBindingNavigator)).EndInit();
            this.alocadoBindingNavigator.ResumeLayout(false);
            this.alocadoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaAlocadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaAlocadoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseAvaliacao2DataSet databaseAvaliacao2DataSet;
        private System.Windows.Forms.BindingSource alocadoBindingSource;
        private DatabaseAvaliacao2DataSetTableAdapters.AlocadoTableAdapter alocadoTableAdapter;
        private DatabaseAvaliacao2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alocadoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton alocadoBindingNavigatorSaveItem;
        private DatabaseAvaliacao2DataSetTableAdapters.ProfessorTableAdapter professorTableAdapter;
        private System.Windows.Forms.Label codigoaLabel1;
        private System.Windows.Forms.MaskedTextBox anoSemestreMaskedTextBox;
        private System.Windows.Forms.ComboBox professorComboBox;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private DatabaseAvaliacao2DataSetTableAdapters.DisciplinaAlocadoTableAdapter disciplinaAlocadoTableAdapter;
        private System.Windows.Forms.BindingSource disciplinaAlocadoBindingSource;
        private DatabaseAvaliacao2DataSetTableAdapters.DisciplinaTableAdapter disciplinaTableAdapter;
        private System.Windows.Forms.BindingSource disciplinaBindingSource;
        private System.Windows.Forms.BindingSource disciplinaAlocadoBindingSource1;
    }
}