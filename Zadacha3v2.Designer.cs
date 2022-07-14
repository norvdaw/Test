
namespace KateKurs
{
    partial class Zadacha3v2
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
            this.btnFill = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBad = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.dataSet1 = new KateKurs.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zadacha3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zadacha3TableAdapter = new KateKurs.DataSet1TableAdapters.Zadacha3TableAdapter();
            this.normBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normTableAdapter = new KateKurs.DataSet1TableAdapters.normTableAdapter();
            this.sostavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sostavTableAdapter = new KateKurs.DataSet1TableAdapters.sostavTableAdapter();
            this.uchetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetTableAdapter = new KateKurs.DataSet1TableAdapters.uchetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(564, 221);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(105, 39);
            this.btnFill.TabIndex = 14;
            this.btnFill.Text = "Заполнить";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Количество допустимого брака:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Штучное время превышает:";
            // 
            // txtBad
            // 
            this.txtBad.Location = new System.Drawing.Point(648, 138);
            this.txtBad.Name = "txtBad";
            this.txtBad.Size = new System.Drawing.Size(100, 22);
            this.txtBad.TabIndex = 11;
            this.txtBad.Text = "0";
            this.txtBad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(648, 81);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 22);
            this.txtTime.TabIndex = 10;
            this.txtTime.Text = "10";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zadacha3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(360, 248);
            this.dataGridView1.TabIndex = 18;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 125;
            // 
            // zadacha3BindingSource
            // 
            this.zadacha3BindingSource.DataMember = "Zadacha3";
            this.zadacha3BindingSource.DataSource = this.dataSet1;
            // 
            // zadacha3TableAdapter
            // 
            this.zadacha3TableAdapter.ClearBeforeFill = true;
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
            // Zadacha3v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBad);
            this.Controls.Add(this.txtTime);
            this.Name = "Zadacha3v2";
            this.Text = "Zadacha3v2";
            this.Load += new System.EventHandler(this.Zadacha3v2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBad;
        private System.Windows.Forms.TextBox txtTime;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zadacha3BindingSource;
        private DataSet1TableAdapters.Zadacha3TableAdapter zadacha3TableAdapter;
        private System.Windows.Forms.BindingSource normBindingSource;
        private DataSet1TableAdapters.normTableAdapter normTableAdapter;
        private System.Windows.Forms.BindingSource sostavBindingSource;
        private DataSet1TableAdapters.sostavTableAdapter sostavTableAdapter;
        private System.Windows.Forms.BindingSource uchetBindingSource;
        private DataSet1TableAdapters.uchetTableAdapter uchetTableAdapter;
    }
}