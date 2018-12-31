namespace NPCGEN
{
    partial class Main
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
            this.PointsTextBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.ExoticLabel = new System.Windows.Forms.Label();
            this.ExoticCheckbox = new System.Windows.Forms.CheckBox();
            this.SupernaturalCheckbox = new System.Windows.Forms.CheckBox();
            this.SupernaturalLabel = new System.Windows.Forms.Label();
            this.GenerateNPC = new System.Windows.Forms.Button();
            this.TLLabel = new System.Windows.Forms.Label();
            this.TLTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PointsTextBox
            // 
            this.PointsTextBox.Location = new System.Drawing.Point(135, 45);
            this.PointsTextBox.Name = "PointsTextBox";
            this.PointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.PointsTextBox.TabIndex = 0;
            this.PointsTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(318, 28);
            this.Title.TabIndex = 1;
            this.Title.Text = "Gurps Random NPC Generator";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PointsLabel.Location = new System.Drawing.Point(38, 41);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(61, 24);
            this.PointsLabel.TabIndex = 2;
            this.PointsLabel.Text = "Points";
            this.PointsLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ExoticLabel
            // 
            this.ExoticLabel.AutoSize = true;
            this.ExoticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ExoticLabel.Location = new System.Drawing.Point(37, 176);
            this.ExoticLabel.Name = "ExoticLabel";
            this.ExoticLabel.Size = new System.Drawing.Size(62, 24);
            this.ExoticLabel.TabIndex = 3;
            this.ExoticLabel.Text = "Exotic";
            // 
            // ExoticCheckbox
            // 
            this.ExoticCheckbox.AutoSize = true;
            this.ExoticCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExoticCheckbox.Location = new System.Drawing.Point(220, 183);
            this.ExoticCheckbox.Name = "ExoticCheckbox";
            this.ExoticCheckbox.Size = new System.Drawing.Size(15, 14);
            this.ExoticCheckbox.TabIndex = 4;
            this.ExoticCheckbox.UseVisualStyleBackColor = true;
            // 
            // SupernaturalCheckbox
            // 
            this.SupernaturalCheckbox.AutoSize = true;
            this.SupernaturalCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SupernaturalCheckbox.Location = new System.Drawing.Point(220, 138);
            this.SupernaturalCheckbox.Name = "SupernaturalCheckbox";
            this.SupernaturalCheckbox.Size = new System.Drawing.Size(15, 14);
            this.SupernaturalCheckbox.TabIndex = 5;
            this.SupernaturalCheckbox.UseVisualStyleBackColor = true;
            // 
            // SupernaturalLabel
            // 
            this.SupernaturalLabel.AutoSize = true;
            this.SupernaturalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SupernaturalLabel.Location = new System.Drawing.Point(38, 131);
            this.SupernaturalLabel.Name = "SupernaturalLabel";
            this.SupernaturalLabel.Size = new System.Drawing.Size(117, 24);
            this.SupernaturalLabel.TabIndex = 6;
            this.SupernaturalLabel.Text = "Supernatural";
            this.SupernaturalLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // GenerateNPC
            // 
            this.GenerateNPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.GenerateNPC.Location = new System.Drawing.Point(71, 224);
            this.GenerateNPC.Name = "GenerateNPC";
            this.GenerateNPC.Size = new System.Drawing.Size(130, 52);
            this.GenerateNPC.TabIndex = 7;
            this.GenerateNPC.Text = "Generate";
            this.GenerateNPC.UseVisualStyleBackColor = true;
            this.GenerateNPC.Click += new System.EventHandler(this.GenerateNPC_Click);
            // 
            // TLLabel
            // 
            this.TLLabel.AutoSize = true;
            this.TLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TLLabel.Location = new System.Drawing.Point(38, 86);
            this.TLLabel.Name = "TLLabel";
            this.TLLabel.Size = new System.Drawing.Size(104, 24);
            this.TLLabel.TabIndex = 8;
            this.TLLabel.Text = "Tech Level";
            // 
            // TLTextBox
            // 
            this.TLTextBox.Location = new System.Drawing.Point(180, 91);
            this.TLTextBox.Name = "TLTextBox";
            this.TLTextBox.Size = new System.Drawing.Size(55, 20);
            this.TLTextBox.TabIndex = 9;
            this.TLTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 308);
            this.Controls.Add(this.TLTextBox);
            this.Controls.Add(this.TLLabel);
            this.Controls.Add(this.GenerateNPC);
            this.Controls.Add(this.SupernaturalLabel);
            this.Controls.Add(this.SupernaturalCheckbox);
            this.Controls.Add(this.ExoticCheckbox);
            this.Controls.Add(this.ExoticLabel);
            this.Controls.Add(this.PointsLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.PointsTextBox);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PointsTextBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Label ExoticLabel;
        private System.Windows.Forms.CheckBox ExoticCheckbox;
        private System.Windows.Forms.CheckBox SupernaturalCheckbox;
        private System.Windows.Forms.Label SupernaturalLabel;
        private System.Windows.Forms.Button GenerateNPC;
        private System.Windows.Forms.Label TLLabel;
        private System.Windows.Forms.TextBox TLTextBox;
    }
}

