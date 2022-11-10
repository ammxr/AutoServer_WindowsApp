namespace MinecraftAutoServer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.serverVersion = new System.Windows.Forms.ComboBox();
            this.minRam = new System.Windows.Forms.TextBox();
            this.maxRam = new System.Windows.Forms.TextBox();
            this.importConfig = new System.Windows.Forms.Button();
            this.importResourcePack = new System.Windows.Forms.Button();
            this.importMods = new System.Windows.Forms.Button();
            this.importServerIcon = new System.Windows.Forms.Button();
            this.importMOTD = new System.Windows.Forms.Button();
            this.serverName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Eras Bold ITC", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(58, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(343, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "AUTOSERVER";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Eras Bold ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox2.Location = new System.Drawing.Point(12, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(141, 25);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Server Config";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Eras Bold ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox3.Location = new System.Drawing.Point(12, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(141, 25);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Server Decor";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Eras Bold ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox4.Location = new System.Drawing.Point(12, 397);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(141, 25);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Ram Limits";
            // 
            // serverVersion
            // 
            this.serverVersion.AccessibleName = "Select Version";
            this.serverVersion.AllowDrop = true;
            this.serverVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverVersion.FormattingEnabled = true;
            this.serverVersion.Items.AddRange(new object[] {
            "1.8.9",
            "1.9.11",
            "1.18.1"});
            this.serverVersion.Location = new System.Drawing.Point(12, 153);
            this.serverVersion.Name = "serverVersion";
            this.serverVersion.Size = new System.Drawing.Size(141, 21);
            this.serverVersion.TabIndex = 4;
            this.serverVersion.Text = "Select Sever Version";
            this.serverVersion.SelectedIndexChanged += new System.EventHandler(this.serverVersion_TextChanged);
            // 
            // minRam
            // 
            this.minRam.AcceptsReturn = true;
            this.minRam.AccessibleName = "Minimum Ram:";
            this.minRam.HideSelection = false;
            this.minRam.Location = new System.Drawing.Point(12, 428);
            this.minRam.Name = "minRam";
            this.minRam.Size = new System.Drawing.Size(60, 20);
            this.minRam.TabIndex = 5;
            this.minRam.Text = "Min";
            this.minRam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minRam.TextChanged += new System.EventHandler(this.minRam_TextChanged);
            // 
            // maxRam
            // 
            this.maxRam.AcceptsReturn = true;
            this.maxRam.AccessibleName = "Maximum Ram:";
            this.maxRam.Location = new System.Drawing.Point(78, 428);
            this.maxRam.Name = "maxRam";
            this.maxRam.Size = new System.Drawing.Size(63, 20);
            this.maxRam.TabIndex = 6;
            this.maxRam.Text = "Max";
            this.maxRam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // importConfig
            // 
            this.importConfig.Location = new System.Drawing.Point(12, 209);
            this.importConfig.Name = "importConfig";
            this.importConfig.Size = new System.Drawing.Size(141, 23);
            this.importConfig.TabIndex = 7;
            this.importConfig.Text = "Import Config File";
            this.importConfig.UseVisualStyleBackColor = true;
            this.importConfig.Click += new System.EventHandler(this.importConfig_Click);
            // 
            // importResourcePack
            // 
            this.importResourcePack.Location = new System.Drawing.Point(12, 362);
            this.importResourcePack.Name = "importResourcePack";
            this.importResourcePack.Size = new System.Drawing.Size(141, 23);
            this.importResourcePack.TabIndex = 8;
            this.importResourcePack.Text = "Import Resource Pack";
            this.importResourcePack.UseVisualStyleBackColor = true;
            // 
            // importMods
            // 
            this.importMods.Location = new System.Drawing.Point(12, 238);
            this.importMods.Name = "importMods";
            this.importMods.Size = new System.Drawing.Size(141, 23);
            this.importMods.TabIndex = 9;
            this.importMods.Text = "Import Mods";
            this.importMods.UseVisualStyleBackColor = true;
            this.importMods.Click += new System.EventHandler(this.importMods_Click);
            // 
            // importServerIcon
            // 
            this.importServerIcon.Location = new System.Drawing.Point(12, 333);
            this.importServerIcon.Name = "importServerIcon";
            this.importServerIcon.Size = new System.Drawing.Size(141, 23);
            this.importServerIcon.TabIndex = 11;
            this.importServerIcon.Text = "Import Server Icon";
            this.importServerIcon.UseVisualStyleBackColor = true;
            // 
            // importMOTD
            // 
            this.importMOTD.Location = new System.Drawing.Point(12, 304);
            this.importMOTD.Name = "importMOTD";
            this.importMOTD.Size = new System.Drawing.Size(141, 23);
            this.importMOTD.TabIndex = 10;
            this.importMOTD.Text = "Import MOTD";
            this.importMOTD.UseVisualStyleBackColor = true;
            // 
            // serverName
            // 
            this.serverName.AcceptsReturn = true;
            this.serverName.AccessibleName = "Minimum Ram:";
            this.serverName.HideSelection = false;
            this.serverName.Location = new System.Drawing.Point(12, 183);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(141, 20);
            this.serverName.TabIndex = 12;
            this.serverName.Text = "Enter Server Name";
            this.serverName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.serverName.TextChanged += new System.EventHandler(this.serverName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(238, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 232);
            this.panel1.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Eras Bold ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox5.Location = new System.Drawing.Point(238, 122);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(141, 25);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "Preview";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 483);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.serverName);
            this.Controls.Add(this.importServerIcon);
            this.Controls.Add(this.importMOTD);
            this.Controls.Add(this.importMods);
            this.Controls.Add(this.importResourcePack);
            this.Controls.Add(this.importConfig);
            this.Controls.Add(this.maxRam);
            this.Controls.Add(this.minRam);
            this.Controls.Add(this.serverVersion);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox serverVersion;
        private System.Windows.Forms.TextBox minRam;
        private System.Windows.Forms.TextBox maxRam;
        private System.Windows.Forms.Button importConfig;
        private System.Windows.Forms.Button importResourcePack;
        private System.Windows.Forms.Button importMods;
        private System.Windows.Forms.Button importServerIcon;
        private System.Windows.Forms.Button importMOTD;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
    }
}

