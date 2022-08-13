
namespace MineSweeperOOP
{
    partial class SelectLevel
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
            this.lblGameLevel = new System.Windows.Forms.Label();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameLevel
            // 
            this.lblGameLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameLevel.Location = new System.Drawing.Point(12, 9);
            this.lblGameLevel.Name = "lblGameLevel";
            this.lblGameLevel.Size = new System.Drawing.Size(125, 38);
            this.lblGameLevel.TabIndex = 3;
            this.lblGameLevel.Text = "Select Difficulty:";
            this.lblGameLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(146, 60);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(87, 41);
            this.btnMedium.TabIndex = 4;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(265, 60);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(87, 41);
            this.btnHard.TabIndex = 5;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(28, 60);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(87, 41);
            this.btnEasy.TabIndex = 6;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // SelectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 130);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.lblGameLevel);
            this.Name = "SelectLevel";
            this.Text = "SelectLevel";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGameLevel;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnEasy;
    }
}