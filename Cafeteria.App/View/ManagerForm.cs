using System;
using System.Windows.Forms;

namespace Cafeteria.App
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_cafeteriaDataSet.Заведующие". При необходимости она может быть перемещена или удалена.
            this.заведующиеTableAdapter.Fill(this.school_cafeteriaDataSet.Заведующие);

        }

        private void заведующиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заведующиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.school_cafeteriaDataSet);
        }

        private void btnFilterData(object sender, EventArgs e)
        {
            school_cafeteriaDataSet.ЗаведующиеDataTable dataTable = new school_cafeteriaDataSet.ЗаведующиеDataTable();
            заведующиеTableAdapter.Fill(dataTable);
            string filter = textBoxFilter.Text;

            if (!string.IsNullOrWhiteSpace(filter))
            {
                dataTable.DefaultView.RowFilter = string.Format("Пол = '{0}'", filter);
            }
            else
            {
                dataTable.DefaultView.RowFilter = string.Empty;
            }

            заведующиеDataGridView.DataSource = dataTable;

        }

        private void btnSearchData(object sender, EventArgs e) => Search.SearchData(заведующиеDataGridView, textBoxSearch);
    }
}
