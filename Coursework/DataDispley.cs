using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KateKurs
{
    public partial class DataDispley : Form
    {
        public DataDispley()
        {
            InitializeComponent();
            this.Text = "Курсовая работа";
            ChangeDgv();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnRes_Click(object sender, EventArgs e)
        {
            Result();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void вариант1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task1 z11 = new Task1();
            z11.ShowDialog();
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIEW view = new VIEW();
            view.ShowDialog();
        }


        private void задача1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task1 z11 = new Task1();
            z11.ShowDialog();
        }

        private void dgvUch_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = uchetBindingSource;
            lblTable.Text = "Учет";
            dgvUch.DataSource = uchetBindingSource;
        }


        private void dgvSost_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = sostavBindingSource;
            lblTable.Text = "Состав";
            dgvUch.DataSource = sostav_uchetBS;
        }



        private void dgvNorm_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = normBindingSource;
            lblTable.Text = "Норма";
            dgvUch.DataSource = norm_uchetBS;
        }

        private void задача3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task3 z31 = new Task3();
            z31.ShowDialog();
        }

        private void альтернативнаяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataDispleyAlternative a = new DataDispleyAlternative();
            a.ShowDialog();
        }

        private void ChangeDgv()
        {
            SetDgv setDgv = new SetDgv();
            setDgv.ChangeDgv(dgvNorm);
            setDgv.ChangeDgv(dgvSost);
            setDgv.ChangeDgv(dgvUch);
        }

        private void Save()
        {
            try
            {

                this.normTableAdapter.Update(this.dataSet1.norm);
                this.sostavTableAdapter.Update(this.dataSet1.sostav);
                this.uchetTableAdapter.Update(this.dataSet1.uchet);
                MessageBox.Show("Изменения сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Result()
        {

            try
            {
                string conStr = Properties.Settings.Default.proektConnectionString;
                int id_worker = Int32.Parse(txtCode.Text);
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = con,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "A_proc",


                };
                cmd.Parameters.AddWithValue("@id_worker", id_worker);

                SqlParameter par = new SqlParameter()
                {
                    ParameterName = "@kolvo_good",
                    Direction = ParameterDirection.Output,
                    SqlDbType = SqlDbType.Decimal
                };


                cmd.Parameters.Add(par);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    string result = cmd.Parameters["@kolvo_good"].Value.ToString();
                    lblRes.Text = $"Количество небракованных деталей, сделанных рабочим: {result}";
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
        private void Next()
        {
            try
            {
                int col = dgvUch.CurrentCell.ColumnIndex;
                int row = dgvUch.CurrentCell.RowIndex;
                dgvUch.CurrentCell = dgvUch[col,
                     (row + 1) % dgvUch.RowCount];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.norm". При необходимости она может быть перемещена или удалена.
            this.normTableAdapter.Fill(this.dataSet1.norm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.uchet". При необходимости она может быть перемещена или удалена.
            this.uchetTableAdapter.Fill(this.dataSet1.uchet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.sostav". При необходимости она может быть перемещена или удалена.
            this.sostavTableAdapter.Fill(this.dataSet1.sostav);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.norm". При необходимости она может быть перемещена или удалена.
            this.normTableAdapter.Fill(this.dataSet1.norm);

        }

    }
}
