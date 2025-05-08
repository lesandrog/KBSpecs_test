namespace KBSpecs_test
{
    partial class Form18
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kryptonNavigator1 = new Krypton.Navigator.KryptonNavigator();
            kryptonPage1 = new Krypton.Navigator.KryptonPage();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonNavigator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPage1).BeginInit();
            kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            SuspendLayout();
            // 
            // kryptonNavigator1
            // 
            kryptonNavigator1.ControlKryptonFormFeatures = false;
            kryptonNavigator1.Location = new Point(69, 82);
            kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup;
            kryptonNavigator1.Owner = null;
            kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            kryptonNavigator1.Pages.AddRange(new Krypton.Navigator.KryptonPage[] { kryptonPage1 });
            kryptonNavigator1.SelectedIndex = 0;
            kryptonNavigator1.Size = new Size(250, 150);
            kryptonNavigator1.TabIndex = 0;
            kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            kryptonPage1.AutoHiddenSlideSize = new Size(200, 200);
            kryptonPage1.Controls.Add(kryptonPanel1);
            kryptonPage1.Flags = 65534;
            kryptonPage1.LastVisibleSet = true;
            kryptonPage1.MinimumSize = new Size(150, 50);
            kryptonPage1.Name = "kryptonPage1";
            kryptonPage1.Size = new Size(248, 123);
            kryptonPage1.Text = "kryptonPage1";
            kryptonPage1.ToolTipTitle = "Page ToolTip";
            kryptonPage1.UniqueName = "73ba6088f2014a35a36eef0690d65f18";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            kryptonPanel1.Size = new Size(248, 123);
            kryptonPanel1.TabIndex = 1;
            // 
            // Form18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kryptonNavigator1);
            Name = "Form18";
            Text = "Form18";
            ((System.ComponentModel.ISupportInitialize)kryptonNavigator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPage1).EndInit();
            kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private Krypton.Navigator.KryptonPage kryptonPage1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}