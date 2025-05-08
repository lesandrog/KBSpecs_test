namespace KBSpecs_test
{
    partial class Form14
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
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            kryptonPropertyGrid1 = new Krypton.Toolkit.KryptonPropertyGrid();
            buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            kryptonRibbonRecentDoc1 = new Krypton.Ribbon.KryptonRibbonRecentDoc();
            buttonSpecAppMenu1 = new Krypton.Ribbon.ButtonSpecAppMenu();
            kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            kryptonRibbonGroupButton1 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            kryptonRibbonGroupButton2 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            kryptonRibbonGroupButton3 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            kryptonPropertyGrid2 = new Krypton.Toolkit.KryptonPropertyGrid();
            kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            kryptonRibbonTab2 = new Krypton.Ribbon.KryptonRibbonTab();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonRibbon1).BeginInit();
            SuspendLayout();
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(12, 165);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(229, 25);
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Loop capture image -  BSpecAny";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(247, 181);
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
            kryptonButton3.Location = new Point(795, 148);
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
            kryptonButton4.Location = new Point(1004, 148);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new Size(186, 45);
            kryptonButton4.TabIndex = 4;
            kryptonButton4.Values.DropDownArrowColor = Color.Empty;
            kryptonButton4.Values.Text = "Capture image\r\nGetImage() - BSpecAny";
            kryptonButton4.Click += kryptonButton4_Click;
            // 
            // kryptonPropertyGrid1
            // 
            kryptonPropertyGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonPropertyGrid1.Location = new Point(891, 199);
            kryptonPropertyGrid1.Name = "kryptonPropertyGrid1";
            kryptonPropertyGrid1.Padding = new Padding(1);
            kryptonPropertyGrid1.SelectedObject = buttonSpecAny1;
            kryptonPropertyGrid1.Size = new Size(299, 232);
            kryptonPropertyGrid1.TabIndex = 5;
            kryptonPropertyGrid1.Text = "kryptonPropertyGrid1";
            // 
            // buttonSpecAny1
            // 
            buttonSpecAny1.Checked = Krypton.Toolkit.ButtonCheckState.Checked;
            buttonSpecAny1.UniqueName = "df94015c9ef44b12a424d005dd1aedea";
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView1.Location = new Point(12, 262);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.RowTemplate.Height = 60;
            kryptonDataGridView1.Size = new Size(568, 169);
            kryptonDataGridView1.TabIndex = 6;
            // 
            // kryptonRibbon1
            // 
            kryptonRibbon1.ButtonSpecs.Add(buttonSpecAny1);
            kryptonRibbon1.Name = "kryptonRibbon1";
            kryptonRibbon1.QATLocation = Krypton.Ribbon.QATLocation.Hidden;
            kryptonRibbon1.RibbonFileAppButton.AppButtonMinRecentSize = new Size(250, 50);
            kryptonRibbon1.RibbonFileAppButton.AppButtonRecentDocs.AddRange(new Krypton.Ribbon.KryptonRibbonRecentDoc[] { kryptonRibbonRecentDoc1 });
            kryptonRibbon1.RibbonFileAppButton.AppButtonSpecs.Add(buttonSpecAppMenu1);
            kryptonRibbon1.RibbonFileAppButton.FormCloseBoxVisible = true;
            kryptonRibbon1.RibbonStyles.BackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] { kryptonRibbonTab1, kryptonRibbonTab2 });
            kryptonRibbon1.SelectedTab = kryptonRibbonTab1;
            kryptonRibbon1.Size = new Size(1202, 115);
            kryptonRibbon1.TabIndex = 7;
            // 
            // buttonSpecAppMenu1
            // 
            buttonSpecAppMenu1.Checked = Krypton.Toolkit.ButtonCheckState.Checked;
            buttonSpecAppMenu1.UniqueName = "82faa6e9b2bf4e15a723c230e047c7be";
            // 
            // kryptonRibbonTab1
            // 
            kryptonRibbonTab1.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] { kryptonRibbonGroup1 });
            //
            //kryptonRibbonGroup1
            //
            //
            kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] { kryptonRibbonGroupTriple1 });
            //
            //KryptonRibbonGroupTriple1
            //
            kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] { kryptonRibbonGroupButton1, kryptonRibbonGroupButton2, kryptonRibbonGroupButton3 });
        
            // 
            // kryptonPropertyGrid2
            // 
            kryptonPropertyGrid2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonPropertyGrid2.Location = new Point(586, 199);
            kryptonPropertyGrid2.Name = "kryptonPropertyGrid2";
            kryptonPropertyGrid2.Padding = new Padding(1);
            kryptonPropertyGrid2.SelectedObject = buttonSpecAppMenu1;
            kryptonPropertyGrid2.Size = new Size(299, 232);
            kryptonPropertyGrid2.TabIndex = 8;
            kryptonPropertyGrid2.Text = "kryptonPropertyGrid2";
            // 
            // kryptonButton5
            // 
            kryptonButton5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonButton5.Location = new Point(586, 148);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.Size = new Size(186, 45);
            kryptonButton5.TabIndex = 9;
            kryptonButton5.Values.DropDownArrowColor = Color.Empty;
            kryptonButton5.Values.Text = "Capture image\r\nGetImage() - BSpecAppMenu";
            kryptonButton5.Click += kryptonButton5_Click;
            // 
            // kryptonButton6
            // 
            kryptonButton6.Location = new Point(12, 199);
            kryptonButton6.Name = "kryptonButton6";
            kryptonButton6.Size = new Size(229, 25);
            kryptonButton6.TabIndex = 10;
            kryptonButton6.Values.DropDownArrowColor = Color.Empty;
            kryptonButton6.Values.Text = "Loop capture image -  BSpecAppMenu";
            kryptonButton6.Click += kryptonButton6_Click;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 443);
            Controls.Add(kryptonButton6);
            Controls.Add(kryptonButton5);
            Controls.Add(kryptonPropertyGrid2);
            Controls.Add(kryptonRibbon1);
            Controls.Add(kryptonDataGridView1);
            Controls.Add(kryptonPropertyGrid1);
            Controls.Add(kryptonButton4);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Name = "Form14";
            Text = "Form14";
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonRibbon1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonPropertyGrid kryptonPropertyGrid1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Ribbon.KryptonRibbonRecentDoc kryptonRibbonRecentDoc1;
        private Krypton.Ribbon.ButtonSpecAppMenu buttonSpecAppMenu1;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton1;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton2;
                private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
                private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Toolkit.KryptonPropertyGrid kryptonPropertyGrid2;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab2;
    }
}