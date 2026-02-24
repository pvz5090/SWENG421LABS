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
            CreateGraphButton = new Button();
            GraphPanel = new Panel();
            CopyGraphButton = new Button();
            VerticesComboBox = new ComboBox();
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
            // CreateGraphButton
            // 
            CreateGraphButton.Location = new Point(179, 1);
            CreateGraphButton.Name = "CreateGraphButton";
            CreateGraphButton.Size = new Size(112, 27);
            CreateGraphButton.TabIndex = 1;
            CreateGraphButton.Text = "Create New Graph";
            CreateGraphButton.UseVisualStyleBackColor = true;
            CreateGraphButton.Click += CreateGraphClicked;
            // 
            // GraphPanel
            // 
            GraphPanel.Location = new Point(179, 34);
            GraphPanel.Name = "GraphPanel";
            GraphPanel.Size = new Size(421, 362);
            GraphPanel.TabIndex = 2;
            GraphPanel.Paint += GraphPanel_Paint;
            // 
            // CopyGraphButton
            // 
            CopyGraphButton.Location = new Point(451, 3);
            CopyGraphButton.Name = "CopyGraphButton";
            CopyGraphButton.Size = new Size(107, 25);
            CopyGraphButton.TabIndex = 3;
            CopyGraphButton.Text = "Copy This Graph ";
            CopyGraphButton.UseVisualStyleBackColor = true;
            CopyGraphButton.Click += CopyGraphButton_Click;
            // 
            // VerticesComboBox
            // 
            VerticesComboBox.FormattingEnabled = true;
            VerticesComboBox.Location = new Point(631, 58);
            VerticesComboBox.Name = "VerticesComboBox";
            VerticesComboBox.Size = new Size(121, 23);
            VerticesComboBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VerticesComboBox);
            Controls.Add(CopyGraphButton);
            Controls.Add(GraphPanel);
            Controls.Add(CreateGraphButton);
            Controls.Add(graphsComboBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox graphsComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button CreateGraphButton;
        private Panel GraphPanel;
        private Button CopyGraphButton;
        private ComboBox VerticesComboBox;
    }
}
