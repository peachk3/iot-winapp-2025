namespace ToyProject1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
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
            TblSch = new DataGridView();
            TxtContent = new TextBox();
            BtnDelete = new Button();
            CboCategory = new ComboBox();
            label1 = new Label();
            CboSearchCate = new ComboBox();
            BtnSearch = new Button();
            BtnModify = new Button();
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
            RdoMiddle.Location = new Point(91, 33);
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
            RdoHigh.Location = new Point(10, 33);
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
            LblTitle.Location = new Point(261, 21);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(59, 15);
            LblTitle.TabIndex = 2;
            LblTitle.Text = "일정 제목";
            // 
            // TxtTitle
            // 
            TxtTitle.Location = new Point(326, 18);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(236, 23);
            TxtTitle.TabIndex = 3;
            // 
            // LblContent
            // 
            LblContent.AutoSize = true;
            LblContent.Location = new Point(261, 90);
            LblContent.Name = "LblContent";
            LblContent.Size = new Size(59, 15);
            LblContent.TabIndex = 2;
            LblContent.Text = "일정 내용";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(492, 232);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(75, 23);
            BtnCheck.TabIndex = 4;
            BtnCheck.Text = "일정 추가";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(18, 281);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(181, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // TblSch
            // 
            TblSch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TblSch.Location = new Point(18, 310);
            TblSch.Name = "TblSch";
            TblSch.Size = new Size(549, 239);
            TblSch.TabIndex = 6;
            TblSch.CellFormatting += TblSch_CellFormatting;
            // 
            // TxtContent
            // 
            TxtContent.Location = new Point(266, 108);
            TxtContent.Multiline = true;
            TxtContent.Name = "TxtContent";
            TxtContent.ScrollBars = ScrollBars.Vertical;
            TxtContent.Size = new Size(301, 118);
            TxtContent.TabIndex = 3;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(467, 281);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "일정 삭제";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // CboCategory
            // 
            CboCategory.FormattingEnabled = true;
            CboCategory.Location = new Point(327, 54);
            CboCategory.Name = "CboCategory";
            CboCategory.Size = new Size(235, 23);
            CboCategory.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 57);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "일정 분류";
            // 
            // CboSearchCate
            // 
            CboSearchCate.FormattingEnabled = true;
            CboSearchCate.Location = new Point(206, 282);
            CboSearchCate.Name = "CboSearchCate";
            CboSearchCate.Size = new Size(90, 23);
            CboSearchCate.TabIndex = 8;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(305, 281);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 4;
            BtnSearch.Text = "일정 검색";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnModify
            // 
            BtnModify.Location = new Point(386, 281);
            BtnModify.Name = "BtnModify";
            BtnModify.Size = new Size(75, 23);
            BtnModify.TabIndex = 9;
            BtnModify.Text = "일정 수정";
            BtnModify.UseVisualStyleBackColor = true;
            BtnModify.Click += BtnModify_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(BtnModify);
            Controls.Add(CboSearchCate);
            Controls.Add(CboCategory);
            Controls.Add(BtnDelete);
            Controls.Add(TblSch);
            Controls.Add(dateTimePicker1);
            Controls.Add(BtnSearch);
            Controls.Add(BtnCheck);
            Controls.Add(TxtContent);
            Controls.Add(label1);
            Controls.Add(LblContent);
            Controls.Add(TxtTitle);
            Controls.Add(LblTitle);
            Controls.Add(groupBox1);
            Controls.Add(CalToDoList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "일정 관리  프로그램";
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
        private DataGridView TblSch;
        private TextBox TxtContent;
        private Button BtnDelete;
        private ComboBox CboCategory;
        private Label label1;
        private ComboBox CboSearchCate;
        private Button BtnSearch;
        private Button BtnModify;
    }
}
