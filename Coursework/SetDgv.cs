using System.Windows.Forms;

namespace KateKurs
{
    class SetDgv
    {
        public void ChangeDgv(DataGridView t)
        {

            t.RowHeadersVisible = false;
            t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
