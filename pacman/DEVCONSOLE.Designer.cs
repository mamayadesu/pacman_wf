namespace pacman
{
    partial class DEVCONSOLE
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
            this.label1 = new System.Windows.Forms.Label();
            this.vsgVarName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vsgValue = new System.Windows.Forms.TextBox();
            this.vsgType = new System.Windows.Forms.ComboBox();
            this.vsgSet = new System.Windows.Forms.Button();
            this.vsgGet = new System.Windows.Forms.Button();
            this.setDone = new System.Windows.Forms.Label();
            this.vsgBoolValue = new System.Windows.Forms.ComboBox();
            this.vsgNull = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Variable setter/getter";
            // 
            // vsgVarName
            // 
            this.vsgVarName.Location = new System.Drawing.Point(16, 30);
            this.vsgVarName.Name = "vsgVarName";
            this.vsgVarName.Size = new System.Drawing.Size(100, 20);
            this.vsgVarName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // vsgValue
            // 
            this.vsgValue.Location = new System.Drawing.Point(141, 30);
            this.vsgValue.Name = "vsgValue";
            this.vsgValue.Size = new System.Drawing.Size(100, 20);
            this.vsgValue.TabIndex = 3;
            this.vsgValue.TextChanged += new System.EventHandler(this.vsgValue_TextChanged);
            // 
            // vsgType
            // 
            this.vsgType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vsgType.FormattingEnabled = true;
            this.vsgType.Items.AddRange(new object[] {
            "string",
            "int",
            "double",
            "bool",
            "long",
            "null"});
            this.vsgType.Location = new System.Drawing.Point(141, 54);
            this.vsgType.Name = "vsgType";
            this.vsgType.Size = new System.Drawing.Size(100, 21);
            this.vsgType.TabIndex = 4;
            this.vsgType.SelectedIndexChanged += new System.EventHandler(this.vsgValue_TextChanged);
            // 
            // vsgSet
            // 
            this.vsgSet.Location = new System.Drawing.Point(16, 54);
            this.vsgSet.Name = "vsgSet";
            this.vsgSet.Size = new System.Drawing.Size(41, 23);
            this.vsgSet.TabIndex = 5;
            this.vsgSet.Text = "Set";
            this.vsgSet.UseVisualStyleBackColor = true;
            this.vsgSet.Click += new System.EventHandler(this.vsgSet_Click);
            // 
            // vsgGet
            // 
            this.vsgGet.Location = new System.Drawing.Point(75, 54);
            this.vsgGet.Name = "vsgGet";
            this.vsgGet.Size = new System.Drawing.Size(41, 23);
            this.vsgGet.TabIndex = 6;
            this.vsgGet.Text = "Get";
            this.vsgGet.UseVisualStyleBackColor = true;
            this.vsgGet.Click += new System.EventHandler(this.vsgGet_Click);
            // 
            // setDone
            // 
            this.setDone.AutoSize = true;
            this.setDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setDone.ForeColor = System.Drawing.Color.Green;
            this.setDone.Location = new System.Drawing.Point(16, 84);
            this.setDone.Name = "setDone";
            this.setDone.Size = new System.Drawing.Size(41, 13);
            this.setDone.TabIndex = 7;
            this.setDone.Text = "Done!";
            this.setDone.Visible = false;
            // 
            // vsgBoolValue
            // 
            this.vsgBoolValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vsgBoolValue.FormattingEnabled = true;
            this.vsgBoolValue.Items.AddRange(new object[] {
            "true",
            "false"});
            this.vsgBoolValue.Location = new System.Drawing.Point(141, 10);
            this.vsgBoolValue.Name = "vsgBoolValue";
            this.vsgBoolValue.Size = new System.Drawing.Size(68, 21);
            this.vsgBoolValue.TabIndex = 8;
            this.vsgBoolValue.Visible = false;
            // 
            // vsgNull
            // 
            this.vsgNull.AutoSize = true;
            this.vsgNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vsgNull.Location = new System.Drawing.Point(138, 100);
            this.vsgNull.Name = "vsgNull";
            this.vsgNull.Size = new System.Drawing.Size(39, 13);
            this.vsgNull.TabIndex = 9;
            this.vsgNull.Text = "NULL";
            this.vsgNull.Visible = false;
            // 
            // DEVCONSOLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.vsgNull);
            this.Controls.Add(this.vsgBoolValue);
            this.Controls.Add(this.setDone);
            this.Controls.Add(this.vsgGet);
            this.Controls.Add(this.vsgSet);
            this.Controls.Add(this.vsgType);
            this.Controls.Add(this.vsgValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vsgVarName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DEVCONSOLE";
            this.Text = "DEVCONSOLE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DEVCONSOLE_FormClosing);
            this.Load += new System.EventHandler(this.DEVCONSOLE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vsgVarName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vsgValue;
        private System.Windows.Forms.ComboBox vsgType;
        private System.Windows.Forms.Button vsgSet;
        private System.Windows.Forms.Button vsgGet;
        private System.Windows.Forms.Label setDone;
        private System.Windows.Forms.ComboBox vsgBoolValue;
        private System.Windows.Forms.Label vsgNull;
    }
}