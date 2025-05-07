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
            BtnWhackAMole = new Button();
            SuspendLayout();
            // 
            // panelGameArea
            // 
            panelGameArea.Location = new Point(11, 39);
            panelGameArea.Name = "panelGameArea";
            panelGameArea.Size = new Size(363, 363);
            panelGameArea.TabIndex = 0;
            // 
            // BtnTicTacToe
            // 
            BtnTicTacToe.BackColor = Color.White;
            BtnTicTacToe.Font = new Font("나눔고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnTicTacToe.Location = new Point(11, 6);
            BtnTicTacToe.Name = "BtnTicTacToe";
            BtnTicTacToe.Size = new Size(113, 27);
            BtnTicTacToe.TabIndex = 1;
            BtnTicTacToe.Text = "TicTacToe";
            BtnTicTacToe.UseVisualStyleBackColor = false;
            BtnTicTacToe.Click += BtnTicTacToe_Click;
            // 
            // BtnMemory
            // 
            BtnMemory.BackColor = Color.White;
            BtnMemory.Font = new Font("나눔고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnMemory.Location = new Point(130, 6);
            BtnMemory.Name = "BtnMemory";
            BtnMemory.Size = new Size(118, 27);
            BtnMemory.TabIndex = 1;
            BtnMemory.Text = "Memory Game";
            BtnMemory.UseVisualStyleBackColor = false;
            BtnMemory.Click += BtnMemory_Click;
            // 
            // BtnWhackAMole
            // 
            BtnWhackAMole.BackColor = Color.White;
            BtnWhackAMole.Font = new Font("나눔고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnWhackAMole.Location = new Point(254, 6);
            BtnWhackAMole.Name = "BtnWhackAMole";
            BtnWhackAMole.Size = new Size(118, 27);
            BtnWhackAMole.TabIndex = 1;
            BtnWhackAMole.Text = "Whack-a-Mole";
            BtnWhackAMole.UseVisualStyleBackColor = false;
            BtnWhackAMole.Click += BtnWhackAMole_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(386, 414);
            Controls.Add(BtnWhackAMole);
            Controls.Add(BtnMemory);
            Controls.Add(BtnTicTacToe);
            Controls.Add(panelGameArea);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "윈앱 미니 게임";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTicTacToe;
        private Panel panelGameArea;
        private Button BtnTicTacToe;
        private Button BtnMemory;
        private Button BtnWhackAMole;
    }
}
