
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEW));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataSet1 = new KateKurs.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet11 = new KateKurs.DataSet1();
            this.normSosUchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normSosUchTableAdapter = new KateKurs.DataSet1TableAdapters.NormSosUchTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normSosUchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1453, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
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
            this.dataGridView1.DataSource = this.normSosUchBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1411, 307);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // normSosUchBindingSource
            // 
            this.normSosUchBindingSource.DataMember = "NormSosUch";
            this.normSosUchBindingSource.DataSource = this.dataSet11;
            // 
            // normSosUchTableAdapter
            // 
            this.normSosUchTableAdapter.ClearBeforeFill = true;
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
            // VIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "VIEW";
            this.Text = "VIEW";
            this.Load += new System.EventHandler(this.VIEW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normSosUchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
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