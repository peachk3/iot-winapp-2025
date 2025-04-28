namespace WinFormPractice
{
    partial class FrmMain
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
            CalToDoList = new MonthCalendar();
            groupBox1 = new GroupBox();
            RdoLow = new RadioButton();
            RdoMiddle = new RadioButton();
            RdoHigh = new RadioButton();
            LblTitle = new Label();
            TxtTitle = new TextBox();
            LblContent = new Label();
            BtnCheck = new Button();
            dateTimePicker1 = new DateTimePicker();
            BtnSearch = new Button();
            TblSch = new DataGridView();
            TxtContent = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TblSch).BeginInit();
            SuspendLayout();
            // 
            // CalToDoList
            // 
            CalToDoList.Location = new Point(18, 18);
            CalToDoList.Name = "CalToDoList";
            CalToDoList.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RdoLow);
            groupBox1.Controls.Add(RdoMiddle);
            groupBox1.Controls.Add(RdoHigh);
            groupBox1.Location = new Point(18, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 73);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "일정 중요도";
            // 
            // RdoLow
            // 
            RdoLow.AutoSize = true;
            RdoLow.Location = new Point(165, 33);
            RdoLow.Name = "RdoLow";
            RdoLow.Size = new Size(49, 19);
            RdoLow.TabIndex = 2;
            RdoLow.TabStop = true;
            RdoLow.Text = "낮음";
            RdoLow.UseVisualStyleBackColor = true;
            // 
            // RdoMiddle
            // 
            RdoMiddle.AutoSize = true;
            RdoMiddle.Location = new Point(88, 33);
            RdoMiddle.Name = "RdoMiddle";
            RdoMiddle.Size = new Size(49, 19);
            RdoMiddle.TabIndex = 1;
            RdoMiddle.TabStop = true;
            RdoMiddle.Text = "보통";
            RdoMiddle.UseVisualStyleBackColor = true;
            // 
            // RdoHigh
            // 
            RdoHigh.AutoSize = true;
            RdoHigh.Location = new Point(12, 33);
            RdoHigh.Name = "RdoHigh";
            RdoHigh.Size = new Size(49, 19);
            RdoHigh.TabIndex = 0;
            RdoHigh.TabStop = true;
            RdoHigh.Text = "높음";
            RdoHigh.UseVisualStyleBackColor = true;
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Location = new Point(275, 21);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(59, 15);
            LblTitle.TabIndex = 2;
            LblTitle.Text = "일정 제목";
            // 
            // TxtTitle
            // 
            TxtTitle.Location = new Point(340, 18);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(155, 23);
            TxtTitle.TabIndex = 3;
            // 
            // LblContent
            // 
            LblContent.AutoSize = true;
            LblContent.Location = new Point(275, 50);
            LblContent.Name = "LblContent";
            LblContent.Size = new Size(59, 15);
            LblContent.TabIndex = 2;
            LblContent.Text = "일정 내용";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(420, 192);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(75, 23);
            BtnCheck.TabIndex = 4;
            BtnCheck.Text = "일정 추가";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(18, 357);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(259, 357);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 4;
            BtnSearch.Text = "일정 검색";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TblSch
            // 
            TblSch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TblSch.Location = new Point(12, 399);
            TblSch.Name = "TblSch";
            TblSch.Size = new Size(565, 150);
            TblSch.TabIndex = 6;
            // 
            // TxtContent
            // 
            TxtContent.Location = new Point(275, 68);
            TxtContent.Multiline = true;
            TxtContent.Name = "TxtContent";
            TxtContent.ScrollBars = ScrollBars.Vertical;
            TxtContent.Size = new Size(220, 118);
            TxtContent.TabIndex = 3;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 561);
            Controls.Add(TblSch);
            Controls.Add(dateTimePicker1);
            Controls.Add(BtnSearch);
            Controls.Add(BtnCheck);
            Controls.Add(TxtContent);
            Controls.Add(LblContent);
            Controls.Add(TxtTitle);
            Controls.Add(LblTitle);
            Controls.Add(groupBox1);
            Controls.Add(CalToDoList);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "윈앱(윈폼) 연습";
            FormClosing += FrmMain_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TblSch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar CalToDoList;
        private GroupBox groupBox1;
        private RadioButton RdoLow;
        private RadioButton RdoMiddle;
        private RadioButton RdoHigh;
        private Label LblTitle;
        private TextBox TxtTitle;
        private Label LblContent;
        private Button BtnCheck;
        private DateTimePicker dateTimePicker1;
        private Button BtnSearch;
        private DataGridView TblSch;
        private TextBox TxtContent;
    }
}
