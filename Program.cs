using OfficeOpenXml;
using System.Data;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace KBSpecs_test
{
    internal static class Program
    {
        public static double dpiScal;

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern uint GetDpiForWindow(IntPtr hwnd);

        [STAThread]
        static void Main()
        {
            IntPtr hWnd = GetForegroundWindow();
            uint dpi = GetDpiForWindow(hWnd);
            dpiScal = (int)dpi;
            dpiScal = dpiScal / 96;

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static void ExportToExcelWithImages(DataTable dt, string filePath)
        {
            ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");
            using (ExcelPackage excel = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("Dados");
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    worksheet.Cells[1, col + 1].Value = dt.Columns[col].ColumnName;
                }
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        var cell = worksheet.Cells[row + 2, col + 1];

                        if (dt.Rows[row][col] is Bitmap ||
                            dt.Columns[col].DataType == typeof(Bitmap) ||
                            dt.Columns[col].ColumnName.ToLower().Contains("image"))
                        {
                            Bitmap bitmap = dt.Rows[row][col] as Bitmap;
                            if (bitmap != null)
                            {
                                byte[] imageBytes;
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    bitmap.Save(ms, ImageFormat.Bmp);
                                    imageBytes = ms.ToArray();
                                }
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    var picture = worksheet.Drawings.AddPicture($"img_{row}_{col}", ms);
                                    picture.SetPosition(row + 1, 0, col, 0);
                                    worksheet.Row(row + 2).Height = 50;
                                    worksheet.Column(col + 1).Width = 20;
                                }
                            }
                        }
                        else
                        {
                            cell.Value = dt.Rows[row][col];
                        }
                    }
                }

                excel.SaveAs(new FileInfo(filePath));
            }
        }
       
    }

}