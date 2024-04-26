namespace lab10_2_wf
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
            NumeroDos = new TextBox();
            NumeroUno = new TextBox();
            CalcResult = new Button();
            Hint2 = new Label();
            Hint1 = new Label();
            ChangeMode = new Button();
            CalculateMod = new TextBox();
            Mode = new Label();
            Result = new TextBox();
            SuspendLayout();
            // 
            // NumeroDos
            // 
            NumeroDos.Location = new Point(527, 172);
            NumeroDos.Name = "NumeroDos";
            NumeroDos.Size = new Size(100, 23);
            NumeroDos.TabIndex = 0;
            NumeroDos.TextChanged += NumeroDos_TextChanged;
            // 
            // NumeroUno
            // 
            NumeroUno.Location = new Point(164, 172);
            NumeroUno.Name = "NumeroUno";
            NumeroUno.Size = new Size(100, 23);
            NumeroUno.TabIndex = 1;
            NumeroUno.TextChanged += NumeroUno_TextChanged;
            // 
            // CalcResult
            // 
            CalcResult.Location = new Point(355, 171);
            CalcResult.Name = "CalcResult";
            CalcResult.Size = new Size(92, 23);
            CalcResult.TabIndex = 4;
            CalcResult.Text = "Вычислить";
            CalcResult.UseVisualStyleBackColor = true;
            CalcResult.Click += CalcResult_Click;
            // 
            // Hint2
            // 
            Hint2.AutoSize = true;
            Hint2.Location = new Point(550, 134);
            Hint2.Name = "Hint2";
            Hint2.Size = new Size(51, 15);
            Hint2.TabIndex = 5;
            Hint2.Text = "Число 2";
            // 
            // Hint1
            // 
            Hint1.AutoSize = true;
            Hint1.Location = new Point(189, 134);
            Hint1.Name = "Hint1";
            Hint1.Size = new Size(51, 15);
            Hint1.TabIndex = 6;
            Hint1.Text = "Число 1";
            // 
            // ChangeMode
            // 
            ChangeMode.Location = new Point(328, 114);
            ChangeMode.Name = "ChangeMode";
            ChangeMode.Size = new Size(145, 23);
            ChangeMode.TabIndex = 7;
            ChangeMode.Text = "Переключить режим";
            ChangeMode.UseVisualStyleBackColor = true;
            ChangeMode.Click += ChangeMode_Click;
            // 
            // CalculateMod
            // 
            CalculateMod.Location = new Point(355, 71);
            CalculateMod.Name = "CalculateMod";
            CalculateMod.Size = new Size(92, 23);
            CalculateMod.TabIndex = 9;
            CalculateMod.TextAlign = HorizontalAlignment.Center;
            // 
            // Mode
            // 
            Mode.AutoSize = true;
            Mode.Location = new Point(345, 31);
            Mode.Name = "Mode";
            Mode.Size = new Size(116, 15);
            Mode.TabIndex = 11;
            Mode.Text = "Режим вычисления";
            // 
            // Result
            // 
            Result.Location = new Point(355, 219);
            Result.Name = "Result";
            Result.Size = new Size(100, 23);
            Result.TabIndex = 12;
            Result.TextChanged += Result_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Result);
            Controls.Add(Mode);
            Controls.Add(CalculateMod);
            Controls.Add(ChangeMode);
            Controls.Add(Hint1);
            Controls.Add(Hint2);
            Controls.Add(CalcResult);
            Controls.Add(NumeroUno);
            Controls.Add(NumeroDos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NumeroDos;
        private TextBox NumeroUno;
        private Button CalcResult;
        private Label Hint2;
        private Label Hint1;
        private Button ChangeMode;
        private TextBox CalculateMod;
        private Label Mode;
        private TextBox Result;
    }
}
