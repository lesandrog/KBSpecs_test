using Krypton.Docking;
using Krypton.Navigator;
using Krypton.Toolkit;
using Krypton.Workspace;

namespace KBSpecs_test
{
    partial class Form17
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
            kryptonButton1 = new KryptonButton();
            kryptonButton2 = new KryptonButton();
            kryptonButton3 = new KryptonButton();
            kryptonButton4 = new KryptonButton();
            kryptonPropertyGrid1 = new KryptonPropertyGrid();
            buttonSpecNavigator1 = new ButtonSpecNavigator();
            kryptonDataGridView1 = new KryptonDataGridView();
            kryptonButton5 = new KryptonButton();
            kryptonPropertyGrid2 = new KryptonPropertyGrid();
            buttonSpecAny1 = new ButtonSpecAny();
            kryptonButton6 = new KryptonButton();
            kryptonWorkspace1 = new KryptonWorkspace();
            kryptonPage1 = new KryptonPage();
            kryptonPanel1 = new KryptonPanel();
            kryptonWorkspaceCell1 = new KryptonWorkspaceCell();
            kryptonPage2 = new KryptonPage();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonWorkspace1).BeginInit();
            kryptonWorkspace1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPage1).BeginInit();
            kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonWorkspaceCell1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPage2).BeginInit();
            SuspendLayout();
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(12, 163);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(229, 25);
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Loop capture image - BSpecAny";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(247, 177);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(186, 25);
            kryptonButton2.TabIndex = 2;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "Export to .xlsx";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonButton3.Location = new Point(807, 12);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.Size = new Size(186, 45);
            kryptonButton3.TabIndex = 3;
            kryptonButton3.Values.DropDownArrowColor = Color.Empty;
            kryptonButton3.Values.Text = "Capture control\r\nCopyFromScreen()";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // kryptonButton4
            // 
            kryptonButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonButton4.Location = new Point(1012, 12);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new Size(186, 45);
            kryptonButton4.TabIndex = 4;
            kryptonButton4.Values.DropDownArrowColor = Color.Empty;
            kryptonButton4.Values.Text = "Capture image\r\nGetImage() - BSpecNavigator";
            kryptonButton4.Click += kryptonButton4_Click;
            // 
            // kryptonPropertyGrid1
            // 
            kryptonPropertyGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonPropertyGrid1.Location = new Point(899, 63);
            kryptonPropertyGrid1.Name = "kryptonPropertyGrid1";
            kryptonPropertyGrid1.Padding = new Padding(1);
            kryptonPropertyGrid1.SelectedObject = buttonSpecNavigator1;
            kryptonPropertyGrid1.Size = new Size(299, 344);
            kryptonPropertyGrid1.TabIndex = 5;
            kryptonPropertyGrid1.Text = "kryptonPropertyGrid1";
            // 
            // buttonSpecNavigator1
            // 
            buttonSpecNavigator1.Checked = ButtonCheckState.Checked;
            buttonSpecNavigator1.UniqueName = "e02dd1741f9a4d2d96012f68d9bd2872";
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView1.Location = new Point(12, 224);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.RowTemplate.Height = 60;
            kryptonDataGridView1.Size = new Size(570, 183);
            kryptonDataGridView1.TabIndex = 6;
            // 
            // kryptonButton5
            // 
            kryptonButton5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonButton5.Location = new Point(594, 12);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.Size = new Size(186, 45);
            kryptonButton5.TabIndex = 11;
            kryptonButton5.Values.DropDownArrowColor = Color.Empty;
            kryptonButton5.Values.Text = "Capture image\r\nGetImage() - BSpecAny";
            // 
            // kryptonPropertyGrid2
            // 
            kryptonPropertyGrid2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonPropertyGrid2.Location = new Point(594, 63);
            kryptonPropertyGrid2.Name = "kryptonPropertyGrid2";
            kryptonPropertyGrid2.Padding = new Padding(1);
            kryptonPropertyGrid2.SelectedObject = buttonSpecAny1;
            kryptonPropertyGrid2.Size = new Size(299, 344);
            kryptonPropertyGrid2.TabIndex = 10;
            kryptonPropertyGrid2.Text = "kryptonPropertyGrid2";
            // 
            // buttonSpecAny1
            // 
            buttonSpecAny1.Checked = ButtonCheckState.Checked;
            buttonSpecAny1.UniqueName = "43b89cb0978f4d82a47e4b64e35c8833";
            // 
            // kryptonButton6
            // 
            kryptonButton6.Location = new Point(12, 193);
            kryptonButton6.Name = "kryptonButton6";
            kryptonButton6.Size = new Size(229, 25);
            kryptonButton6.TabIndex = 13;
            kryptonButton6.Values.DropDownArrowColor = Color.Empty;
            kryptonButton6.Values.Text = "Loop capture image - BSpecNavigator";
            // 
            // kryptonWorkspace1
            // 
            kryptonWorkspace1.ActivePage = kryptonPage1;
            kryptonWorkspace1.CompactFlags = CompactFlags.RemoveEmptyCells | CompactFlags.RemoveEmptySequences | CompactFlags.PromoteLeafs | CompactFlags.AtLeastOneVisibleCell;
            kryptonWorkspace1.ContainerBackStyle = PaletteBackStyle.PanelClient;
            kryptonWorkspace1.Location = new Point(12, 12);
            kryptonWorkspace1.Name = "kryptonWorkspace1";
            // 
            // 
            // 
            kryptonWorkspace1.Root.Children.AddRange(new System.ComponentModel.Component[] { kryptonWorkspaceCell1 });
            kryptonWorkspace1.Root.UniqueName = "e8954106852c48e2a3e86bf067d113c7";
            kryptonWorkspace1.SeparatorStyle = SeparatorStyle.LowProfile;
            kryptonWorkspace1.Size = new Size(387, 123);
            kryptonWorkspace1.SplitterWidth = 5;
            kryptonWorkspace1.TabIndex = 15;
            kryptonWorkspace1.TabStop = true;
            // 
            // kryptonPage1
            // 
            kryptonPage1.AutoHiddenSlideSize = new Size(200, 200);
            kryptonPage1.Controls.Add(kryptonPanel1);
            kryptonPage1.Flags = 65534;
            kryptonPage1.LastVisibleSet = true;
            kryptonPage1.MinimumSize = new Size(150, 50);
            kryptonPage1.Name = "kryptonPage1";
            kryptonPage1.Size = new Size(385, 96);
            kryptonPage1.Text = "kryptonPage1";
            kryptonPage1.ToolTipTitle = "Page ToolTip";
            kryptonPage1.UniqueName = "a856849e090e4a26960755716208bafe";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PanelBackStyle = PaletteBackStyle.PanelAlternate;
            kryptonPanel1.Size = new Size(385, 96);
            kryptonPanel1.TabIndex = 16;
            // 
            // kryptonWorkspaceCell1
            // 
            kryptonWorkspaceCell1.AllowPageDrag = true;
            kryptonWorkspaceCell1.AllowTabFocus = false;
            kryptonWorkspaceCell1.Button.ButtonDisplayLogic = ButtonDisplayLogic.Context;
            kryptonWorkspaceCell1.Button.ButtonSpecs.Add(buttonSpecNavigator1);
            kryptonWorkspaceCell1.Button.CloseButtonAction = CloseButtonAction.RemovePageAndDispose;
            kryptonWorkspaceCell1.Button.CloseButtonDisplay = ButtonDisplay.Logic;
            kryptonWorkspaceCell1.Button.ContextButtonAction = ContextButtonAction.SelectPage;
            kryptonWorkspaceCell1.Button.ContextButtonDisplay = ButtonDisplay.Hide;
            kryptonWorkspaceCell1.Button.ContextMenuMapImage = MapKryptonPageImage.Small;
            kryptonWorkspaceCell1.Button.ContextMenuMapText = MapKryptonPageText.TextTitle;
            kryptonWorkspaceCell1.Button.NextButtonAction = DirectionButtonAction.ModeAppropriateAction;
            kryptonWorkspaceCell1.Button.NextButtonDisplay = ButtonDisplay.Logic;
            kryptonWorkspaceCell1.Button.PreviousButtonAction = DirectionButtonAction.ModeAppropriateAction;
            kryptonWorkspaceCell1.Button.PreviousButtonDisplay = ButtonDisplay.Logic;
            kryptonWorkspaceCell1.ControlKryptonFormFeatures = false;
            kryptonWorkspaceCell1.NavigatorMode = NavigatorMode.BarTabGroup;
            kryptonWorkspaceCell1.Owner = null;
            kryptonWorkspaceCell1.PageBackStyle = PaletteBackStyle.PanelClient;
            kryptonWorkspaceCell1.Pages.AddRange(new KryptonPage[] { kryptonPage1, kryptonPage2 });
            kryptonWorkspaceCell1.SelectedIndex = 0;
            kryptonWorkspaceCell1.UniqueName = "0f8ad3abd3aa4f128ffb9cf58898586b";
            // 
            // kryptonPage2
            // 
            kryptonPage2.AutoHiddenSlideSize = new Size(200, 200);
            kryptonPage2.ButtonSpecs.Add(buttonSpecAny1);
            kryptonPage2.Flags = 65534;
            kryptonPage2.LastVisibleSet = true;
            kryptonPage2.MinimumSize = new Size(150, 50);
            kryptonPage2.Name = "kryptonPage2";
            kryptonPage2.Size = new Size(150, 100);
            kryptonPage2.Text = "kryptonPage2";
            kryptonPage2.ToolTipTitle = "Page ToolTip";
            kryptonPage2.UniqueName = "6e2bb7fa33ee4a7f8103c139d7faf979";
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 419);
            Controls.Add(kryptonWorkspace1);
            Controls.Add(kryptonButton6);
            Controls.Add(kryptonButton5);
            Controls.Add(kryptonPropertyGrid2);
            Controls.Add(kryptonDataGridView1);
            Controls.Add(kryptonPropertyGrid1);
            Controls.Add(kryptonButton4);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Name = "Form17";
            Text = "Form17";
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonWorkspace1).EndInit();
            kryptonWorkspace1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPage1).EndInit();
            kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonWorkspaceCell1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPage2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonPropertyGrid kryptonPropertyGrid1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonPropertyGrid kryptonPropertyGrid2;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private KryptonWorkspace kryptonWorkspace1;
        private KryptonWorkspaceCell kryptonWorkspaceCell1;
        private ButtonSpecNavigator buttonSpecNavigator1;
        private ButtonSpecAny buttonSpecAny1;
        private KryptonPage kryptonPage1;
        private KryptonPage kryptonPage2;
        private KryptonPanel kryptonPanel1;
    }
}