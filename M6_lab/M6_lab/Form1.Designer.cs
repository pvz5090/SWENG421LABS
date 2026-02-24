namespace M6_lab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            graphsComboBox = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            SuspendLayout();
            // 
            // graphsComboBox
            // 
            graphsComboBox.FormattingEnabled = true;
            graphsComboBox.Location = new Point(12, 34);
            graphsComboBox.Name = "graphsComboBox";
            graphsComboBox.Size = new Size(121, 23);
            graphsComboBox.TabIndex = 0;
            graphsComboBox.Text = "Choose a Graph";
            // 
            // button1
            // 
            button1.Location = new Point(21, 185);
            button1.Name = "button1";
            button1.Size = new Size(101, 25);
            button1.TabIndex = 1;
            button1.Text = "Create Graph";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateGraphClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(graphsComboBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox graphsComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
    }
}
