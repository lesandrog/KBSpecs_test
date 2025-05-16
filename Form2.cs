
using System.Data;
using Krypton.Toolkit;


namespace KBSpecs_test
{
    public partial class Form2 : KryptonForm
    {
        public string _nameControl = "KTextBox.ButtonSpec";
        public string _namefile = "KTextBox";
        public int _idControl = 1;
        public DataSet _dataSet1 = new();
        public DataTable _dataTable1 = new("dataTable1");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _dataTable1.Columns.Add("idControl", typeof(int));
            _dataTable1.Columns.Add("Control", typeof(string));
            _dataTable1.Columns.Add("idType", typeof(int));
            _dataTable1.Columns.Add("Type", typeof(string));
            _dataTable1.Columns.Add("Image", typeof(Image));
            _dataTable1.Columns.Add("Size (W x H)", typeof(string));
            _dataTable1.Columns.Add("Inherit - Image", typeof(Image));
            _dataTable1.Columns.Add("Inherit - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("Standalone - Image", typeof(Image));
            _dataTable1.Columns.Add("Standalone - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("Alternate - Image", typeof(Image));
            _dataTable1.Columns.Add("Alternate - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("LowProfile - Image", typeof(Image));
            _dataTable1.Columns.Add("LowProfile - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("ButtonSpec - Image", typeof(Image));
            _dataTable1.Columns.Add("ButtonSpec - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("BreadCrumb - Image", typeof(Image));
            _dataTable1.Columns.Add("BreadCrumb - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("Cluster - Image", typeof(Image));
            _dataTable1.Columns.Add("Cluster - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("NavigatorStack - Image", typeof(Image));
            _dataTable1.Columns.Add("NavigatorStack - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("NavigatorOverflow - Image", typeof(Image));
            _dataTable1.Columns.Add("NavigatorOverflow - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("NavigatorMini - Image", typeof(Image));
            _dataTable1.Columns.Add("NavigatorMini - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("InputControl - Image", typeof(Image));
            _dataTable1.Columns.Add("InputControl - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("ListItem - Image", typeof(Image));
            _dataTable1.Columns.Add("ListItem - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("Form - Image", typeof(Image));
            _dataTable1.Columns.Add("Form - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("FormClose - Image", typeof(Image));
            _dataTable1.Columns.Add("FormClose - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("Command - Image", typeof(Image));
            _dataTable1.Columns.Add("Command - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("Custom1 - Image", typeof(Image));
            _dataTable1.Columns.Add("Custom1 - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("Custom2 - Image", typeof(Image));
            _dataTable1.Columns.Add("Custom2 - Size (H) of Control", typeof(string));
            _dataTable1.Columns.Add("Custom3 - Image", typeof(Image));
            _dataTable1.Columns.Add("Custom3 - Size (H) of Control", typeof(string));
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = _dataTable1;
            int _sizeWidht = (int)(70 * Program.dpiScal);
            int _sizeHeigth = (int)(50 * Program.dpiScal);
            int _positionTop = (int)((Top + 45) * Program.dpiScal);
            int _positionLeft = (int)((Left + 111) * Program.dpiScal);
            Program.loopCaptureImages(_dataTable1, _dataSet1, buttonSpecAny1, _positionTop, _positionLeft, _sizeWidht, _sizeHeigth, _idControl, _nameControl);

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            int _sizeWidht = (int)(167 * Program.dpiScal);
            int _sizeHeigth = (int)(50 * Program.dpiScal);
            int _positionTop = (int)((Top + 45) * Program.dpiScal);
            int _positionLeft = (int)((Left + 14) * Program.dpiScal);
            Bitmap _buttonImage = new(_sizeWidht, _sizeHeigth);
            Graphics g = Graphics.FromImage(_buttonImage);
            g.CopyFromScreen(new Point(_positionLeft, _positionTop), new Point(0, 0), _buttonImage.Size);
            Clipboard.SetImage(_buttonImage);
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Image _image = buttonSpecAny1.GetImage(KryptonManager.CurrentGlobalPalette, PaletteState.Normal) ?? new Bitmap(16, 16);
            Clipboard.SetImage(_image);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Program.ExportToExcelWithImages(_dataTable1, @"C:\Krypton\" + _namefile + ".xlsx");
            MessageBox.Show($"salve ok");
        }

        private void kryptonTextBox1_SizeChanged(object sender, EventArgs e)
        {
            Program._heightControl = $"{kryptonTextBox1.Height}";
        }

    }
}
