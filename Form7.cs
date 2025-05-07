
using System.Data;
using Krypton.Toolkit;


namespace KBSpecs_test
{
    public partial class Form7 : KryptonForm
    {
        public DataSet dataSet = new DataSet();
        public string s_control = "KNumericUpDown"; 
        public int s_idControl = 6;
        public DataTable dataTable1 = new DataTable("dataTable1");

        public Form7()
        {
            InitializeComponent();

            dataTable1.Columns.Add("idControl", typeof(int));
            dataTable1.Columns.Add("Control", typeof(string));
            dataTable1.Columns.Add("idType", typeof(int));
            dataTable1.Columns.Add("Type", typeof(string));
            dataTable1.Columns.Add("Image", typeof(Image));
            dataTable1.Columns.Add("Size (W x H)", typeof(string));
            dataTable1.Columns.Add("Inherit - Image", typeof(Image));
            dataTable1.Columns.Add("Inherit - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("Standalone - Image", typeof(Image));
            dataTable1.Columns.Add("Standalone - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("Alternate - Image", typeof(Image));
            dataTable1.Columns.Add("Alternate - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("LowProfile - Image", typeof(Image));
            dataTable1.Columns.Add("LowProfile - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("ButtonSpec - Image", typeof(Image));
            dataTable1.Columns.Add("ButtonSpec - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("BreadCrumb - Image", typeof(Image));
            dataTable1.Columns.Add("BreadCrumb - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("Cluster - Image", typeof(Image));
            dataTable1.Columns.Add("Cluster - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("NavigatorStack - Image", typeof(Image));
            dataTable1.Columns.Add("NavigatorStack - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("NavigatorOverflow - Image", typeof(Image));
            dataTable1.Columns.Add("NavigatorOverflow - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("NavigatorMini - Image", typeof(Image));
            dataTable1.Columns.Add("NavigatorMini - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("InputControl - Image", typeof(Image));
            dataTable1.Columns.Add("InputControl - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("ListItem - Image", typeof(Image));
            dataTable1.Columns.Add("ListItem - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("Form - Image", typeof(Image));
            dataTable1.Columns.Add("Form - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("FormClose - Image", typeof(Image));
            dataTable1.Columns.Add("FormClose - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("Command - Image", typeof(Image));
            dataTable1.Columns.Add("Command - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("Custom1 - Image", typeof(Image));
            dataTable1.Columns.Add("Custom1 - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("Custom2 - Image", typeof(Image));
            dataTable1.Columns.Add("Custom2 - Size (H) of Control", typeof(string));
            dataTable1.Columns.Add("Custom3 - Image", typeof(Image));
            dataTable1.Columns.Add("Custom3 - Size (H) of Control", typeof(string));
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Style count: {Enum.GetValues(typeof(PaletteButtonStyle)).Length} Type count: {Enum.GetValues(typeof(PaletteButtonSpecStyle)).Length}");

            Bitmap i_Inherit = new Bitmap(16, 16);
            Bitmap i_Standalone = new Bitmap(16, 16);
            Bitmap i_Alternate = new Bitmap(16, 16);
            Bitmap i_LowProfile = new Bitmap(16, 16);
            Bitmap i_ButtonSpec = new Bitmap(16, 16);
            Bitmap i_BreadCrumb = new Bitmap(16, 16);
            Bitmap i_Cluster = new Bitmap(16, 16);
            Bitmap i_NavigatorStack = new Bitmap(16, 16);
            Bitmap i_NavigatorOverflow = new Bitmap(16, 16);
            Bitmap i_NavigatorMini = new Bitmap(16, 16);
            Bitmap i_InputControl = new Bitmap(16, 16);
            Bitmap i_ListItem = new Bitmap(16, 16);
            Bitmap i_Form = new Bitmap(16, 16);
            Bitmap i_FormClose = new Bitmap(16, 16);
            Bitmap i_Command = new Bitmap(16, 16);
            Bitmap i_Custom1 = new Bitmap(16, 16);
            Bitmap i_Custom2 = new Bitmap(16, 16);
            Bitmap i_Custom3 = new Bitmap(16, 16);

            string s_Inherit = "";
            string s_Standalone = "";
            string s_Alternate = "";
            string s_LowProfile = "";
            string s_ButtonSpec = "";
            string s_BreadCrumb = "";
            string s_Cluster = "";
            string s_NavigatorStack = "";
            string s_NavigatorOverflow = "";
            string s_NavigatorMini = "";
            string s_InputControl = "";
            string s_ListItem = "";
            string s_Form = "";
            string s_FormClose = "";
            string s_Command = "";
            string s_Custom1 = "";
            string s_Custom2 = "";
            string s_Custom3 = "";
            int s_idType = 0;

            if (dataTable1.DataSet != null)
            {
                dataSet.Tables.Remove(dataTable1);
                dataTable1.Clear();
            }


            foreach (PaletteButtonSpecStyle type in Enum.GetValues(typeof(PaletteButtonSpecStyle)))
            {
                buttonSpecAny1.Type = type;
                if (type == PaletteButtonSpecStyle.Generic)
                {
                    buttonSpecAny1.Image = Properties.Resources._1;
                }
                else
                {
                    buttonSpecAny1.Image = null;
                }

                Image i_image = buttonSpecAny1.GetImage(KryptonManager.CurrentGlobalPalette, PaletteState.Normal) ?? new Bitmap(16, 16);
                Clipboard.SetImage(i_image);
                string size = $"{i_image.Width}x{i_image.Height}";
                s_idType += 1;
                //MessageBox.Show($"Image type: {type}, size: {size}");

                foreach (PaletteButtonStyle style in Enum.GetValues(typeof(PaletteButtonStyle)))
                {
                    buttonSpecAny1.Style = style;
                    //await Task.Delay(300);
                    //Application.DoEvents();
                    //MessageBox.Show($"clipboard set, type: {type}, style: {style}");
                    MessageBoxAutoClose.Show("Sucess", 50);
                    string sizestyle = $"{kryptonNumericUpDown1.Height}";
                    Bitmap buttonImage = new Bitmap(70, 50);
                    Graphics g = Graphics.FromImage(buttonImage);
                    g.CopyFromScreen(new Point(Left + 111, Top + 45), new Point(0, 0), buttonImage.Size);
                    Clipboard.SetImage(buttonImage);

                    switch (style)
                    {
                        case PaletteButtonStyle.Inherit:
                            i_Inherit = buttonImage;
                            s_Inherit = sizestyle;
                            break;
                        case PaletteButtonStyle.Standalone:
                            i_Standalone = buttonImage;
                            s_Standalone = sizestyle;
                            break;
                        case PaletteButtonStyle.Alternate:
                            i_Alternate = buttonImage;
                            s_Alternate = sizestyle;
                            break;
                        case PaletteButtonStyle.LowProfile:
                            i_LowProfile = buttonImage;
                            s_LowProfile = sizestyle;
                            break;
                        case PaletteButtonStyle.ButtonSpec:
                            i_ButtonSpec = buttonImage;
                            s_ButtonSpec = sizestyle;
                            break;
                        case PaletteButtonStyle.BreadCrumb:
                            i_BreadCrumb = buttonImage;
                            s_BreadCrumb = sizestyle;
                            break;
                        case PaletteButtonStyle.Cluster:
                            i_Cluster = buttonImage;
                            s_Cluster = sizestyle;
                            break;
                        case PaletteButtonStyle.NavigatorStack:
                            i_NavigatorStack = buttonImage;
                            s_NavigatorStack = sizestyle;
                            break;
                        case PaletteButtonStyle.NavigatorOverflow:
                            i_NavigatorOverflow = buttonImage;
                            s_NavigatorOverflow = sizestyle;
                            break;
                        case PaletteButtonStyle.NavigatorMini:
                            i_NavigatorMini = buttonImage;
                            s_NavigatorMini = sizestyle;
                            break;
                        case PaletteButtonStyle.InputControl:
                            i_InputControl = buttonImage;
                            s_InputControl = sizestyle;
                            break;
                        case PaletteButtonStyle.ListItem:
                            i_ListItem = buttonImage;
                            s_ListItem = sizestyle;
                            break;
                        case PaletteButtonStyle.Form:
                            i_Form = buttonImage;
                            s_Form = sizestyle;
                            break;
                        case PaletteButtonStyle.FormClose:
                            i_FormClose = buttonImage;
                            s_FormClose = sizestyle;
                            break;
                        case PaletteButtonStyle.Command:
                            i_Command = buttonImage;
                            s_Command = sizestyle;
                            break;
                        case PaletteButtonStyle.Custom1:
                            i_Custom1 = buttonImage;
                            s_Custom1 = sizestyle;
                            break;
                        case PaletteButtonStyle.Custom2:
                            i_Custom2 = buttonImage;
                            s_Custom2 = sizestyle;
                            break;
                        case PaletteButtonStyle.Custom3:
                            i_Custom3 = buttonImage;
                            s_Custom3 = sizestyle;
                            break;
                        default:
                            break;
                    }

                }

                dataTable1.Rows.Add(s_idControl, s_control, s_idType, $"{type}", i_image, size,
                                    i_Inherit, s_Inherit,
                                    i_Standalone, s_Standalone,
                                    i_Alternate, s_Alternate,
                                    i_LowProfile, s_LowProfile,
                                    i_ButtonSpec, s_ButtonSpec,
                                    i_BreadCrumb, s_BreadCrumb,
                                    i_Cluster, s_Cluster,
                                    i_NavigatorStack, s_NavigatorStack,
                                    i_NavigatorOverflow, s_NavigatorOverflow,
                                    i_NavigatorMini, s_NavigatorMini,
                                    i_InputControl, s_InputControl,
                                    i_ListItem, s_ListItem,
                                    i_Form, s_Form,
                                    i_FormClose, s_FormClose,
                                    i_Command, s_Command,
                                    i_Custom1, s_Custom1,
                                    i_Custom2, s_Custom2,
                                    i_Custom3, s_Custom3);
            }
            dataSet.Tables.Add(dataTable1);
            kryptonDataGridView1.DataSource = dataTable1;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            var buttonImage = new Bitmap(167, 50);
            Graphics g = Graphics.FromImage(buttonImage);
            g.CopyFromScreen(new Point(Left + 14, Top + 45), new Point(0, 0), buttonImage.Size);
            Clipboard.SetImage(buttonImage);
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Image i_image = buttonSpecAny1.GetImage(KryptonManager.CurrentGlobalPalette, PaletteState.Normal) ?? new Bitmap(16, 16);
            Clipboard.SetImage(i_image);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Program.ExportToExcelWithImages(dataTable1, @"C:\Krypton\" + s_control + ".xlsx");
            MessageBox.Show($"salve ok");
        }


    }
}
