
namespace BaseDados1
{
    partial class formTurmas
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
            System.Windows.Forms.Label numturmaLabel;
            System.Windows.Forms.Label cursoLabel;
            System.Windows.Forms.Label diretorturmaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTurmas));
            this.bdalunosDataSet = new BaseDados1.bdalunosDataSet();
            this.turmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turmasTableAdapter = new BaseDados1.bdalunosDataSetTableAdapters.TurmasTableAdapter();
            this.tableAdapterManager = new BaseDados1.bdalunosDataSetTableAdapters.TableAdapterManager();
            this.turmasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.numturmaTextBox = new System.Windows.Forms.TextBox();
            this.cursoTextBox = new System.Windows.Forms.TextBox();
            this.diretorturmaTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.turmasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            numturmaLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            diretorturmaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdalunosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingNavigator)).BeginInit();
            this.turmasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // numturmaLabel
            // 
            numturmaLabel.AutoSize = true;
            numturmaLabel.Location = new System.Drawing.Point(12, 38);
            numturmaLabel.Name = "numturmaLabel";
            numturmaLabel.Size = new System.Drawing.Size(56, 13);
            numturmaLabel.TabIndex = 1;
            numturmaLabel.Text = "numturma:";
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Location = new System.Drawing.Point(12, 64);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(37, 13);
            cursoLabel.TabIndex = 3;
            cursoLabel.Text = "Curso:";
            // 
            // diretorturmaLabel
            // 
            diretorturmaLabel.AutoSize = true;
            diretorturmaLabel.Location = new System.Drawing.Point(12, 90);
            diretorturmaLabel.Name = "diretorturmaLabel";
            diretorturmaLabel.Size = new System.Drawing.Size(67, 13);
            diretorturmaLabel.TabIndex = 5;
            diretorturmaLabel.Text = "Diretorturma:";
            // 
            // bdalunosDataSet
            // 
            this.bdalunosDataSet.DataSetName = "bdalunosDataSet";
            this.bdalunosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turmasBindingSource
            // 
            this.turmasBindingSource.DataMember = "Turmas";
            this.turmasBindingSource.DataSource = this.bdalunosDataSet;
            // 
            // turmasTableAdapter
            // 
            this.turmasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplinasTableAdapter = null;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = this.turmasTableAdapter;
            this.tableAdapterManager.UpdateOrder = BaseDados1.bdalunosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // turmasBindingNavigator
            // 
            this.turmasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.turmasBindingNavigator.BindingSource = this.turmasBindingSource;
            this.turmasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.turmasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.turmasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.turmasBindingNavigatorSaveItem});
            this.turmasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.turmasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.turmasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.turmasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.turmasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.turmasBindingNavigator.Name = "turmasBindingNavigator";
            this.turmasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.turmasBindingNavigator.Size = new System.Drawing.Size(288, 25);
            this.turmasBindingNavigator.TabIndex = 0;
            this.turmasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // numturmaTextBox
            // 
            this.numturmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmasBindingSource, "numturma", true));
            this.numturmaTextBox.Location = new System.Drawing.Point(85, 35);
            this.numturmaTextBox.Name = "numturmaTextBox";
            this.numturmaTextBox.ReadOnly = true;
            this.numturmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.numturmaTextBox.TabIndex = 2;
            // 
            // cursoTextBox
            // 
            this.cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmasBindingSource, "Curso", true));
            this.cursoTextBox.Location = new System.Drawing.Point(85, 61);
            this.cursoTextBox.Name = "cursoTextBox";
            this.cursoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cursoTextBox.TabIndex = 4;
            // 
            // diretorturmaTextBox
            // 
            this.diretorturmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmasBindingSource, "Diretorturma", true));
            this.diretorturmaTextBox.Location = new System.Drawing.Point(85, 87);
            this.diretorturmaTextBox.Name = "diretorturmaTextBox";
            this.diretorturmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.diretorturmaTextBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::BaseDados1.Properties.Resources.gamer___Cópia;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(91, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 29);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.BackgroundImage = global::BaseDados1.Properties.Resources.gamer;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(141, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 29);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // turmasBindingNavigatorSaveItem
            // 
            this.turmasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.turmasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("turmasBindingNavigatorSaveItem.Image")));
            this.turmasBindingNavigatorSaveItem.Name = "turmasBindingNavigatorSaveItem";
            this.turmasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.turmasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.turmasBindingNavigatorSaveItem.Click += new System.EventHandler(this.turmasBindingNavigatorSaveItem_Click);
            // 
            // formTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 165);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(numturmaLabel);
            this.Controls.Add(this.numturmaTextBox);
            this.Controls.Add(cursoLabel);
            this.Controls.Add(this.cursoTextBox);
            this.Controls.Add(diretorturmaLabel);
            this.Controls.Add(this.diretorturmaTextBox);
            this.Controls.Add(this.turmasBindingNavigator);
            this.Name = "formTurmas";
            this.Text = "Turmas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdalunosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingNavigator)).EndInit();
            this.turmasBindingNavigator.ResumeLayout(false);
            this.turmasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdalunosDataSet bdalunosDataSet;
        private System.Windows.Forms.BindingSource turmasBindingSource;
        private bdalunosDataSetTableAdapters.TurmasTableAdapter turmasTableAdapter;
        private bdalunosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator turmasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton turmasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numturmaTextBox;
        private System.Windows.Forms.TextBox cursoTextBox;
        private System.Windows.Forms.TextBox diretorturmaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}