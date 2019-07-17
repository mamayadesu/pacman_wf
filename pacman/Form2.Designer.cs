namespace pacman
{
    partial class Form2
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
            this.continueGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.difficultyCb = new System.Windows.Forms.ComboBox();
            this.difficultyInfo = new System.Windows.Forms.Label();
            this.closeGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sensor = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // continueGame
            // 
            this.continueGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.continueGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueGame.Location = new System.Drawing.Point(19, 13);
            this.continueGame.Margin = new System.Windows.Forms.Padding(4);
            this.continueGame.Name = "continueGame";
            this.continueGame.Size = new System.Drawing.Size(635, 80);
            this.continueGame.TabIndex = 0;
            this.continueGame.Text = "ПРОДОЛЖИТЬ";
            this.continueGame.UseVisualStyleBackColor = false;
            this.continueGame.Click += new System.EventHandler(this.continueGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "СЛОЖНОСТЬ";
            // 
            // difficultyCb
            // 
            this.difficultyCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyCb.FormattingEnabled = true;
            this.difficultyCb.Items.AddRange(new object[] {
            "Низкая",
            "Средняя",
            "Высокая"});
            this.difficultyCb.Location = new System.Drawing.Point(166, 216);
            this.difficultyCb.Name = "difficultyCb";
            this.difficultyCb.Size = new System.Drawing.Size(95, 26);
            this.difficultyCb.TabIndex = 2;
            this.difficultyCb.SelectedIndexChanged += new System.EventHandler(this.difficultyCb_SelectedIndexChanged);
            // 
            // difficultyInfo
            // 
            this.difficultyInfo.AutoSize = true;
            this.difficultyInfo.Location = new System.Drawing.Point(280, 219);
            this.difficultyInfo.Name = "difficultyInfo";
            this.difficultyInfo.Size = new System.Drawing.Size(120, 18);
            this.difficultyInfo.TabIndex = 3;
            this.difficultyInfo.Text = "difficultyInfo";
            // 
            // closeGame
            // 
            this.closeGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.closeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeGame.Location = new System.Drawing.Point(19, 115);
            this.closeGame.Margin = new System.Windows.Forms.Padding(4);
            this.closeGame.Name = "closeGame";
            this.closeGame.Size = new System.Drawing.Size(635, 80);
            this.closeGame.TabIndex = 4;
            this.closeGame.Text = "ВЫЙТИ ИЗ ИГРЫ";
            this.closeGame.UseVisualStyleBackColor = false;
            this.closeGame.Click += new System.EventHandler(this.closeGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "ВНИМАНИЕ!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Изменив уровень сложности, игру придётся начать сначала.";
            // 
            // sensor
            // 
            this.sensor.AutoSize = true;
            this.sensor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensor.Location = new System.Drawing.Point(19, 330);
            this.sensor.Name = "sensor";
            this.sensor.Size = new System.Drawing.Size(187, 22);
            this.sensor.TabIndex = 7;
            this.sensor.Text = "Сенсорное управление";
            this.sensor.UseVisualStyleBackColor = true;
            this.sensor.CheckedChanged += new System.EventHandler(this.sensor_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "© SHARAGA GAMES";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(667, 417);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sensor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeGame);
            this.Controls.Add(this.difficultyInfo);
            this.Controls.Add(this.difficultyCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.continueGame);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пауза";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button continueGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox difficultyCb;
        private System.Windows.Forms.Label difficultyInfo;
        private System.Windows.Forms.Button closeGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox sensor;
        private System.Windows.Forms.Label label4;
    }
}