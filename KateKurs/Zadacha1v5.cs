using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KateKurs
{
    public partial class Zadacha1v5 : Form
    {
        public Zadacha1v5()
        {
            InitializeComponent();
        }

        private void FillByReader()
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
                    dgvZad1v5.DataSource = dt;
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
        private void btnFill_Click(object sender, EventArgs e)
        {
            FillByReader();
        }

        private void Zadacha1v5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.uchet". При необходимости она может быть перемещена или удалена.
            this.uchetTableAdapter.Fill(this.dataSet1.uchet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.sostav". При необходимости она может быть перемещена или удалена.
            this.sostavTableAdapter.Fill(this.dataSet1.sostav);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.record". При необходимости она может быть перемещена или удалена.


        }
    }
}
