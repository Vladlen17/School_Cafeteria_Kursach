using System;
using System.Windows.Forms;

namespace Cafeteria.App
{
    public partial class MainForm : Form
    {
        ManagerForm managerForm;
        FoodForm foodForm;
        FoodByClassForm foodByClassForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenManager(object sender, EventArgs e)
        {
            managerForm = new ManagerForm();
            managerForm.ShowDialog();
        }

        private void btnOpenFood(object sender, EventArgs e)
        {
            foodForm = new FoodForm();
            foodForm.ShowDialog();
        }

        private void btnOpenFoodByClass(object sender, EventArgs e)
        {
            foodByClassForm = new FoodByClassForm();
            foodByClassForm.ShowDialog();
        }

        private void btnOutputInExcel(object sender, EventArgs e)
        {
            Excel.Export("Заведующие");
            Excel.Export("Питание");
            Excel.Export("ПитаниеКлассы");
        }
    }
}
