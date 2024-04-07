using System;
using System.Windows.Forms;

namespace Cafeteria.App
{
    public partial class FoodByClassForm : Form
    {
        public FoodByClassForm()
        {
            InitializeComponent();
        }

        private void FoodByClassForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_cafeteriaDataSet.ПитаниеКлассы". При необходимости она может быть перемещена или удалена.
            this.питаниеКлассыTableAdapter.Fill(this.school_cafeteriaDataSet.ПитаниеКлассы);

        }

        private void btnSearchData(object sender, EventArgs e) => Search.SearchData(питаниеКлассыDataGridView, textBoxSearch);

        private void btnFilterData(object sender, EventArgs e)
        {
            school_cafeteriaDataSet.ПитаниеКлассыDataTable dataTable = new school_cafeteriaDataSet.ПитаниеКлассыDataTable();
            питаниеКлассыTableAdapter.Fill(dataTable);
            string filter = textBoxFilter.Text;

            if (!string.IsNullOrWhiteSpace(filter))
            {
                dataTable.DefaultView.RowFilter = string.Format("ДеньНедели = '{0}'", filter);
            }
            else
            {
                dataTable.DefaultView.RowFilter = string.Empty;
            }

            питаниеКлассыDataGridView.DataSource = dataTable;
        }

        private void питаниеКлассыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.питаниеКлассыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.school_cafeteriaDataSet);
        }
    }
}
