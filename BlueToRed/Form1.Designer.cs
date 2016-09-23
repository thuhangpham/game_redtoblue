namespace BlueToRed
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOneMove = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblMoved = new System.Windows.Forms.Label();
            this.lblCounted = new System.Windows.Forms.Label();
            this.level1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.level1ToolStripMenuItem,
            this.level2ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnOneMove
            // 
            this.btnOneMove.Enabled = false;
            this.btnOneMove.Location = new System.Drawing.Point(85, 150);
            this.btnOneMove.Name = "btnOneMove";
            this.btnOneMove.Size = new System.Drawing.Size(75, 23);
            this.btnOneMove.TabIndex = 3;
            this.btnOneMove.Text = "One Move";
            this.btnOneMove.UseVisualStyleBackColor = true;
            this.btnOneMove.Click += new System.EventHandler(this.btnOneMove_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(198, 150);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblMoved
            // 
            this.lblMoved.AutoSize = true;
            this.lblMoved.Enabled = false;
            this.lblMoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoved.ForeColor = System.Drawing.Color.Red;
            this.lblMoved.Location = new System.Drawing.Point(179, 64);
            this.lblMoved.Name = "lblMoved";
            this.lblMoved.Size = new System.Drawing.Size(24, 25);
            this.lblMoved.TabIndex = 5;
            this.lblMoved.Text = "0";
            // 
            // lblCounted
            // 
            this.lblCounted.AutoSize = true;
            this.lblCounted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCounted.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCounted.Location = new System.Drawing.Point(266, 64);
            this.lblCounted.Name = "lblCounted";
            this.lblCounted.Size = new System.Drawing.Size(24, 25);
            this.lblCounted.TabIndex = 6;
            this.lblCounted.Text = "0";
            // 
            // level1ToolStripMenuItem
            // 
            this.level1ToolStripMenuItem.Name = "level1ToolStripMenuItem";
            this.level1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.level1ToolStripMenuItem.Text = "Level 1";
            this.level1ToolStripMenuItem.Click += new System.EventHandler(this.level1ToolStripMenuItem_Click);
            // 
            // level2ToolStripMenuItem
            // 
            this.level2ToolStripMenuItem.Name = "level2ToolStripMenuItem";
            this.level2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.level2ToolStripMenuItem.Text = "Level 2";
            this.level2ToolStripMenuItem.Click += new System.EventHandler(this.level2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(531, 348);
            this.Controls.Add(this.lblCounted);
            this.Controls.Add(this.lblMoved);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnOneMove);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btnOneMove;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblMoved;
        private System.Windows.Forms.Label lblCounted;
        private System.Windows.Forms.ToolStripMenuItem level1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level2ToolStripMenuItem;
    }
}

