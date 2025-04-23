﻿namespace SyntaxWinApp03
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
            BtnLoad = new Button();
            BtnSave = new Button();
            RtbNote = new RichTextBox();
            BtnRed = new Button();
            BtnBold = new Button();
            DlgOpen = new OpenFileDialog();
            DlgSave = new SaveFileDialog();
            DlgColor = new ColorDialog();
            SuspendLayout();
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(472, 252);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(100, 28);
            BtnLoad.TabIndex = 0;
            BtnLoad.Text = "읽기";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.White;
            BtnSave.Location = new Point(366, 252);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 28);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // RtbNote
            // 
            RtbNote.Font = new Font("나눔고딕", 10F);
            RtbNote.Location = new Point(12, 11);
            RtbNote.Name = "RtbNote";
            RtbNote.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            RtbNote.Size = new Size(560, 235);
            RtbNote.TabIndex = 1;
            RtbNote.Text = "";
            // 
            // BtnRed
            // 
            BtnRed.BackColor = Color.Red;
            BtnRed.Font = new Font("나눔고딕", 9F, FontStyle.Bold);
            BtnRed.ForeColor = Color.Red;
            BtnRed.Location = new Point(298, 252);
            BtnRed.Name = "BtnRed";
            BtnRed.Size = new Size(28, 28);
            BtnRed.TabIndex = 2;
            BtnRed.Text = "R";
            BtnRed.UseVisualStyleBackColor = false;
            BtnRed.Click += BtnRed_Click;
            // 
            // BtnBold
            // 
            BtnBold.BackColor = Color.FromArgb(255, 255, 192);
            BtnBold.Font = new Font("나눔고딕", 9F, FontStyle.Bold);
            BtnBold.Location = new Point(332, 252);
            BtnBold.Name = "BtnBold";
            BtnBold.Size = new Size(28, 28);
            BtnBold.TabIndex = 2;
            BtnBold.Text = "B";
            BtnBold.UseVisualStyleBackColor = false;
            BtnBold.Click += BtnBold_Click;
            // 
            // DlgOpen
            // 
            DlgOpen.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(584, 290);
            Controls.Add(BtnBold);
            Controls.Add(BtnRed);
            Controls.Add(RtbNote);
            Controls.Add(BtnSave);
            Controls.Add(BtnLoad);
            Font = new Font("나눔고딕", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "파일IO 윈앱";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnLoad;
        private Button BtnSave;
        private RichTextBox RtbNote;
        private Button BtnRed;
        private Button BtnBold;
        private OpenFileDialog DlgOpen;
        private SaveFileDialog DlgSave;
        private ColorDialog DlgColor;
    }
}
