namespace SyntaxWinApp01
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
            groupBox1 = new GroupBox();
            TxtPhone = new TextBox();
            label4 = new Label();
            TxtGender = new TextBox();
            label3 = new Label();
            TxtAge = new TextBox();
            label2 = new Label();
            TxtName = new TextBox();
            label1 = new Label();
            BtnCheck = new Button();
            TxtResult = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtGender);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtAge);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "사람 정보 입력";
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(59, 112);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.PlaceholderText = "ex) 010-1111-1111";
            TxtPhone.Size = new Size(150, 23);
            TxtPhone.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 115);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 0;
            label4.Text = "핸드폰 : ";
            // 
            // TxtGender
            // 
            TxtGender.Location = new Point(59, 83);
            TxtGender.Name = "TxtGender";
            TxtGender.PlaceholderText = "ex) 여";
            TxtGender.Size = new Size(150, 23);
            TxtGender.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 86);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "성별 : ";
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(59, 54);
            TxtAge.Name = "TxtAge";
            TxtAge.PlaceholderText = "ex) 30";
            TxtAge.Size = new Size(150, 23);
            TxtAge.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 57);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "나이 : ";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(59, 25);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "ex) 홍길동";
            TxtName.Size = new Size(150, 23);
            TxtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "이름 : ";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(472, 259);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 40);
            BtnCheck.TabIndex = 6;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // TxtResult
            // 
            TxtResult.BackColor = SystemColors.InactiveBorder;
            TxtResult.BorderStyle = BorderStyle.FixedSingle;
            TxtResult.Location = new Point(288, 37);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.Size = new Size(284, 216);
            TxtResult.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 12);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 6;
            label6.Text = "결과 ";
            label6.TextAlign = ContentAlignment.BottomCenter;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(584, 311);
            Controls.Add(label6);
            Controls.Add(TxtResult);
            Controls.Add(BtnCheck);
            Controls.Add(groupBox1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법학습 윈앱 1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnCheck;
        private Label label1;
        private TextBox TxtName;
        private TextBox TxtGender;
        private Label label3;
        private TextBox TxtAge;
        private Label label2;
        private TextBox TxtPhone;
        private Label label4;
        private TextBox TxtResult;
        private Label label6;
    }
}
