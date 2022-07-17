using System;
using System.Windows.Forms;

namespace KateKurs
{
    public partial class VIEW : Form
    {
        public VIEW()
        {
            InitializeComponent();
            this.Text = "View. Представление данных из всех таблиц в одной";
            ChangeDgv();
        }
        public void ChangeDgv()
        {
            SetDgv setDgv = new SetDgv();
            setDgv.ChangeDgv(dgvView);
        }
        private void VIEW_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.NormSosUch". При необходимости она может быть перемещена или удалена.
            this.normSosUchTableAdapter.Fill(this.dataSet11.NormSosUch);

        }
    }
}
