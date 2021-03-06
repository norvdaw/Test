using System;
using System.Windows.Forms;

namespace KateKurs
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
            this.Text = "Task 3. ФИО рабочих, по заданным параметрам";
            ChangeDgv();
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            FillVar1();
        }
        private void btnVar2_Click(object sender, EventArgs e)
        {
            FillVar2();
        }
        public void ChangeDgv()
        {
            SetDgv setDgv = new SetDgv();
            setDgv.ChangeDgv(dgvTask3);
        }
        private void FillVar1()
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
        private void FillVar2()
        {
            var time_one = int.Parse(txtTime.Text);
            var kolvo_bad = int.Parse(txtBad.Text);
            dataSet1.Zadacha3.Clear();
            foreach (DataSet1.sostavRow sRow in dataSet1.sostav.Rows)
            {
                bool temp1 = true;
                foreach (DataSet1.normRow nRow in dataSet1.norm.Rows)
                {

                    if (nRow.time_one > time_one & sRow.id_prof == nRow.id_prof & sRow.razryad == nRow.razryad)
                    {
                        foreach (DataSet1.uchetRow uRow in dataSet1.uchet.Rows)
                        {
                            if (uRow.id_worker == sRow.id_worker & uRow.id_detail == nRow.id_detail & uRow.id_oper == nRow.id_oper & uRow.kolvo_bad > kolvo_bad)
                            {
                                temp1 = false;
                                break;
                            }
                        }
                        if (temp1)
                        {
                            DataSet1.Zadacha3Row zRow = dataSet1.Zadacha3.NewZadacha3Row();
                            zRow.FIO = sRow.FIO;
                            dataSet1.Zadacha3.Rows.Add(zRow);
                        }
                    }
                    else continue;
                }

            }
        }

        private void Task3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.norm". При необходимости она может быть перемещена или удалена.
            this.normTableAdapter.Fill(this.dataSet1.norm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.uchet". При необходимости она может быть перемещена или удалена.
            this.uchetTableAdapter.Fill(this.dataSet1.uchet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.sostav". При необходимости она может быть перемещена или удалена.
            this.sostavTableAdapter.Fill(this.dataSet1.sostav);
        }
    }
}
