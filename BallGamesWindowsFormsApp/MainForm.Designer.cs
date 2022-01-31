namespace BallGamesWindowsFormsApp
{
    partial class MainForm
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
            this.stopeBallButton = new System.Windows.Forms.Button();
            this.createSomeBallsButton = new System.Windows.Forms.Button();
            this.titleCountBallsLabel = new System.Windows.Forms.Label();
            this.countBallsLabel = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopeBallButton
            // 
            this.stopeBallButton.Location = new System.Drawing.Point(713, 34);
            this.stopeBallButton.Name = "stopeBallButton";
            this.stopeBallButton.Size = new System.Drawing.Size(75, 40);
            this.stopeBallButton.TabIndex = 2;
            this.stopeBallButton.Text = "Остановить все шарики";
            this.stopeBallButton.UseVisualStyleBackColor = true;
            this.stopeBallButton.Click += new System.EventHandler(this.stopeBallButton_Click);
            // 
            // createSomeBallsButton
            // 
            this.createSomeBallsButton.Location = new System.Drawing.Point(12, 35);
            this.createSomeBallsButton.Name = "createSomeBallsButton";
            this.createSomeBallsButton.Size = new System.Drawing.Size(108, 39);
            this.createSomeBallsButton.TabIndex = 3;
            this.createSomeBallsButton.Text = "Создать много шариков";
            this.createSomeBallsButton.UseVisualStyleBackColor = true;
            this.createSomeBallsButton.Click += new System.EventHandler(this.createSomeBallsButton_Click);
            // 
            // titleCountBallsLabel
            // 
            this.titleCountBallsLabel.AutoSize = true;
            this.titleCountBallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleCountBallsLabel.Location = new System.Drawing.Point(126, 44);
            this.titleCountBallsLabel.Name = "titleCountBallsLabel";
            this.titleCountBallsLabel.Size = new System.Drawing.Size(167, 20);
            this.titleCountBallsLabel.TabIndex = 4;
            this.titleCountBallsLabel.Text = "Поймано шариков:";
            // 
            // countBallsLabel
            // 
            this.countBallsLabel.AutoSize = true;
            this.countBallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.countBallsLabel.Location = new System.Drawing.Point(299, 44);
            this.countBallsLabel.Name = "countBallsLabel";
            this.countBallsLabel.Size = new System.Drawing.Size(19, 20);
            this.countBallsLabel.TabIndex = 5;
            this.countBallsLabel.Text = "0";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "Рестарт";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countBallsLabel);
            this.Controls.Add(this.titleCountBallsLabel);
            this.Controls.Add(this.createSomeBallsButton);
            this.Controls.Add(this.stopeBallButton);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainForm";
            this.Text = "Мячики";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button stopeBallButton;
        private System.Windows.Forms.Button createSomeBallsButton;
        private System.Windows.Forms.Label titleCountBallsLabel;
        private System.Windows.Forms.Label countBallsLabel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

