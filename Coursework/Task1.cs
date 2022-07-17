using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KateKurs
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            this.Text = "Task 1. Сведения об учёте выработки";
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

        private void btnVar3_Click(object sender, EventArgs e)
        {
            FillVar3();
        }

        private void btnVar4_Click(object sender, EventArgs e)
        {
            FillVar4();
        }

        private void btnVar5_Click(object sender, EventArgs e)
        {
            FillVar5();
        }
        public void ChangeDgv()
        {
            SetDgv setDgv = new SetDgv();
            setDgv.ChangeDgv(dgvTask1);
        }
        private void FillVar1()
        {

            int kolvo_bad = int.Parse(txtBad.Text);
            zadacha1TableAdapter.Fill(dataSet1.Zadacha1, kolvo_bad);

        }
        private void FillVar2()
        {
            try
            {
                dataSet1.Zadacha1.Clear();
                int num = int.Parse(txtBad.Text);
                DataRowCollection rows = dataSet1.uchet.Rows;
                foreach (DataSet1.uchetRow uRow in rows)
                {
                    if (uRow.kolvo_bad > num)
                        continue;
                    DataSet1.Zadacha1Row zRow = dataSet1.Zadacha1.NewZadacha1Row();
                    foreach (DataSet1.sostavRow sRow in dataSet1.sostav.Rows)
                    {
                        if (uRow.id_worker != sRow.id_worker)
                            continue;
                        zRow.id_ceh = sRow.id_ceh;
                        zRow.id_detail = uRow.id_detail;
                        zRow.kolvo_bad = uRow.kolvo_bad;
                        zRow.kolvo_good = uRow.kolvo_good;
                    }

                    dataSet1.Zadacha1.Rows.Add(zRow);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FillVar3()
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
        private void FillVar4()
        {
            try
            {
                dataSet1.Zadacha1.Clear();
                int num = int.Parse(txtBad.Text);
                DataRowCollection rows = dataSet1.uchet.Rows;
                foreach (DataSet1.uchetRow uRow in rows)
                {
                    DataSet1.Zadacha1Row zRow = dataSet1.Zadacha1.NewZadacha1Row();
                    DataSet1.sostavRow iRow = uRow.GetParentRow("uchet_sostav") as DataSet1.sostavRow;
                    if (uRow.kolvo_bad > num)
                        continue;
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

        private void FillVar5()
        {
            string conStr = Properties.Settings.Default.proektConnectionString;
            try
            {
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = con,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT sostav.id_ceh, uchet.id_detail, uchet.kolvo_bad, uchet.kolvo_good" +
                            " FROM " +
                            "sostav INNER JOIN " +
                            "uchet ON (sostav.id_worker = uchet.id_worker)" +
                            "WHERE  (uchet.kolvo_bad <= @kolvo_bad)"

                };
                cmd.Parameters.AddWithValue("@kolvo_bad", int.Parse(txtBad.Text));

                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    dgvTask1.DataSource = dt;
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    zadacha1BindingSource = bs;
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Task1_Load(object sender, EventArgs e)
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
