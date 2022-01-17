
namespace BaseDados1
{
    partial class formFuncionários
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
            System.Windows.Forms.Label numfuncLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idadeLabel;
            System.Windows.Forms.Label telemóvelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFuncionários));
            this.bdalunosDataSet = new BaseDados1.bdalunosDataSet();
            this.funcionáriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionáriosTableAdapter = new BaseDados1.bdalunosDataSetTableAdapters.FuncionáriosTableAdapter();
            this.tableAdapterManager = new BaseDados1.bdalunosDataSetTableAdapters.TableAdapterManager();
            this.funcionáriosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.numfuncTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.idadeTextBox = new System.Windows.Forms.TextBox();
            this.telemóvelTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.funcionáriosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            numfuncLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            idadeLabel = new System.Windows.Forms.Label();
            telemóvelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdalunosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionáriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionáriosBindingNavigator)).BeginInit();
            this.funcionáriosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // numfuncLabel
            // 
            numfuncLabel.AutoSize = true;
            numfuncLabel.Location = new System.Drawing.Point(12, 36);
            numfuncLabel.Name = "numfuncLabel";
            numfuncLabel.Size = new System.Drawing.Size(51, 13);
            numfuncLabel.TabIndex = 1;
            numfuncLabel.Text = "numfunc:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 62);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // idadeLabel
            // 
            idadeLabel.AutoSize = true;
            idadeLabel.Location = new System.Drawing.Point(12, 88);
            idadeLabel.Name = "idadeLabel";
            idadeLabel.Size = new System.Drawing.Size(37, 13);
            idadeLabel.TabIndex = 5;
            idadeLabel.Text = "Idade:";
            // 
            // telemóvelLabel
            // 
            telemóvelLabel.AutoSize = true;
            telemóvelLabel.Location = new System.Drawing.Point(12, 114);
            telemóvelLabel.Name = "telemóvelLabel";
            telemóvelLabel.Size = new System.Drawing.Size(59, 13);
            telemóvelLabel.TabIndex = 7;
            telemóvelLabel.Text = "Telemóvel:";
            // 
            // bdalunosDataSet
            // 
            this.bdalunosDataSet.DataSetName = "bdalunosDataSet";
            this.bdalunosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionáriosBindingSource
            // 
            this.funcionáriosBindingSource.DataMember = "Funcionários";
            this.funcionáriosBindingSource.DataSource = this.bdalunosDataSet;
            // 
            // funcionáriosTableAdapter
            // 
            this.funcionáriosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplinasTableAdapter = null;
            this.tableAdapterManager.FuncionáriosTableAdapter = this.funcionáriosTableAdapter;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BaseDados1.bdalunosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // funcionáriosBindingNavigator
            // 
            this.funcionáriosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funcionáriosBindingNavigator.BindingSource = this.funcionáriosBindingSource;
            this.funcionáriosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funcionáriosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.funcionáriosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.funcionáriosBindingNavigatorSaveItem});
            this.funcionáriosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.funcionáriosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.funcionáriosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.funcionáriosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.funcionáriosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.funcionáriosBindingNavigator.Name = "funcionáriosBindingNavigator";
            this.funcionáriosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.funcionáriosBindingNavigator.Size = new System.Drawing.Size(297, 25);
            this.funcionáriosBindingNavigator.TabIndex = 0;
            this.funcionáriosBindingNavigator.Text = "bindingNavigator1";
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
            // numfuncTextBox
            // 
            this.numfuncTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "numfunc", true));
            this.numfuncTextBox.Location = new System.Drawing.Point(77, 33);
            this.numfuncTextBox.Name = "numfuncTextBox";
            this.numfuncTextBox.ReadOnly = true;
            this.numfuncTextBox.Size = new System.Drawing.Size(100, 20);
            this.numfuncTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(77, 59);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // idadeTextBox
            // 
            this.idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "Idade", true));
            this.idadeTextBox.Location = new System.Drawing.Point(77, 85);
            this.idadeTextBox.Name = "idadeTextBox";
            this.idadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.idadeTextBox.TabIndex = 6;
            // 
            // telemóvelTextBox
            // 
            this.telemóvelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionáriosBindingSource, "Telemóvel", true));
            this.telemóvelTextBox.Location = new System.Drawing.Point(77, 111);
            this.telemóvelTextBox.Name = "telemóvelTextBox";
            this.telemóvelTextBox.Size = new System.Drawing.Size(100, 20);
            this.telemóvelTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // funcionáriosBindingNavigatorSaveItem
            // 
            this.funcionáriosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funcionáriosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionáriosBindingNavigatorSaveItem.Image")));
            this.funcionáriosBindingNavigatorSaveItem.Name = "funcionáriosBindingNavigatorSaveItem";
            this.funcionáriosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.funcionáriosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.funcionáriosBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionáriosBindingNavigatorSaveItem_Click);
            // 
            // formFuncionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 196);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(numfuncLabel);
            this.Controls.Add(this.numfuncTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(idadeLabel);
            this.Controls.Add(this.idadeTextBox);
            this.Controls.Add(telemóvelLabel);
            this.Controls.Add(this.telemóvelTextBox);
            this.Controls.Add(this.funcionáriosBindingNavigator);
            this.Name = "formFuncionários";
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdalunosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionáriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionáriosBindingNavigator)).EndInit();
            this.funcionáriosBindingNavigator.ResumeLayout(false);
            this.funcionáriosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdalunosDataSet bdalunosDataSet;
        private System.Windows.Forms.BindingSource funcionáriosBindingSource;
        private bdalunosDataSetTableAdapters.FuncionáriosTableAdapter funcionáriosTableAdapter;
        private bdalunosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funcionáriosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton funcionáriosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numfuncTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox idadeTextBox;
        private System.Windows.Forms.TextBox telemóvelTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}