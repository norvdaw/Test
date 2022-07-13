using System;
using System.Data;
using System.Windows.Forms;

namespace KateKurs
{
    public partial class Zadacha1v3 : Form
    {
        public Zadacha1v3()
        {
            InitializeComponent();
        }

        private void QeryZapr3()
        {
            try
            {
                dataSet1.Zadacha1.Clear();
                int num = int.Parse(txtBad.Text);
                DataRowCollection rows = dataSet1.uchet.Rows;
                foreach (DataSet1.uchetRow uRow in rows)
                {

                    DataSet1.Zadacha1Row zRow = dataSet1.Zadacha1.NewZadacha1Row();

                    DataSet1.sostavRow sRow = dataSet1.sostav.FindByid_worker(uRow.id_worker);
                    if (uRow.kolvo_bad > num)
                        continue;
                    zRow.id_ceh = sRow.id_ceh;
                    zRow.id_detail = uRow.id_detail;
                    zRow.kolvo_bad = uRow.kolvo_bad;
                    zRow.kolvo_good = uRow.kolvo_good;
                    dataSet1.Zadacha1.Rows.Add(zRow);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            QeryZapr3();
        }

        private void Zadacha1v3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.uchet". При необходимости она может быть перемещена или удалена.
            this.uchetTableAdapter.Fill(this.dataSet1.uchet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.sostav". При необходимости она может быть перемещена или удалена.
            this.sostavTableAdapter.Fill(this.dataSet1.sostav);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.record". При необходимости она может быть перемещена или удалена.

        }
    }
}
