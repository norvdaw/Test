
namespace KateKurs
{
    partial class VIEW
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
            this.dataSet1 = new KateKurs.DataSet1();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.номерРабочегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерДеталиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерОперацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыполненияРаботDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерПрофессииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.разрядРабочегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяВыполненияРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЦехаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерУчасткаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоБракаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоГодныхДеталейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normSosUchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new KateKurs.DataSet1();
            this.normSosUchTableAdapter = new KateKurs.DataSet1TableAdapters.NormSosUchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normSosUchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvView
            // 
            this.dgvView.AutoGenerateColumns = false;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерРабочегоDataGridViewTextBoxColumn,
            this.номерДеталиDataGridViewTextBoxColumn,
            this.номерОперацииDataGridViewTextBoxColumn,
            this.датаВыполненияРаботDataGridViewTextBoxColumn,
            this.номерПрофессииDataGridViewTextBoxColumn,
            this.разрядРабочегоDataGridViewTextBoxColumn,
            this.времяВыполненияРаботыDataGridViewTextBoxColumn,
            this.номерЦехаDataGridViewTextBoxColumn,
            this.номерУчасткаDataGridViewTextBoxColumn,
            this.количествоБракаDataGridViewTextBoxColumn,
            this.количествоГодныхДеталейDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn});
            this.dgvView.DataSource = this.normSosUchBindingSource;
            this.dgvView.Location = new System.Drawing.Point(13, 12);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowHeadersWidth = 51;
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.Size = new System.Drawing.Size(1357, 529);
            this.dgvView.TabIndex = 1;
            // 
            // номерРабочегоDataGridViewTextBoxColumn
            // 
            this.номерРабочегоDataGridViewTextBoxColumn.DataPropertyName = "Номер рабочего";
            this.номерРабочегоDataGridViewTextBoxColumn.HeaderText = "Номер рабочего";
            this.номерРабочегоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерРабочегоDataGridViewTextBoxColumn.Name = "номерРабочегоDataGridViewTextBoxColumn";
            this.номерРабочегоDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерДеталиDataGridViewTextBoxColumn
            // 
            this.номерДеталиDataGridViewTextBoxColumn.DataPropertyName = "Номер детали";
            this.номерДеталиDataGridViewTextBoxColumn.HeaderText = "Номер детали";
            this.номерДеталиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерДеталиDataGridViewTextBoxColumn.Name = "номерДеталиDataGridViewTextBoxColumn";
            this.номерДеталиDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерОперацииDataGridViewTextBoxColumn
            // 
            this.номерОперацииDataGridViewTextBoxColumn.DataPropertyName = "Номер операции";
            this.номерОперацииDataGridViewTextBoxColumn.HeaderText = "Номер операции";
            this.номерОперацииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерОперацииDataGridViewTextBoxColumn.Name = "номерОперацииDataGridViewTextBoxColumn";
            this.номерОперацииDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаВыполненияРаботDataGridViewTextBoxColumn
            // 
            this.датаВыполненияРаботDataGridViewTextBoxColumn.DataPropertyName = "Дата выполнения работ";
            this.датаВыполненияРаботDataGridViewTextBoxColumn.HeaderText = "Дата выполнения работ";
            this.датаВыполненияРаботDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаВыполненияРаботDataGridViewTextBoxColumn.Name = "датаВыполненияРаботDataGridViewTextBoxColumn";
            this.датаВыполненияРаботDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерПрофессииDataGridViewTextBoxColumn
            // 
            this.номерПрофессииDataGridViewTextBoxColumn.DataPropertyName = "Номер профессии";
            this.номерПрофессииDataGridViewTextBoxColumn.HeaderText = "Номер профессии";
            this.номерПрофессииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерПрофессииDataGridViewTextBoxColumn.Name = "номерПрофессииDataGridViewTextBoxColumn";
            this.номерПрофессииDataGridViewTextBoxColumn.Width = 125;
            // 
            // разрядРабочегоDataGridViewTextBoxColumn
            // 
            this.разрядРабочегоDataGridViewTextBoxColumn.DataPropertyName = "Разряд рабочего";
            this.разрядРабочегоDataGridViewTextBoxColumn.HeaderText = "Разряд рабочего";
            this.разрядРабочегоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.разрядРабочегоDataGridViewTextBoxColumn.Name = "разрядРабочегоDataGridViewTextBoxColumn";
            this.разрядРабочегоDataGridViewTextBoxColumn.Width = 125;
            // 
            // времяВыполненияРаботыDataGridViewTextBoxColumn
            // 
            this.времяВыполненияРаботыDataGridViewTextBoxColumn.DataPropertyName = "Время выполнения работы";
            this.времяВыполненияРаботыDataGridViewTextBoxColumn.HeaderText = "Время выполнения работы";
            this.времяВыполненияРаботыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяВыполненияРаботыDataGridViewTextBoxColumn.Name = "времяВыполненияРаботыDataGridViewTextBoxColumn";
            this.времяВыполненияРаботыDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерЦехаDataGridViewTextBoxColumn
            // 
            this.номерЦехаDataGridViewTextBoxColumn.DataPropertyName = "Номер цеха";
            this.номерЦехаDataGridViewTextBoxColumn.HeaderText = "Номер цеха";
            this.номерЦехаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерЦехаDataGridViewTextBoxColumn.Name = "номерЦехаDataGridViewTextBoxColumn";
            this.номерЦехаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерУчасткаDataGridViewTextBoxColumn
            // 
            this.номерУчасткаDataGridViewTextBoxColumn.DataPropertyName = "Номер участка";
            this.номерУчасткаDataGridViewTextBoxColumn.HeaderText = "Номер участка";
            this.номерУчасткаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерУчасткаDataGridViewTextBoxColumn.Name = "номерУчасткаDataGridViewTextBoxColumn";
            this.номерУчасткаDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоБракаDataGridViewTextBoxColumn
            // 
            this.количествоБракаDataGridViewTextBoxColumn.DataPropertyName = "Количество брака";
            this.количествоБракаDataGridViewTextBoxColumn.HeaderText = "Количество брака";
            this.количествоБракаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоБракаDataGridViewTextBoxColumn.Name = "количествоБракаDataGridViewTextBoxColumn";
            this.количествоБракаDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоГодныхДеталейDataGridViewTextBoxColumn
            // 
            this.количествоГодныхДеталейDataGridViewTextBoxColumn.DataPropertyName = "Количество годных деталей";
            this.количествоГодныхДеталейDataGridViewTextBoxColumn.HeaderText = "Количество годных деталей";
            this.количествоГодныхДеталейDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоГодныхДеталейDataGridViewTextBoxColumn.Name = "количествоГодныхДеталейDataGridViewTextBoxColumn";
            this.количествоГодныхДеталейDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 125;
            // 
            // normSosUchBindingSource
            // 
            this.normSosUchBindingSource.DataMember = "NormSosUch";
            this.normSosUchBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // normSosUchTableAdapter
            // 
            this.normSosUchTableAdapter.ClearBeforeFill = true;
            // 
            // VIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 553);
            this.Controls.Add(this.dgvView);
            this.Name = "VIEW";
            this.Text = "VIEW";
            this.Load += new System.EventHandler(this.VIEW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normSosUchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dgvView;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource normSosUchBindingSource;
        private DataSet1TableAdapters.NormSosUchTableAdapter normSosUchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерРабочегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДеталиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОперацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыполненияРаботDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПрофессииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn разрядРабочегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяВыполненияРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЦехаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерУчасткаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоБракаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоГодныхДеталейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
    }
}