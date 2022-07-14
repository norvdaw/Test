using System;
using System.Windows.Forms;

namespace KateKurs
{
    public partial class Alternative : Form
    {
        public Alternative()
        {
            InitializeComponent();
        }

        private void Alternative_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.uchet". При необходимости она может быть перемещена или удалена.
            this.uchetTableAdapter.Fill(this.dataSet1.uchet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.sostav". При необходимости она может быть перемещена или удалена.
            this.sostavTableAdapter.Fill(this.dataSet1.sostav);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.norm". При необходимости она может быть перемещена или удалена.
            this.normTableAdapter.Fill(this.dataSet1.norm);
       
           
        }

        private void btnNorm_Click(object sender, EventArgs e)
        {
            dgvAlt.DataSource = null;
            dgvAlt.DataSource = normBindingSource;
            this.normTableAdapter.Fill(this.dataSet1.norm);
            bindingNavigator1.BindingSource = normBindingSource;
        }

        private void btnUch_Click(object sender, EventArgs e)
        {
            dgvAlt.DataSource = null;
            dgvAlt.DataSource = uchetBindingSource;
            this.uchetTableAdapter.Fill(this.dataSet1.uchet);
            bindingNavigator1.BindingSource = uchetBindingSource;
        }

        private void btnSos_Click(object sender, EventArgs e)
        {
            dgvAlt.DataSource = null;
            dgvAlt.DataSource = sostavBindingSource;
            this.sostavTableAdapter.Fill(this.dataSet1.sostav);
            bindingNavigator1.BindingSource = sostavBindingSource;
        }
    }
}
