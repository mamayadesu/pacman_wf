namespace pacman
{
    partial class Form3
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
            this.up = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // up
            // 
            this.up.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.up.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.up.Location = new System.Drawing.Point(102, 8);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(90, 90);
            this.up.TabIndex = 0;
            this.up.Text = "↑";
            this.up.UseVisualStyleBackColor = true;
            this.up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s_MouseDown);
            this.up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s_MouseUp);
            // 
            // left
            // 
            this.left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.left.Location = new System.Drawing.Point(7, 94);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(90, 90);
            this.left.TabIndex = 1;
            this.left.Text = "←";
            this.left.UseVisualStyleBackColor = true;
            this.left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s_MouseDown);
            this.left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s_MouseUp);
            // 
            // down
            // 
            this.down.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.down.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.down.Location = new System.Drawing.Point(102, 100);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(90, 90);
            this.down.TabIndex = 2;
            this.down.Text = "↓";
            this.down.UseVisualStyleBackColor = true;
            this.down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s_MouseDown);
            this.down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s_MouseUp);
            // 
            // right
            // 
            this.right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right.Location = new System.Drawing.Point(196, 94);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(90, 90);
            this.right.TabIndex = 3;
            this.right.Text = "→";
            this.right.UseVisualStyleBackColor = true;
            this.right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s_MouseDown);
            this.right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s_MouseUp);
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pauseButton.Location = new System.Drawing.Point(79, 217);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(132, 41);
            this.pauseButton.TabIndex = 4;
            this.pauseButton.Text = "ПАУЗА";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(7, 8);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(64, 64);
            this.info.TabIndex = 5;
            this.info.Text = "Инфо";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(216, 8);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(64, 64);
            this.newGame.TabIndex = 6;
            this.newGame.Text = "Заново";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.ControlBox = false;
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.right);
            this.Controls.Add(this.down);
            this.Controls.Add(this.left);
            this.Controls.Add(this.up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Сенсорное управление";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Resize += new System.EventHandler(this.Form3_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button newGame;
    }
}