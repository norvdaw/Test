using System;
using System.Windows.Forms;

namespace KateKurs
{
    public partial class Zadacha3v1 : Form
    {
        public Zadacha3v1()
        {
            InitializeComponent();
            dgvZ3v1.RowHeadersVisible = false;
            dgvZ3v1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FillDGV();
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            FillDGV();
        }
        private void FillDGV()
        {
            try
            {
                var time_one = int.Parse(txtTime.Text);
                var kolvo_bad = int.Parse(txtBad.Text);
                zadacha3TableAdapter.Fill(dataSet1.Zadacha3, time_one, kolvo_bad);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void btnOnForm_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
