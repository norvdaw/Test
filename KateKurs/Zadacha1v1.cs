using System;
using System.Windows.Forms;

namespace KateKurs
{
    public partial class Zadacha1v1 : Form
    {
        public Zadacha1v1()
        {
            InitializeComponent();
        }

        private void fill1DGV()
        {

            int kolvo_bad = int.Parse(txtBad.Text);
            zadacha1TableAdapter.Fill(dataSet1.Zadacha1, kolvo_bad);

        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            fill1DGV();
        }




    }
}
