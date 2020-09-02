namespace LToolsGUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileDropdown = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileDropdown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsDropdown = new System.Windows.Forms.ToolStripMenuItem();
            this.summonerInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SummonerButton = new System.Windows.Forms.Button();
            this.RankedButton = new System.Windows.Forms.Button();
            this.MasteryButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDropdown,
            this.toolsDropdown});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileDropdown
            // 
            this.fileDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitFileDropdown});
            this.fileDropdown.Name = "fileDropdown";
            this.fileDropdown.Size = new System.Drawing.Size(37, 20);
            this.fileDropdown.Text = "File";
            // 
            // exitFileDropdown
            // 
            this.exitFileDropdown.Name = "exitFileDropdown";
            this.exitFileDropdown.Size = new System.Drawing.Size(93, 22);
            this.exitFileDropdown.Text = "Exit";
            // 
            // toolsDropdown
            // 
            this.toolsDropdown.Name = "toolsDropdown";
            this.toolsDropdown.Size = new System.Drawing.Size(46, 20);
            this.toolsDropdown.Text = "Tools";
            // 
            // summonerInput
            // 
            this.summonerInput.Location = new System.Drawing.Point(29, 57);
            this.summonerInput.Name = "summonerInput";
            this.summonerInput.Size = new System.Drawing.Size(129, 20);
            this.summonerInput.TabIndex = 1;
            this.summonerInput.TextChanged += new System.EventHandler(this.SummonerInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input a Summoner Name...";
            // 
            // SummonerButton
            // 
            this.SummonerButton.Location = new System.Drawing.Point(229, 57);
            this.SummonerButton.Name = "SummonerButton";
            this.SummonerButton.Size = new System.Drawing.Size(109, 54);
            this.SummonerButton.TabIndex = 3;
            this.SummonerButton.Text = "Get Summoner Data";
            this.SummonerButton.UseVisualStyleBackColor = true;
            this.SummonerButton.Click += new System.EventHandler(this.SummonerButton_Click);
            // 
            // RankedButton
            // 
            this.RankedButton.Location = new System.Drawing.Point(229, 128);
            this.RankedButton.Name = "RankedButton";
            this.RankedButton.Size = new System.Drawing.Size(109, 54);
            this.RankedButton.TabIndex = 4;
            this.RankedButton.Text = "Get Ranked Stats";
            this.RankedButton.UseVisualStyleBackColor = true;
            this.RankedButton.Click += new System.EventHandler(this.RankedButton_Click);
            // 
            // MasteryButton
            // 
            this.MasteryButton.Location = new System.Drawing.Point(229, 200);
            this.MasteryButton.Name = "MasteryButton";
            this.MasteryButton.Size = new System.Drawing.Size(109, 54);
            this.MasteryButton.TabIndex = 5;
            this.MasteryButton.Text = "Get Champion Mastery";
            this.MasteryButton.UseVisualStyleBackColor = true;
            this.MasteryButton.Click += new System.EventHandler(this.MasteryButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(32, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Get the top";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mastery Champions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 333);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MasteryButton);
            this.Controls.Add(this.RankedButton);
            this.Controls.Add(this.SummonerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summonerInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LeagueTool Alpha";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileDropdown;
        private System.Windows.Forms.ToolStripMenuItem exitFileDropdown;
        private System.Windows.Forms.ToolStripMenuItem toolsDropdown;
        private System.Windows.Forms.TextBox summonerInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SummonerButton;
        private System.Windows.Forms.Button RankedButton;
        private System.Windows.Forms.Button MasteryButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

