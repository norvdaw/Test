using System;
using System.Windows.Forms;

namespace KateKurs
{
    public partial class VIEW : Form
    {
        public VIEW()
        {
            InitializeComponent();
            dgvView.RowHeadersVisible = false;
            dgvView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }

        private void VIEW_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.NormSosUch". При необходимости она может быть перемещена или удалена.
            this.normSosUchTableAdapter.Fill(this.dataSet11.NormSosUch);


        }
    }
}
