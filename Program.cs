using Krypton.Toolkit;
using OfficeOpenXml;
using System.Data;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace KBSpecs_test
{
    internal static class Program
    {
        public static double dpiScal;
        public static string _heightControl = "";

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

        public static void ExportToExcelWithImages(DataTable _dataTable, string _filePath)
        {
            ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");
            using ExcelPackage _excel = new();
            ExcelWorksheet _worksheet = _excel.Workbook.Worksheets.Add("Dados");
            for (int col = 0; col < _dataTable.Columns.Count; col++)
            {
                _worksheet.Cells[1, col + 1].Value = _dataTable.Columns[col].ColumnName;
            }
            for (int row = 0; row < _dataTable.Rows.Count; row++)
            {
                for (int col = 0; col < _dataTable.Columns.Count; col++)
                {
                    var _cell = _worksheet.Cells[row + 2, col + 1];

                    if (_dataTable.Rows[row][col] is Bitmap ||
                        _dataTable.Columns[col].DataType == typeof(Bitmap) ||
                        _dataTable.Columns[col].ColumnName.ToLower().Contains("image"))
                    {
                        Bitmap? _bitmap = _dataTable.Rows[row][col] as Bitmap;
                        if (_bitmap != null)
                        {
                            byte[] imageBytes;
                            using (MemoryStream ms = new())
                            {
                                _bitmap.Save(ms, ImageFormat.Bmp);
                                imageBytes = ms.ToArray();
                            }
                            using (MemoryStream ms = new(imageBytes))
                            {
                                var _picture = _worksheet.Drawings.AddPicture($"img_{row}_{col}", ms);
                                _picture.SetPosition(row + 1, 0, col, 0);
                                _worksheet.Row(row + 2).Height = 50;
                                _worksheet.Column(col + 1).Width = 20;
                            }
                        }
                    }
                    else
                    {
                        _cell.Value = _dataTable.Rows[row][col];
                    }
                }
            }

            _excel.SaveAs(new FileInfo(_filePath));
        }

        public static void loopCaptureImages(DataTable _dataTable, DataSet _dataSet, ButtonSpecAny _buttonSpecAny, int _Top, int _Left, int _Width, int _Height, int _idControl, string _stControl)
        {
            MessageBox.Show($"Style count: {Enum.GetValues(typeof(PaletteButtonStyle)).Length} Type count: {Enum.GetValues(typeof(PaletteButtonSpecStyle)).Length}");

            Bitmap _imgInherit = new(16, 16);
            Bitmap _imgStandalone = new(16, 16);
            Bitmap _imgAlternate = new(16, 16);
            Bitmap _imgLowProfile = new(16, 16);
            Bitmap _imgButtonSpec = new(16, 16);
            Bitmap _imgBreadCrumb = new(16, 16);
            Bitmap _imgCluster = new(16, 16);
            Bitmap _imgNavigatorStack = new(16, 16);
            Bitmap _imgNavigatorOverflow = new(16, 16);
            Bitmap _imgNavigatorMini = new(16, 16);
            Bitmap _imgInputControl = new(16, 16);
            Bitmap _imgListItem = new(16, 16);
            Bitmap _imgForm = new(16, 16);
            Bitmap _imgFormClose = new(16, 16);
            Bitmap _imgCommand = new(16, 16);
            Bitmap _imgCustom1 = new(16, 16);
            Bitmap _imgCustom2 = new(16, 16);
            Bitmap _imgCustom3 = new(16, 16);

            string _strInherit = "";
            string _strStandalone = "";
            string _strAlternate = "";
            string _strLowProfile = "";
            string _strButtonSpec = "";
            string _strBreadCrumb = "";
            string _strCluster = "";
            string _strNavigatorStack = "";
            string _strNavigatorOverflow = "";
            string _strNavigatorMini = "";
            string _strInputControl = "";
            string _strListItem = "";
            string _strForm = "";
            string _strFormClose = "";
            string _strCommand = "";
            string _strCustom1 = "";
            string _strCustom2 = "";
            string _strCustom3 = "";
            int _idType = 0;

            if (_dataTable.DataSet != null)
            {
                _dataSet.Tables.Clear();
                _dataTable.Clear();
            }
            else
            {
                _dataSet.Tables.Add(_dataTable);
            }

            foreach (PaletteButtonSpecStyle type in Enum.GetValues(typeof(PaletteButtonSpecStyle)))
            {
                _buttonSpecAny.Type = type;
                if (type == PaletteButtonSpecStyle.Generic)
                {
                    _buttonSpecAny.Image = Properties.Resources._1;
                }
                else
                {
                    _buttonSpecAny.Image = null;
                }

                Image _image = _buttonSpecAny.GetImage(KryptonManager.CurrentGlobalPalette, PaletteState.Normal) ?? new Bitmap(16, 16);
                Clipboard.SetImage(_image);
                string _size = $"{_image.Width}x{_image.Height}";
                _idType += 1;

                foreach (PaletteButtonStyle style in Enum.GetValues(typeof(PaletteButtonStyle)))
                {
                    _buttonSpecAny.Style = style;
                    MessageBoxAutoClose.Show("Sucess", 50);
                    Bitmap _buttonImage = new(_Width, _Height);
                    Graphics g = Graphics.FromImage(_buttonImage);
                    g.CopyFromScreen(new Point(_Left, _Top), new Point(0, 0), _buttonImage.Size);
                    Clipboard.SetImage(_buttonImage);

                    switch (style)
                    {
                        case PaletteButtonStyle.Inherit:
                            _imgInherit = _buttonImage;
                            _strInherit = _heightControl;
                            break;
                        case PaletteButtonStyle.Standalone:
                            _imgStandalone = _buttonImage;
                            _strStandalone = _heightControl;
                            break;
                        case PaletteButtonStyle.Alternate:
                            _imgAlternate = _buttonImage;
                            _strAlternate = _heightControl;
                            break;
                        case PaletteButtonStyle.LowProfile:
                            _imgLowProfile = _buttonImage;
                            _strLowProfile = _heightControl;
                            break;
                        case PaletteButtonStyle.ButtonSpec:
                            _imgButtonSpec = _buttonImage;
                            _strButtonSpec = _heightControl;
                            break;
                        case PaletteButtonStyle.BreadCrumb:
                            _imgBreadCrumb = _buttonImage;
                            _strBreadCrumb = _heightControl;
                            break;
                        case PaletteButtonStyle.Cluster:
                            _imgCluster = _buttonImage;
                            _strCluster = _heightControl;
                            break;
                        case PaletteButtonStyle.NavigatorStack:
                            _imgNavigatorStack = _buttonImage;
                            _strNavigatorStack = _heightControl;
                            break;
                        case PaletteButtonStyle.NavigatorOverflow:
                            _imgNavigatorOverflow = _buttonImage;
                            _strNavigatorOverflow = _heightControl;
                            break;
                        case PaletteButtonStyle.NavigatorMini:
                            _imgNavigatorMini = _buttonImage;
                            _strNavigatorMini = _heightControl;
                            break;
                        case PaletteButtonStyle.InputControl:
                            _imgInputControl = _buttonImage;
                            _strInputControl = _heightControl;
                            break;
                        case PaletteButtonStyle.ListItem:
                            _imgListItem = _buttonImage;
                            _strListItem = _heightControl;
                            break;
                        case PaletteButtonStyle.Form:
                            _imgForm = _buttonImage;
                            _strForm = _heightControl;
                            break;
                        case PaletteButtonStyle.FormClose:
                            _imgFormClose = _buttonImage;
                            _strFormClose = _heightControl;
                            break;
                        case PaletteButtonStyle.Command:
                            _imgCommand = _buttonImage;
                            _strCommand = _heightControl;
                            break;
                        case PaletteButtonStyle.Custom1:
                            _imgCustom1 = _buttonImage;
                            _strCustom1 = _heightControl;
                            break;
                        case PaletteButtonStyle.Custom2:
                            _imgCustom2 = _buttonImage;
                            _strCustom2 = _heightControl;
                            break;
                        case PaletteButtonStyle.Custom3:
                            _imgCustom3 = _buttonImage;
                            _strCustom3 = _heightControl;
                            break;
                        default:
                            break;
                    }
                }
                _dataTable.Rows.Add(_idControl, _stControl, _idType, $"{type}", _image, _size,
                    _imgInherit, _strInherit,
                    _imgStandalone, _strStandalone,
                    _imgAlternate, _strAlternate,
                    _imgLowProfile, _strLowProfile,
                    _imgButtonSpec, _strButtonSpec,
                    _imgBreadCrumb, _strBreadCrumb,
                    _imgCluster, _strCluster,
                    _imgNavigatorStack, _strNavigatorStack,
                    _imgNavigatorOverflow, _strNavigatorOverflow,
                    _imgNavigatorMini, _strNavigatorMini,
                    _imgInputControl, _strInputControl,
                    _imgListItem, _strListItem,
                    _imgForm, _strForm,
                    _imgFormClose, _strFormClose,
                    _imgCommand, _strCommand,
                    _imgCustom1, _strCustom1,
                    _imgCustom2, _strCustom2,
                    _imgCustom3, _strCustom3);
            }

        }

    }

}