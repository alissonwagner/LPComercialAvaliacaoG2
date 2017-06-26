namespace Avaliacao2G2
{
    partial class Disciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disciplina));
            System.Windows.Forms.Label codigodLabel;
            System.Windows.Forms.Label nomedLabel;
            System.Windows.Forms.Label cursoLabel;
            this.databaseAvaliacao2DataSet = new Avaliacao2G2.DatabaseAvaliacao2DataSet();
            this.disciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinaTableAdapter = new Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.DisciplinaTableAdapter();
            this.tableAdapterManager = new Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.TableAdapterManager();
            this.disciplinaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.disciplinaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigodLabel1 = new System.Windows.Forms.Label();
            this.nomedTextBox = new System.Windows.Forms.TextBox();
            this.cursoComboBox = new System.Windows.Forms.ComboBox();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new Avaliacao2G2.DatabaseAvaliacao2DataSetTableAdapters.CursoTableAdapter();
            codigodLabel = new System.Windows.Forms.Label();
            nomedLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAvaliacao2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingNavigator)).BeginInit();
            this.disciplinaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseAvaliacao2DataSet
            // 
            this.databaseAvaliacao2DataSet.DataSetName = "DatabaseAvaliacao2DataSet";
            this.databaseAvaliacao2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // disciplinaBindingNavigator
            // 
            this.disciplinaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.disciplinaBindingNavigator.BindingSource = this.disciplinaBindingSource;
            this.disciplinaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.disciplinaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.disciplinaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.disciplinaBindingNavigatorSaveItem});
            this.disciplinaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.disciplinaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.disciplinaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.disciplinaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.disciplinaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.disciplinaBindingNavigator.Name = "disciplinaBindingNavigator";
            this.disciplinaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.disciplinaBindingNavigator.Size = new System.Drawing.Size(574, 25);
            this.disciplinaBindingNavigator.TabIndex = 0;
            this.disciplinaBindingNavigator.Text = "bindingNavigator1";
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
            // disciplinaBindingNavigatorSaveItem
            // 
            this.disciplinaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disciplinaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("disciplinaBindingNavigatorSaveItem.Image")));
            this.disciplinaBindingNavigatorSaveItem.Name = "disciplinaBindingNavigatorSaveItem";
            this.disciplinaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.disciplinaBindingNavigatorSaveItem.Text = "Save Data";
            this.disciplinaBindingNavigatorSaveItem.Click += new System.EventHandler(this.disciplinaBindingNavigatorSaveItem_Click);
            // 
            // codigodLabel
            // 
            codigodLabel.AutoSize = true;
            codigodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigodLabel.Location = new System.Drawing.Point(98, 112);
            codigodLabel.Name = "codigodLabel";
            codigodLabel.Size = new System.Drawing.Size(63, 20);
            codigodLabel.TabIndex = 1;
            codigodLabel.Text = "Código:";
            // 
            // codigodLabel1
            // 
            this.codigodLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinaBindingSource, "codigod", true));
            this.codigodLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigodLabel1.Location = new System.Drawing.Point(203, 112);
            this.codigodLabel1.Name = "codigodLabel1";
            this.codigodLabel1.Size = new System.Drawing.Size(306, 23);
            this.codigodLabel1.TabIndex = 2;
            this.codigodLabel1.Text = "label1";
            // 
            // nomedLabel
            // 
            nomedLabel.AutoSize = true;
            nomedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomedLabel.Location = new System.Drawing.Point(98, 141);
            nomedLabel.Name = "nomedLabel";
            nomedLabel.Size = new System.Drawing.Size(55, 20);
            nomedLabel.TabIndex = 3;
            nomedLabel.Text = "Nome:";
            // 
            // nomedTextBox
            // 
            this.nomedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinaBindingSource, "nomed", true));
            this.nomedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomedTextBox.Location = new System.Drawing.Point(203, 138);
            this.nomedTextBox.Name = "nomedTextBox";
            this.nomedTextBox.Size = new System.Drawing.Size(306, 26);
            this.nomedTextBox.TabIndex = 4;
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cursoLabel.Location = new System.Drawing.Point(98, 167);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(55, 20);
            cursoLabel.TabIndex = 5;
            cursoLabel.Text = "Curso:";
            // 
            // cursoComboBox
            // 
            this.cursoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.disciplinaBindingSource, "curso", true));
            this.cursoComboBox.DataSource = this.cursoBindingSource;
            this.cursoComboBox.DisplayMember = "nomec";
            this.cursoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursoComboBox.FormattingEnabled = true;
            this.cursoComboBox.Location = new System.Drawing.Point(203, 164);
            this.cursoComboBox.Name = "cursoComboBox";
            this.cursoComboBox.Size = new System.Drawing.Size(306, 28);
            this.cursoComboBox.TabIndex = 6;
            this.cursoComboBox.ValueMember = "codigoc";
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
            // Disciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 311);
            this.Controls.Add(codigodLabel);
            this.Controls.Add(this.codigodLabel1);
            this.Controls.Add(nomedLabel);
            this.Controls.Add(this.nomedTextBox);
            this.Controls.Add(cursoLabel);
            this.Controls.Add(this.cursoComboBox);
            this.Controls.Add(this.disciplinaBindingNavigator);
            this.Name = "Disciplina";
            this.Text = "Disciplina";
            this.Load += new System.EventHandler(this.Disciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseAvaliacao2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaBindingNavigator)).EndInit();
            this.disciplinaBindingNavigator.ResumeLayout(false);
            this.disciplinaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseAvaliacao2DataSet databaseAvaliacao2DataSet;
        private System.Windows.Forms.BindingSource disciplinaBindingSource;
        private DatabaseAvaliacao2DataSetTableAdapters.DisciplinaTableAdapter disciplinaTableAdapter;
        private DatabaseAvaliacao2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator disciplinaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton disciplinaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label codigodLabel1;
        private System.Windows.Forms.TextBox nomedTextBox;
        private System.Windows.Forms.ComboBox cursoComboBox;
        private DatabaseAvaliacao2DataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.BindingSource cursoBindingSource;
    }
}