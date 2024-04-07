using System.Windows.Forms;

namespace Cafeteria.App
{
    public class Search
    {
        public static void SearchData(DataGridView dataGridView, TextBox textBox)
        {
            string searchText = textBox.Text.Trim();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Selected = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString() == searchText)
                    {
                        row.Selected = true;
                        dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }
            MessageBox.Show("Совпадений нет");
        }

    }
}
