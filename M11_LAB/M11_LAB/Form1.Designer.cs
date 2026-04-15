namespace M11_Lab
{
    partial class Display
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
            displayBox = new TextBox();
            backspace = new Button();
            CC = new Button();
            C = new Button();
            sign = new Button();
            sqrt = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            divide = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            multiply = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            minus = new Button();
            zero = new Button();
            period = new Button();
            plus = new Button();
            inverse = new Button();
            equal = new Button();
            SuspendLayout();
            // 
            // displayBox
            // 
            displayBox.Location = new Point(199, 79);
            displayBox.Name = "displayBox";
            displayBox.Size = new Size(192, 23);
            displayBox.TabIndex = 0;
            displayBox.TextChanged += textBox1_TextChanged;
            // 
            // backspace
            // 
            backspace.Location = new Point(118, 108);
            backspace.Name = "backspace";
            backspace.Size = new Size(75, 23);
            backspace.TabIndex = 1;
            backspace.Text = "<-";
            backspace.UseVisualStyleBackColor = true;
            // 
            // CC
            // 
            CC.Location = new Point(199, 108);
            CC.Name = "CC";
            CC.Size = new Size(75, 23);
            CC.TabIndex = 2;
            CC.Text = "CC";
            CC.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            C.Location = new Point(280, 108);
            C.Name = "C";
            C.Size = new Size(75, 23);
            C.TabIndex = 3;
            C.Text = "C";
            C.UseVisualStyleBackColor = true;
            // 
            // sign
            // 
            sign.Location = new Point(361, 108);
            sign.Name = "sign";
            sign.Size = new Size(75, 23);
            sign.TabIndex = 4;
            sign.Text = "+/-";
            sign.UseVisualStyleBackColor = true;
            // 
            // sqrt
            // 
            sqrt.Location = new Point(442, 108);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(75, 38);
            sqrt.TabIndex = 5;
            sqrt.Text = "√";
            sqrt.UseVisualStyleBackColor = true;
            sqrt.Click += button1_Click;
            // 
            // seven
            // 
            seven.Location = new Point(118, 137);
            seven.Name = "seven";
            seven.Size = new Size(75, 23);
            seven.TabIndex = 6;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            // 
            // eight
            // 
            eight.Location = new Point(199, 137);
            eight.Name = "eight";
            eight.Size = new Size(75, 23);
            eight.TabIndex = 7;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            // 
            // nine
            // 
            nine.Location = new Point(280, 137);
            nine.Name = "nine";
            nine.Size = new Size(75, 23);
            nine.TabIndex = 8;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            divide.Location = new Point(361, 137);
            divide.Name = "divide";
            divide.Size = new Size(75, 23);
            divide.TabIndex = 9;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            // 
            // four
            // 
            four.Location = new Point(118, 166);
            four.Name = "four";
            four.Size = new Size(75, 23);
            four.TabIndex = 10;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            // 
            // five
            // 
            five.Location = new Point(199, 166);
            five.Name = "five";
            five.Size = new Size(75, 23);
            five.TabIndex = 11;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            // 
            // six
            // 
            six.Location = new Point(280, 166);
            six.Name = "six";
            six.Size = new Size(75, 23);
            six.TabIndex = 12;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            multiply.Location = new Point(361, 166);
            multiply.Name = "multiply";
            multiply.Size = new Size(75, 23);
            multiply.TabIndex = 13;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            // 
            // three
            // 
            three.Location = new Point(280, 195);
            three.Name = "three";
            three.Size = new Size(75, 23);
            three.TabIndex = 14;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // two
            // 
            two.Location = new Point(199, 195);
            two.Name = "two";
            two.Size = new Size(75, 23);
            two.TabIndex = 15;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // one
            // 
            one.Location = new Point(118, 195);
            one.Name = "one";
            one.Size = new Size(75, 23);
            one.TabIndex = 16;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // minus
            // 
            minus.Location = new Point(361, 195);
            minus.Name = "minus";
            minus.Size = new Size(75, 23);
            minus.TabIndex = 17;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            zero.Location = new Point(118, 224);
            zero.Name = "zero";
            zero.Size = new Size(156, 23);
            zero.TabIndex = 18;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // period
            // 
            period.Location = new Point(280, 224);
            period.Name = "period";
            period.Size = new Size(75, 23);
            period.TabIndex = 19;
            period.Text = ".";
            period.UseVisualStyleBackColor = true;
            period.Click += period_Click;
            // 
            // plus
            // 
            plus.Location = new Point(361, 224);
            plus.Name = "plus";
            plus.Size = new Size(75, 23);
            plus.TabIndex = 20;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // inverse
            // 
            inverse.Location = new Point(442, 156);
            inverse.Name = "inverse";
            inverse.Size = new Size(75, 42);
            inverse.TabIndex = 21;
            inverse.Text = "1/x";
            inverse.UseVisualStyleBackColor = true;
            // 
            // equal
            // 
            equal.Location = new Point(442, 205);
            equal.Name = "equal";
            equal.Size = new Size(75, 42);
            equal.TabIndex = 22;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += equal_Click;
            // 
            // Display
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(equal);
            Controls.Add(inverse);
            Controls.Add(plus);
            Controls.Add(period);
            Controls.Add(zero);
            Controls.Add(minus);
            Controls.Add(one);
            Controls.Add(two);
            Controls.Add(three);
            Controls.Add(multiply);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(divide);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(sqrt);
            Controls.Add(sign);
            Controls.Add(C);
            Controls.Add(CC);
            Controls.Add(backspace);
            Controls.Add(displayBox);
            Name = "Display";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displayBox;
        private Button backspace;
        private Button CC;
        private Button C;
        private Button sign;
        private Button sqrt;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button divide;
        private Button four;
        private Button five;
        private Button six;
        private Button multiply;
        private Button three;
        private Button two;
        private Button one;
        private Button minus;
        private Button zero;
        private Button period;
        private Button plus;
        private Button inverse;
        private Button equal;
    }
}
