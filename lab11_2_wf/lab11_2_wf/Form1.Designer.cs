namespace lab11_2_wf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SortedList = new ListBox();
            OriginalList = new ListBox();
            AddRandom = new Button();
            ClearListOne = new Button();
            FilterMov = new Button();
            DoSort = new Button();
            OpenFile = new Button();
            SaveFile = new Button();
            SuspendLayout();
            // 
            // SortedList
            // 
            SortedList.FormattingEnabled = true;
            SortedList.ItemHeight = 15;
            SortedList.Location = new Point(401, 4);
            SortedList.Name = "SortedList";
            SortedList.ScrollAlwaysVisible = true;
            SortedList.Size = new Size(387, 409);
            SortedList.TabIndex = 0;
            // 
            // OriginalList
            // 
            OriginalList.FormattingEnabled = true;
            OriginalList.ItemHeight = 15;
            OriginalList.Location = new Point(12, 4);
            OriginalList.Name = "OriginalList";
            OriginalList.ScrollAlwaysVisible = true;
            OriginalList.Size = new Size(383, 409);
            OriginalList.TabIndex = 1;
            // 
            // AddRandom
            // 
            AddRandom.Location = new Point(12, 419);
            AddRandom.Name = "AddRandom";
            AddRandom.Size = new Size(99, 23);
            AddRandom.TabIndex = 2;
            AddRandom.Text = "Сгенерировать";
            AddRandom.UseVisualStyleBackColor = true;
            AddRandom.Click += AddRandom_Click;
            // 
            // ClearListOne
            // 
            ClearListOne.Location = new Point(117, 419);
            ClearListOne.Name = "ClearListOne";
            ClearListOne.Size = new Size(75, 23);
            ClearListOne.TabIndex = 3;
            ClearListOne.Text = "Очистить";
            ClearListOne.UseVisualStyleBackColor = true;
            ClearListOne.Click += ClearListOne_Click;
            // 
            // FilterMov
            // 
            FilterMov.Location = new Point(700, 419);
            FilterMov.Name = "FilterMov";
            FilterMov.Size = new Size(88, 23);
            FilterMov.TabIndex = 4;
            FilterMov.Text = "Фильтрация";
            FilterMov.UseVisualStyleBackColor = true;
            FilterMov.Click += FilterMov_Click;
            // 
            // DoSort
            // 
            DoSort.Location = new Point(198, 419);
            DoSort.Name = "DoSort";
            DoSort.Size = new Size(93, 23);
            DoSort.TabIndex = 6;
            DoSort.Text = "Сортировать";
            DoSort.UseVisualStyleBackColor = true;
            DoSort.Click += DoSort_Click;
            // 
            // OpenFile
            // 
            OpenFile.Location = new Point(297, 419);
            OpenFile.Name = "OpenFile";
            OpenFile.Size = new Size(72, 23);
            OpenFile.TabIndex = 7;
            OpenFile.Text = "Открыть";
            OpenFile.UseVisualStyleBackColor = true;
            OpenFile.Click += OpenFile_Click;
            // 
            // SaveFile
            // 
            SaveFile.Location = new Point(401, 419);
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new Size(75, 23);
            SaveFile.TabIndex = 8;
            SaveFile.Text = "Сохранить";
            SaveFile.UseVisualStyleBackColor = true;
            SaveFile.Click += SaveFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(805, 455);
            Controls.Add(SaveFile);
            Controls.Add(OpenFile);
            Controls.Add(DoSort);
            Controls.Add(FilterMov);
            Controls.Add(ClearListOne);
            Controls.Add(AddRandom);
            Controls.Add(OriginalList);
            Controls.Add(SortedList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox SortedList;
        private ListBox OriginalList;
        private Button AddRandom;
        private Button ClearListOne;
        private Button FilterMov;
        private Button DoSort;
        private Button OpenFile;
        private Button SaveFile;
    }
}
