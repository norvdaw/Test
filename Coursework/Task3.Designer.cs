
namespace KateKurs
{
    partial class Task3
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
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtBad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVar1 = new System.Windows.Forms.Button();
            this.dgvTask3 = new System.Windows.Forms.DataGridView();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zadacha3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new KateKurs.DataSet1();
            this.zadacha3TableAdapter = new KateKurs.DataSet1TableAdapters.Zadacha3TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVar2 = new System.Windows.Forms.Button();
            this.sostavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sostavTableAdapter = new KateKurs.DataSet1TableAdapters.sostavTableAdapter();
            this.uchetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetTableAdapter = new KateKurs.DataSet1TableAdapters.uchetTableAdapter();
            this.normBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normTableAdapter = new KateKurs.DataSet1TableAdapters.normTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(605, 55);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(46, 22);
            this.txtTime.TabIndex = 2;
            this.txtTime.Text = "10";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBad
            // 
            this.txtBad.Location = new System.Drawing.Point(605, 107);
            this.txtBad.Name = "txtBad";
            this.txtBad.Size = new System.Drawing.Size(50, 22);
            this.txtBad.TabIndex = 3;
            this.txtBad.Text = "0";
            this.txtBad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время изготовления 1 шт. товара превышает:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Допустимое количество брака не превышает:";
            // 
            // btnVar1
            // 
            this.btnVar1.Location = new System.Drawing.Point(390, 238);
            this.btnVar1.Name = "btnVar1";
            this.btnVar1.Size = new System.Drawing.Size(105, 48);
            this.btnVar1.TabIndex = 7;
            this.btnVar1.Text = "Заполнить (Вар. 1)";
            this.btnVar1.UseVisualStyleBackColor = true;
            this.btnVar1.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // dgvTask3
            // 
            this.dgvTask3.AutoGenerateColumns = false;
            this.dgvTask3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn});
            this.dgvTask3.DataSource = this.zadacha3BindingSource;
            this.dgvTask3.Location = new System.Drawing.Point(12, 12);
            this.dgvTask3.Name = "dgvTask3";
            this.dgvTask3.RowHeadersWidth = 51;
            this.dgvTask3.RowTemplate.Height = 24;
            this.dgvTask3.Size = new System.Drawing.Size(245, 300);
            this.dgvTask3.TabIndex = 11;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 125;
            // 
            // zadacha3BindingSource
            // 
            this.zadacha3BindingSource.DataMember = "Zadacha3";
            this.zadacha3BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zadacha3TableAdapter
            // 
            this.zadacha3TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "мин.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "шт.";
            // 
            // btnVar2
            // 
            this.btnVar2.Location = new System.Drawing.Point(515, 238);
            this.btnVar2.Name = "btnVar2";
            this.btnVar2.Size = new System.Drawing.Size(105, 48);
            this.btnVar2.TabIndex = 14;
            this.btnVar2.Text = "Заполнить (Вар. 2)";
            this.btnVar2.UseVisualStyleBackColor = true;
            this.btnVar2.Click += new System.EventHandler(this.btnVar2_Click);
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
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 324);
            this.Controls.Add(this.btnVar2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTask3);
            this.Controls.Add(this.btnVar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBad);
            this.Controls.Add(this.txtTime);
            this.Name = "Task3";
            this.Text = "Zadacha3v1";
            this.Load += new System.EventHandler(this.Task3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtBad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVar1;
        private System.Windows.Forms.DataGridView dgvTask3;
        private System.Windows.Forms.BindingSource zadacha3BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.Zadacha3TableAdapter zadacha3TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVar2;
        private System.Windows.Forms.BindingSource sostavBindingSource;
        private DataSet1TableAdapters.sostavTableAdapter sostavTableAdapter;
        private System.Windows.Forms.BindingSource uchetBindingSource;
        private DataSet1TableAdapters.uchetTableAdapter uchetTableAdapter;
        private System.Windows.Forms.BindingSource normBindingSource;
        private DataSet1TableAdapters.normTableAdapter normTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
    }
}