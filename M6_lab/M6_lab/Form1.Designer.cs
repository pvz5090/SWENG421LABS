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
            ChooseGraphText = new TextBox();
            VerticesText = new TextBox();
            userX = new TextBox();
            userY = new TextBox();
            VertexXText = new TextBox();
            VertexYText = new TextBox();
            SuspendLayout();
            // 
            // graphsComboBox
            // 
            graphsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            graphsComboBox.FormattingEnabled = true;
            graphsComboBox.Location = new Point(12, 34);
            graphsComboBox.Name = "graphsComboBox";
            graphsComboBox.Size = new Size(121, 23);
            graphsComboBox.TabIndex = 0;
            graphsComboBox.SelectedIndexChanged += graphsComboBox_SelectedIndexChanged;
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
            GraphPanel.BackColor = SystemColors.Control;
            GraphPanel.BorderStyle = BorderStyle.FixedSingle;
            GraphPanel.Location = new Point(179, 34);
            GraphPanel.Name = "GraphPanel";
            GraphPanel.Size = new Size(421, 362);
            GraphPanel.TabIndex = 2;
            GraphPanel.Paint += GraphPanel_Paint;
            GraphPanel.MouseDown += GraphPanel_MouseDown;
            GraphPanel.MouseUp += GraphPanel_MouseUp;
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
            VerticesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            VerticesComboBox.FormattingEnabled = true;
            VerticesComboBox.Location = new Point(631, 63);
            VerticesComboBox.Name = "VerticesComboBox";
            VerticesComboBox.Size = new Size(121, 23);
            VerticesComboBox.TabIndex = 4;
            VerticesComboBox.Visible = false;
            VerticesComboBox.SelectedIndexChanged += VerticesComboBox_SelectedIndexChanged;
            // 
            // ChooseGraphText
            // 
            ChooseGraphText.Location = new Point(12, 12);
            ChooseGraphText.Name = "ChooseGraphText";
            ChooseGraphText.ReadOnly = true;
            ChooseGraphText.Size = new Size(100, 23);
            ChooseGraphText.TabIndex = 5;
            ChooseGraphText.Text = "Choose a Graph";
            ChooseGraphText.TextChanged += textBox1_TextChanged;
            // 
            // VerticesText
            // 
            VerticesText.Location = new Point(631, 34);
            VerticesText.Name = "VerticesText";
            VerticesText.ReadOnly = true;
            VerticesText.Size = new Size(47, 23);
            VerticesText.TabIndex = 6;
            VerticesText.Text = "Vertices";
            // 
            // userX
            // 
            userX.Location = new Point(631, 121);
            userX.Name = "userX";
            userX.Size = new Size(100, 23);
            userX.TabIndex = 9;
            userX.KeyDown += userX_KeyDown;
            // 
            // userY
            // 
            userY.Location = new Point(631, 179);
            userY.Name = "userY";
            userY.Size = new Size(100, 23);
            userY.TabIndex = 10;
            userY.KeyDown += userY_KeyDown;
            // 
            // VertexXText
            // 
            VertexXText.Location = new Point(631, 92);
            VertexXText.Name = "VertexXText";
            VertexXText.ReadOnly = true;
            VertexXText.Size = new Size(79, 23);
            VertexXText.TabIndex = 11;
            VertexXText.Text = "X-Coordinate";
            // 
            // VertexYText
            // 
            VertexYText.Location = new Point(631, 150);
            VertexYText.Name = "VertexYText";
            VertexYText.ReadOnly = true;
            VertexYText.Size = new Size(79, 23);
            VertexYText.TabIndex = 12;
            VertexYText.Text = "Y-Coordinate";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VertexYText);
            Controls.Add(VertexXText);
            Controls.Add(userY);
            Controls.Add(userX);
            Controls.Add(VerticesText);
            Controls.Add(ChooseGraphText);
            Controls.Add(VerticesComboBox);
            Controls.Add(CopyGraphButton);
            Controls.Add(GraphPanel);
            Controls.Add(CreateGraphButton);
            Controls.Add(graphsComboBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox graphsComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button CreateGraphButton;
        private Panel GraphPanel;
        private Button CopyGraphButton;
        private ComboBox VerticesComboBox;
        private TextBox ChooseGraphText;
        private TextBox VerticesText;
        private TextBox userX;
        private TextBox userY;
        private TextBox VertexXText;
        private TextBox VertexYText;
    }
}
