using Cafeteria.App.school_cafeteriaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria.App
{
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }

        private void питаниеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.питаниеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.school_cafeteriaDataSet);

        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_cafeteriaDataSet.Питание". При необходимости она может быть перемещена или удалена.
            this.питаниеTableAdapter.Fill(this.school_cafeteriaDataSet.Питание);

        }

        private void btnSearchData(object sender, EventArgs e) => Search.SearchData(питаниеDataGridView, textBoxSearch);

        private void btnFilterData(object sender, EventArgs e)
        {
            school_cafeteriaDataSet.ПитаниеDataTable dataTable = new school_cafeteriaDataSet.ПитаниеDataTable();
            питаниеTableAdapter.Fill(dataTable);
            string filter = textBoxFilter.Text;

            if (!string.IsNullOrWhiteSpace(filter))
            {
                dataTable.DefaultView.RowFilter = string.Format("Наименование = '{0}'", filter);
            }
            else
            {
                dataTable.DefaultView.RowFilter = string.Empty;
            }

            питаниеDataGridView.DataSource = dataTable;
        }
    }
}
