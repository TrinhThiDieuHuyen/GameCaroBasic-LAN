namespace GameCaroLANServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Location = new System.Drawing.Point(13, 36);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(814, 676);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnLAN);
            this.panel2.Controls.Add(this.txbIP);
            this.panel2.Controls.Add(this.prcbCoolDown);
            this.panel2.Controls.Add(this.txbPlayerName);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(833, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 676);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(183, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "TO WIN !";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(18, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "5 IN A LINE";
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(4, 489);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(211, 39);
            this.btnLAN.TabIndex = 5;
            this.btnLAN.Text = "LAN";
            this.btnLAN.UseVisualStyleBackColor = true;
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(4, 461);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(211, 22);
            this.txbIP.TabIndex = 4;
            this.txbIP.Text = "192.168.2.106";
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(4, 418);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(211, 37);
            this.prcbCoolDown.TabIndex = 3;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(4, 390);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.ReadOnly = true;
            this.txbPlayerName.Size = new System.Drawing.Size(211, 22);
            this.txbPlayerName.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pctbMark);
            this.panel4.Location = new System.Drawing.Point(221, 389);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 142);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 379);
            this.panel3.TabIndex = 0;
            // 
            // pctbMark
            // 
            this.pctbMark.Location = new System.Drawing.Point(4, 4);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(152, 135);
            this.pctbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbMark.TabIndex = 0;
            this.pctbMark.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameCaroLANServer.Properties.Resources.logocaro_png;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.TmCoolDown_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game Caro (LAN Server)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

