namespace SyntaxWinApp04
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
            LblName = new Label();
            TxtName = new TextBox();
            LblAge = new Label();
            TxtAge = new TextBox();
            LblGender = new Label();
            RdoMan = new RadioButton();
            RdoFemale = new RadioButton();
            BtnMessage = new Button();
            LblResult = new Label();
            TxtResult = new TextBox();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(22, 19);
            LblName.Name = "LblName";
            LblName.Size = new Size(62, 15);
            LblName.TabIndex = 0;
            LblName.Text = "이름입력 :";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(90, 16);
            TxtName.Multiline = true;
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(194, 23);
            TxtName.TabIndex = 1;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(22, 48);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(62, 15);
            LblAge.TabIndex = 0;
            LblAge.Text = "나이입력 :";
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(90, 45);
            TxtAge.Multiline = true;
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(194, 23);
            TxtAge.TabIndex = 2;
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Location = new Point(22, 77);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(62, 15);
            LblGender.TabIndex = 0;
            LblGender.Text = "성별입력 :";
            // 
            // RdoMan
            // 
            RdoMan.AutoSize = true;
            RdoMan.Location = new Point(90, 75);
            RdoMan.Name = "RdoMan";
            RdoMan.Size = new Size(49, 19);
            RdoMan.TabIndex = 3;
            RdoMan.TabStop = true;
            RdoMan.Text = "남성";
            RdoMan.UseVisualStyleBackColor = true;
            // 
            // RdoFemale
            // 
            RdoFemale.AutoSize = true;
            RdoFemale.Location = new Point(145, 75);
            RdoFemale.Name = "RdoFemale";
            RdoFemale.Size = new Size(49, 19);
            RdoFemale.TabIndex = 4;
            RdoFemale.TabStop = true;
            RdoFemale.Text = "여성";
            RdoFemale.UseVisualStyleBackColor = true;
            // 
            // BtnMessage
            // 
            BtnMessage.Location = new Point(472, 259);
            BtnMessage.Name = "BtnMessage";
            BtnMessage.Size = new Size(100, 40);
            BtnMessage.TabIndex = 6;
            BtnMessage.Text = "확인";
            BtnMessage.UseVisualStyleBackColor = true;
            BtnMessage.Click += BtnMessage_Click;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(22, 134);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(62, 15);
            LblResult.TabIndex = 0;
            LblResult.Text = "결      과 :";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(90, 131);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(482, 23);
            TxtResult.TabIndex = 5;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnMessage);
            Controls.Add(RdoFemale);
            Controls.Add(RdoMan);
            Controls.Add(LblGender);
            Controls.Add(TxtResult);
            Controls.Add(LblResult);
            Controls.Add(TxtAge);
            Controls.Add(LblAge);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Name = "FrmMain";
            Text = "문법연습 윈앱 04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private Label LblAge;
        private TextBox TxtAge;
        private Label LblGender;
        private RadioButton RdoMan;
        private RadioButton RdoFemale;
        private Button BtnMessage;
        private Label LblResult;
        private TextBox TxtResult;
    }
}
