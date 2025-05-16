using Krypton.Toolkit;
namespace KBSpecs_test
{
    partial class Form2
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
            kryptonTextBox1 = new KryptonTextBox();
            buttonSpecAny1 = new ButtonSpecAny();
            kryptonButton1 = new KryptonButton();
            kryptonButton2 = new KryptonButton();
            kryptonButton3 = new KryptonButton();
            kryptonButton4 = new KryptonButton();
            kryptonPropertyGrid1 = new KryptonPropertyGrid();
            kryptonDataGridView1 = new KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.ButtonSpecs.Add(buttonSpecAny1);
            kryptonTextBox1.Location = new Point(12, 12);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(154, 23);
            kryptonTextBox1.TabIndex = 0;
            kryptonTextBox1.Text = "kryptonTextBox1";
            kryptonTextBox1.SizeChanged += kryptonTextBox1_SizeChanged;
            // 
            // buttonSpecAny1
            // 
            buttonSpecAny1.Checked = ButtonCheckState.Checked;
            buttonSpecAny1.UniqueName = "095a6af88d9d4614b5779ab683e102f2";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(207, 12);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(186, 25);
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Loop capture image";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(399, 12);
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
            kryptonButton3.Location = new Point(816, 12);
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
            kryptonButton4.Location = new Point(1008, 12);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.Size = new Size(186, 45);
            kryptonButton4.TabIndex = 4;
            kryptonButton4.Values.DropDownArrowColor = Color.Empty;
            kryptonButton4.Values.Text = "Capture image\r\nGetImage()";
            kryptonButton4.Click += kryptonButton4_Click;
            // 
            // kryptonPropertyGrid1
            // 
            kryptonPropertyGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonPropertyGrid1.Location = new Point(816, 63);
            kryptonPropertyGrid1.Name = "kryptonPropertyGrid1";
            kryptonPropertyGrid1.Padding = new Padding(1);
            kryptonPropertyGrid1.SelectedObject = buttonSpecAny1;
            kryptonPropertyGrid1.Size = new Size(378, 356);
            kryptonPropertyGrid1.TabIndex = 5;
            kryptonPropertyGrid1.Text = "kryptonPropertyGrid1";
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kryptonDataGridView1.Location = new Point(12, 94);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.RowTemplate.Height = 60;
            kryptonDataGridView1.Size = new Size(798, 325);
            kryptonDataGridView1.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 431);
            Controls.Add(kryptonDataGridView1);
            Controls.Add(kryptonPropertyGrid1);
            Controls.Add(kryptonButton4);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonTextBox1);
            Name = "Form2";
            Text = "KryptonTextBox";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonPropertyGrid kryptonPropertyGrid1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
    }
}