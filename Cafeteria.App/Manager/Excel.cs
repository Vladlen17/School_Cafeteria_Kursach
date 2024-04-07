using System.Data.SqlClient;
using System.Data;
using System.IO;
using OfficeOpenXml;
using System.Windows;

namespace Cafeteria.App
{
    public class Excel
    {
        private readonly static string _connectionString = "Data Source=VLADLENPC\\SQLEXPRESS;Initial Catalog=school_cafeteria;Persist Security Info=True;User ID=sa;Password=11111111;TrustServerCertificate=True";
        public static void Export(string table)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string filePath = "DataTables.xlsx";
            string query = $"SELECT * FROM {table}";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }

            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[$"{table}"] ?? excelPackage.Workbook.Worksheets.Add($"{table}");

                int startRow = worksheet.Dimension?.Rows ?? 1;

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[startRow + i, j + 1].Value = dataTable.Rows[i][j];
                    }
                }

                excelPackage.Save();
            }

            MessageBox.Show($"Данные из таблицы {table} успешно добавлены в Excel", "Экспорт в файл Excel", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
