namespace NPCGEN
{
    partial class NPCSheet
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
            this.NPCText = new System.Windows.Forms.Label();
            this.NPCTextTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NPCText
            // 
            this.NPCText.AutoSize = true;
            this.NPCText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NPCText.Location = new System.Drawing.Point(12, 9);
            this.NPCText.Name = "NPCText";
            this.NPCText.Size = new System.Drawing.Size(59, 26);
            this.NPCText.TabIndex = 0;
            this.NPCText.Text = "NPC";
            this.NPCText.Click += new System.EventHandler(this.NPCText_Click);
            // 
            // NPCTextTwo
            // 
            this.NPCTextTwo.AutoSize = true;
            this.NPCTextTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NPCTextTwo.Location = new System.Drawing.Point(357, 9);
            this.NPCTextTwo.Name = "NPCTextTwo";
            this.NPCTextTwo.Size = new System.Drawing.Size(64, 26);
            this.NPCTextTwo.TabIndex = 1;
            this.NPCTextTwo.Text = "Skills";
            // 
            // NPCSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NPCTextTwo);
            this.Controls.Add(this.NPCText);
            this.Name = "NPCSheet";
            this.Text = "NPCSheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NPCText;
        private System.Windows.Forms.Label NPCTextTwo;
    }
}