
namespace KateKurs
{
    partial class Task1
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
            this.txtBad = new System.Windows.Forms.TextBox();
            this.btnVar1 = new System.Windows.Forms.Button();
            this.dgvTask1 = new System.Windows.Forms.DataGridView();
            this.idcehDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvobadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvogoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zadacha1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new KateKurs.DataSet1();
            this.zadacha1TableAdapter = new KateKurs.DataSet1TableAdapters.Zadacha1TableAdapter();
            this.btnVar2 = new System.Windows.Forms.Button();
            this.btnVar3 = new System.Windows.Forms.Button();
            this.btnVar4 = new System.Windows.Forms.Button();
            this.btnVar5 = new System.Windows.Forms.Button();
            this.sostavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sostavTableAdapter = new KateKurs.DataSet1TableAdapters.sostavTableAdapter();
            this.uchetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetTableAdapter = new KateKurs.DataSet1TableAdapters.uchetTableAdapter();
            this.normBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normTableAdapter = new KateKurs.DataSet1TableAdapters.normTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цеха, в которых количество бракованных деталей не превышает:";
            // 
            // txtBad
            // 
            this.txtBad.Location = new System.Drawing.Point(476, 376);
            this.txtBad.Name = "txtBad";
            this.txtBad.Size = new System.Drawing.Size(71, 22);
            this.txtBad.TabIndex = 3;
            this.txtBad.Text = "0";
            this.txtBad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVar1
            // 
            this.btnVar1.Location = new System.Drawing.Point(12, 423);
            this.btnVar1.Name = "btnVar1";
            this.btnVar1.Size = new System.Drawing.Size(98, 46);
            this.btnVar1.TabIndex = 4;
            this.btnVar1.Text = "Заполнить (Вар. 1)";
            this.btnVar1.UseVisualStyleBackColor = true;
            this.btnVar1.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // dgvTask1
            // 
            this.dgvTask1.AutoGenerateColumns = false;
            this.dgvTask1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcehDataGridViewTextBoxColumn,
            this.iddetailDataGridViewTextBoxColumn,
            this.kolvobadDataGridViewTextBoxColumn,
            this.kolvogoodDataGridViewTextBoxColumn});
            this.dgvTask1.DataSource = this.zadacha1BindingSource;
            this.dgvTask1.Location = new System.Drawing.Point(15, 12);
            this.dgvTask1.Name = "dgvTask1";
            this.dgvTask1.RowHeadersWidth = 51;
            this.dgvTask1.RowTemplate.Height = 24;
            this.dgvTask1.Size = new System.Drawing.Size(582, 359);
            this.dgvTask1.TabIndex = 6;
            // 
            // idcehDataGridViewTextBoxColumn
            // 
            this.idcehDataGridViewTextBoxColumn.DataPropertyName = "id_ceh";
            this.idcehDataGridViewTextBoxColumn.HeaderText = "Номер цеха";
            this.idcehDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcehDataGridViewTextBoxColumn.Name = "idcehDataGridViewTextBoxColumn";
            this.idcehDataGridViewTextBoxColumn.Width = 125;
            // 
            // iddetailDataGridViewTextBoxColumn
            // 
            this.iddetailDataGridViewTextBoxColumn.DataPropertyName = "id_detail";
            this.iddetailDataGridViewTextBoxColumn.HeaderText = "Код детали";
            this.iddetailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddetailDataGridViewTextBoxColumn.Name = "iddetailDataGridViewTextBoxColumn";
            this.iddetailDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolvobadDataGridViewTextBoxColumn
            // 
            this.kolvobadDataGridViewTextBoxColumn.DataPropertyName = "kolvo_bad";
            this.kolvobadDataGridViewTextBoxColumn.HeaderText = "Кол-во брака";
            this.kolvobadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolvobadDataGridViewTextBoxColumn.Name = "kolvobadDataGridViewTextBoxColumn";
            this.kolvobadDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolvogoodDataGridViewTextBoxColumn
            // 
            this.kolvogoodDataGridViewTextBoxColumn.DataPropertyName = "kolvo_good";
            this.kolvogoodDataGridViewTextBoxColumn.HeaderText = "Кол-во деталей без брака";
            this.kolvogoodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolvogoodDataGridViewTextBoxColumn.Name = "kolvogoodDataGridViewTextBoxColumn";
            this.kolvogoodDataGridViewTextBoxColumn.Width = 125;
            // 
            // zadacha1BindingSource
            // 
            this.zadacha1BindingSource.DataMember = "Zadacha1";
            this.zadacha1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zadacha1TableAdapter
            // 
            this.zadacha1TableAdapter.ClearBeforeFill = true;
            // 
            // btnVar2
            // 
            this.btnVar2.Location = new System.Drawing.Point(133, 423);
            this.btnVar2.Name = "btnVar2";
            this.btnVar2.Size = new System.Drawing.Size(98, 46);
            this.btnVar2.TabIndex = 7;
            this.btnVar2.Text = "Заполнить (Вар. 2)";
            this.btnVar2.UseVisualStyleBackColor = true;
            this.btnVar2.Click += new System.EventHandler(this.btnVar2_Click);
            // 
            // btnVar3
            // 
            this.btnVar3.Location = new System.Drawing.Point(255, 423);
            this.btnVar3.Name = "btnVar3";
            this.btnVar3.Size = new System.Drawing.Size(95, 46);
            this.btnVar3.TabIndex = 8;
            this.btnVar3.Text = "Заполнить (Вар. 3)";
            this.btnVar3.UseVisualStyleBackColor = true;
            this.btnVar3.Click += new System.EventHandler(this.btnVar3_Click);
            // 
            // btnVar4
            // 
            this.btnVar4.Location = new System.Drawing.Point(377, 423);
            this.btnVar4.Name = "btnVar4";
            this.btnVar4.Size = new System.Drawing.Size(95, 46);
            this.btnVar4.TabIndex = 9;
            this.btnVar4.Text = "Заполнить (Вар. 4)";
            this.btnVar4.UseVisualStyleBackColor = true;
            this.btnVar4.Click += new System.EventHandler(this.btnVar4_Click);
            // 
            // btnVar5
            // 
            this.btnVar5.Location = new System.Drawing.Point(502, 423);
            this.btnVar5.Name = "btnVar5";
            this.btnVar5.Size = new System.Drawing.Size(95, 46);
            this.btnVar5.TabIndex = 10;
            this.btnVar5.Text = "Заполнить (Вар. 5)";
            this.btnVar5.UseVisualStyleBackColor = true;
            this.btnVar5.Click += new System.EventHandler(this.btnVar5_Click);
            // 
            // sostavBindingSource
            // 
            this.sostavBindingSource.DataMember = "sostav";
            this.sostavBindingSource.DataSource = this.dataSet1;
            // 
            // sostavTableAdapter
            // 
            this.sostavTableAdapter.ClearBeforeFill = true;
            // 
            // uchetBindingSource
            // 
            this.uchetBindingSource.DataMember = "uchet";
            this.uchetBindingSource.DataSource = this.dataSet1;
            // 
            // uchetTableAdapter
            // 
            this.uchetTableAdapter.ClearBeforeFill = true;
            // 
            // normBindingSource
            // 
            this.normBindingSource.DataMember = "norm";
            this.normBindingSource.DataSource = this.dataSet1;
            // 
            // normTableAdapter
            // 
            this.normTableAdapter.ClearBeforeFill = true;
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 486);
            this.Controls.Add(this.btnVar5);
            this.Controls.Add(this.btnVar4);
            this.Controls.Add(this.btnVar3);
            this.Controls.Add(this.btnVar2);
            this.Controls.Add(this.dgvTask1);
            this.Controls.Add(this.btnVar1);
            this.Controls.Add(this.txtBad);
            this.Controls.Add(this.label1);
            this.Name = "Task1";
            this.Text = "Zadacha1v1";
            this.Load += new System.EventHandler(this.Task1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBad;
        private System.Windows.Forms.Button btnVar1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dgvTask1;
        private System.Windows.Forms.BindingSource zadacha1BindingSource;
        private DataSet1TableAdapters.Zadacha1TableAdapter zadacha1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcehDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvobadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvogoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnVar2;
        private System.Windows.Forms.Button btnVar3;
        private System.Windows.Forms.Button btnVar4;
        private System.Windows.Forms.Button btnVar5;
        private System.Windows.Forms.BindingSource sostavBindingSource;
        private DataSet1TableAdapters.sostavTableAdapter sostavTableAdapter;
        private System.Windows.Forms.BindingSource uchetBindingSource;
        private DataSet1TableAdapters.uchetTableAdapter uchetTableAdapter;
        private System.Windows.Forms.BindingSource normBindingSource;
        private DataSet1TableAdapters.normTableAdapter normTableAdapter;
    }
}