namespace lab11_1_wf
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
            RightBox = new TextBox();
            LeftBox = new TextBox();
            n = new TextBox();
            ScrollBar = new HScrollBar();
            NIS = new Label();
            label2 = new Label();
            label3 = new Label();
            IsEqual = new TextBox();
            LeftBoxF = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // RightBox
            // 
            RightBox.Location = new Point(489, 277);
            RightBox.Name = "RightBox";
            RightBox.Size = new Size(100, 23);
            RightBox.TabIndex = 0;
            RightBox.Text = "1";
            // 
            // LeftBox
            // 
            LeftBox.Location = new Point(171, 277);
            LeftBox.Name = "LeftBox";
            LeftBox.Size = new Size(100, 23);
            LeftBox.TabIndex = 1;
            LeftBox.Text = "1";
            // 
            // n
            // 
            n.Location = new Point(335, 164);
            n.Name = "n";
            n.Size = new Size(100, 23);
            n.TabIndex = 2;
            n.Text = "1";
            n.TextChanged += n_TextChanged;
            // 
            // ScrollBar
            // 
            ScrollBar.LargeChange = 1;
            ScrollBar.Location = new Point(190, 190);
            ScrollBar.Maximum = 1000;
            ScrollBar.Minimum = 1;
            ScrollBar.Name = "ScrollBar";
            ScrollBar.Size = new Size(400, 26);
            ScrollBar.TabIndex = 3;
            ScrollBar.Value = 1;
            ScrollBar.Scroll += ScrollBar_Scroll;
            // 
            // NIS
            // 
            NIS.AutoSize = true;
            NIS.Location = new Point(366, 130);
            NIS.Name = "NIS";
            NIS.Size = new Size(33, 15);
            NIS.TabIndex = 4;
            NIS.Text = "n = ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 250);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 5;
            label2.Text = "n^2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 250);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "1+3+5+...+(2n-1)";
            // 
            // IsEqual
            // 
            IsEqual.Location = new Point(335, 277);
            IsEqual.Name = "IsEqual";
            IsEqual.Size = new Size(100, 23);
            IsEqual.TabIndex = 7;
            IsEqual.Text = "ожидание";
            // 
            // LeftBoxF
            // 
            LeftBoxF.Location = new Point(171, 343);
            LeftBoxF.Name = "LeftBoxF";
            LeftBoxF.Size = new Size(100, 23);
            LeftBoxF.TabIndex = 9;
            LeftBoxF.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 313);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 10;
            label1.Text = "Сумма по формуле";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(LeftBoxF);
            Controls.Add(IsEqual);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NIS);
            Controls.Add(ScrollBar);
            Controls.Add(n);
            Controls.Add(LeftBox);
            Controls.Add(RightBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void InitializeMyScrollBar()
        {
            
        }
        #endregion

        private TextBox RightBox;
        private TextBox LeftBox;
        private TextBox n;
        private HScrollBar ScrollBar;
        private Label NIS;
        private Label label2;
        private Label label3;
        private TextBox IsEqual;
        private TextBox LeftBoxF;
        private Label label1;
    }
}
