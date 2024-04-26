namespace lab10_1_wf
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
            ComputeResult = new Button();
            POWER1 = new TextBox();
            POWER2 = new TextBox();
            Hint1 = new TextBox();
            Hint2 = new TextBox();
            Info = new TextBox();
            Result = new TextBox();
            Volts = new TextBox();
            Hint3 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ComputeResult
            // 
            ComputeResult.Font = new Font("Segoe UI", 24F);
            ComputeResult.Location = new Point(348, 230);
            ComputeResult.Name = "ComputeResult";
            ComputeResult.Size = new Size(202, 51);
            ComputeResult.TabIndex = 1;
            ComputeResult.Text = "Вычислить";
            ComputeResult.UseVisualStyleBackColor = true;
            ComputeResult.Click += ComputeResult_Click;
            // 
            // POWER1
            // 
            POWER1.Font = new Font("Segoe UI", 24F);
            POWER1.Location = new Point(216, 230);
            POWER1.Name = "POWER1";
            POWER1.Size = new Size(126, 50);
            POWER1.TabIndex = 2;
            POWER1.TextChanged += POWER1_TEXT;
            // 
            // POWER2
            // 
            POWER2.Font = new Font("Segoe UI", 24F);
            POWER2.Location = new Point(556, 230);
            POWER2.Name = "POWER2";
            POWER2.Size = new Size(130, 50);
            POWER2.TabIndex = 3;
            POWER2.TextChanged += POWER2_TEXT;
            // 
            // Hint1
            // 
            Hint1.Anchor = AnchorStyles.Top;
            Hint1.Font = new Font("Segoe UI", 14F);
            Hint1.Location = new Point(184, 157);
            Hint1.MaximumSize = new Size(1000, 1000);
            Hint1.Multiline = true;
            Hint1.Name = "Hint1";
            Hint1.ReadOnly = true;
            Hint1.Size = new Size(158, 57);
            Hint1.TabIndex = 5;
            Hint1.Text = "Сопротивление\r\n№1\r\n\r\n";
            Hint1.TextAlign = HorizontalAlignment.Center;
            // 
            // Hint2
            // 
            Hint2.Anchor = AnchorStyles.Top;
            Hint2.Font = new Font("Segoe UI", 14F);
            Hint2.Location = new Point(556, 157);
            Hint2.MaximumSize = new Size(1000, 1000);
            Hint2.Multiline = true;
            Hint2.Name = "Hint2";
            Hint2.ReadOnly = true;
            Hint2.Size = new Size(161, 57);
            Hint2.TabIndex = 6;
            Hint2.Text = "Сопротивление\r\n№2\r\n\r\n\r\n";
            Hint2.TextAlign = HorizontalAlignment.Center;
            // 
            // Info
            // 
            Info.Font = new Font("Segoe UI", 20F);
            Info.Location = new Point(12, 429);
            Info.Multiline = true;
            Info.Name = "Info";
            Info.ReadOnly = true;
            Info.Size = new Size(537, 140);
            Info.TabIndex = 7;
            Info.Text = "Ед. измерения сопротивления в СИ - Ом\r\nЕд. измерения напряжения в СИ - Вольт\r\nЕд. измерения силы тока в СИ - Ампер";
            // 
            // Result
            // 
            Result.Font = new Font("Segoe UI", 24F);
            Result.Location = new Point(216, 353);
            Result.Name = "Result";
            Result.Size = new Size(470, 50);
            Result.TabIndex = 8;
            // 
            // Volts
            // 
            Volts.Font = new Font("Segoe UI", 24F);
            Volts.Location = new Point(383, 53);
            Volts.Name = "Volts";
            Volts.Size = new Size(126, 50);
            Volts.TabIndex = 9;
            Volts.TextChanged += VOLTS_TEXT;
            // 
            // Hint3
            // 
            Hint3.Anchor = AnchorStyles.Top;
            Hint3.Font = new Font("Segoe UI", 14F);
            Hint3.Location = new Point(348, 12);
            Hint3.MaximumSize = new Size(1000, 1000);
            Hint3.Multiline = true;
            Hint3.Name = "Hint3";
            Hint3.ReadOnly = true;
            Hint3.Size = new Size(201, 35);
            Hint3.TabIndex = 10;
            Hint3.Text = "Напряжение в цепи\r\n\r\n";
            Hint3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.Location = new Point(216, 297);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(470, 50);
            textBox1.TabIndex = 11;
            textBox1.Text = "Итоговая сила тока цепи";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 581);
            Controls.Add(textBox1);
            Controls.Add(Hint3);
            Controls.Add(Volts);
            Controls.Add(Result);
            Controls.Add(Info);
            Controls.Add(Hint2);
            Controls.Add(Hint1);
            Controls.Add(POWER2);
            Controls.Add(POWER1);
            Controls.Add(ComputeResult);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Hint1;
        private TextBox Hint2;
        private TextBox Info;
        private TextBox Hint3;
        public TextBox Volts;
        public Button ComputeResult;
        public TextBox POWER1;
        public TextBox POWER2;
        public TextBox Result;
        private TextBox textBox1;
    }
}
