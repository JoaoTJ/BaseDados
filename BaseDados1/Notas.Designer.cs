﻿
namespace BaseDados1
{
    partial class formNotas
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
            System.Windows.Forms.Label numdisc_e_numalunoLabel;
            System.Windows.Forms.Label disciplinaLabel;
            System.Windows.Forms.Label anoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNotas));
            this.bdalunosDataSet = new BaseDados1.bdalunosDataSet();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasTableAdapter = new BaseDados1.bdalunosDataSetTableAdapters.NotasTableAdapter();
            this.tableAdapterManager = new BaseDados1.bdalunosDataSetTableAdapters.TableAdapterManager();
            this.notasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.numdisc_e_numalunoTextBox = new System.Windows.Forms.TextBox();
            this.disciplinaTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.notasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            numdisc_e_numalunoLabel = new System.Windows.Forms.Label();
            disciplinaLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdalunosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingNavigator)).BeginInit();
            this.notasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // numdisc_e_numalunoLabel
            // 
            numdisc_e_numalunoLabel.AutoSize = true;
            numdisc_e_numalunoLabel.Location = new System.Drawing.Point(12, 34);
            numdisc_e_numalunoLabel.Name = "numdisc_e_numalunoLabel";
            numdisc_e_numalunoLabel.Size = new System.Drawing.Size(107, 13);
            numdisc_e_numalunoLabel.TabIndex = 1;
            numdisc_e_numalunoLabel.Text = "numdisc e numaluno:";
            // 
            // disciplinaLabel
            // 
            disciplinaLabel.AutoSize = true;
            disciplinaLabel.Location = new System.Drawing.Point(12, 60);
            disciplinaLabel.Name = "disciplinaLabel";
            disciplinaLabel.Size = new System.Drawing.Size(55, 13);
            disciplinaLabel.TabIndex = 3;
            disciplinaLabel.Text = "Disciplina:";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new System.Drawing.Point(12, 86);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(29, 13);
            anoLabel.TabIndex = 5;
            anoLabel.Text = "Ano:";
            // 
            // bdalunosDataSet
            // 
            this.bdalunosDataSet.DataSetName = "bdalunosDataSet";
            this.bdalunosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "Notas";
            this.notasBindingSource.DataSource = this.bdalunosDataSet;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplinasTableAdapter = null;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = this.notasTableAdapter;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BaseDados1.bdalunosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notasBindingNavigator
            // 
            this.notasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notasBindingNavigator.BindingSource = this.notasBindingSource;
            this.notasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.notasBindingNavigatorSaveItem});
            this.notasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notasBindingNavigator.Name = "notasBindingNavigator";
            this.notasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notasBindingNavigator.Size = new System.Drawing.Size(312, 25);
            this.notasBindingNavigator.TabIndex = 0;
            this.notasBindingNavigator.Text = "bindingNavigator1";
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
            // numdisc_e_numalunoTextBox
            // 
            this.numdisc_e_numalunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "numdisc e numaluno", true));
            this.numdisc_e_numalunoTextBox.Location = new System.Drawing.Point(125, 31);
            this.numdisc_e_numalunoTextBox.Name = "numdisc_e_numalunoTextBox";
            this.numdisc_e_numalunoTextBox.ReadOnly = true;
            this.numdisc_e_numalunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.numdisc_e_numalunoTextBox.TabIndex = 2;
            // 
            // disciplinaTextBox
            // 
            this.disciplinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "Disciplina", true));
            this.disciplinaTextBox.Location = new System.Drawing.Point(125, 57);
            this.disciplinaTextBox.Name = "disciplinaTextBox";
            this.disciplinaTextBox.Size = new System.Drawing.Size(100, 20);
            this.disciplinaTextBox.TabIndex = 4;
            // 
            // anoTextBox
            // 
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "Ano", true));
            this.anoTextBox.Location = new System.Drawing.Point(125, 83);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(100, 20);
            this.anoTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 29);
            this.button2.TabIndex = 13;
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
            // notasBindingNavigatorSaveItem
            // 
            this.notasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notasBindingNavigatorSaveItem.Image")));
            this.notasBindingNavigatorSaveItem.Name = "notasBindingNavigatorSaveItem";
            this.notasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.notasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.notasBindingNavigatorSaveItem.Click += new System.EventHandler(this.notasBindingNavigatorSaveItem_Click);
            // 
            // formNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 159);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(numdisc_e_numalunoLabel);
            this.Controls.Add(this.numdisc_e_numalunoTextBox);
            this.Controls.Add(disciplinaLabel);
            this.Controls.Add(this.disciplinaTextBox);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(this.notasBindingNavigator);
            this.Name = "formNotas";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdalunosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingNavigator)).EndInit();
            this.notasBindingNavigator.ResumeLayout(false);
            this.notasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdalunosDataSet bdalunosDataSet;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private bdalunosDataSetTableAdapters.NotasTableAdapter notasTableAdapter;
        private bdalunosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton notasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numdisc_e_numalunoTextBox;
        private System.Windows.Forms.TextBox disciplinaTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}