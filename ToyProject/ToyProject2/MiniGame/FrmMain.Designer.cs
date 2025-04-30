namespace MiniGame
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
            panelGameArea = new Panel();
            BtnTicTacToe = new Button();
            BtnMemory = new Button();
            BtnRps = new Button();
            SuspendLayout();
            // 
            // panelGameArea
            // 
            panelGameArea.Location = new Point(12, 39);
            panelGameArea.Name = "panelGameArea";
            panelGameArea.Size = new Size(363, 363);
            panelGameArea.TabIndex = 0;
            // 
            // BtnTicTacToe
            // 
            BtnTicTacToe.Location = new Point(12, 6);
            BtnTicTacToe.Name = "BtnTicTacToe";
            BtnTicTacToe.Size = new Size(88, 23);
            BtnTicTacToe.TabIndex = 1;
            BtnTicTacToe.Text = "TicTacToe";
            BtnTicTacToe.UseVisualStyleBackColor = true;
            BtnTicTacToe.Click += BtnTicTacToe_Click;
            // 
            // BtnMemory
            // 
            BtnMemory.Location = new Point(106, 6);
            BtnMemory.Name = "BtnMemory";
            BtnMemory.Size = new Size(88, 23);
            BtnMemory.TabIndex = 1;
            BtnMemory.Text = "Memory";
            BtnMemory.UseVisualStyleBackColor = true;
            BtnMemory.Click += BtnTicTacToe_Click;
            // 
            // BtnRps
            // 
            BtnRps.Location = new Point(200, 6);
            BtnRps.Name = "BtnRps";
            BtnRps.Size = new Size(88, 23);
            BtnRps.TabIndex = 1;
            BtnRps.Text = "RPS";
            BtnRps.UseVisualStyleBackColor = true;
            BtnRps.Click += BtnTicTacToe_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 414);
            Controls.Add(BtnRps);
            Controls.Add(BtnMemory);
            Controls.Add(BtnTicTacToe);
            Controls.Add(panelGameArea);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "윈앱 미니 게임";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTicTacToe;
        private Panel panelGameArea;
        private Button BtnTicTacToe;
        private Button BtnMemory;
        private Button BtnRps;
    }
}
