
namespace MineSweeperOOP
{
    partial class Minesweeper
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtflag = new System.Windows.Forms.Label();
            this.lblflags = new System.Windows.Forms.Label();
            this.pnlMineField = new System.Windows.Forms.FlowLayoutPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbltimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 9);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 34);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtflag
            // 
            this.txtflag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtflag.Location = new System.Drawing.Point(99, 20);
            this.txtflag.Name = "txtflag";
            this.txtflag.Size = new System.Drawing.Size(45, 23);
            this.txtflag.TabIndex = 4;
            this.txtflag.Text = "Flags:";
            this.txtflag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblflags
            // 
            this.lblflags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblflags.Location = new System.Drawing.Point(139, 20);
            this.lblflags.Name = "lblflags";
            this.lblflags.Size = new System.Drawing.Size(30, 23);
            this.lblflags.TabIndex = 5;
            this.lblflags.Text = "00";
            this.lblflags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMineField
            // 
            this.pnlMineField.Location = new System.Drawing.Point(12, 56);
            this.pnlMineField.Name = "pnlMineField";
            this.pnlMineField.Size = new System.Drawing.Size(200, 100);
            this.pnlMineField.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.Location = new System.Drawing.Point(190, 23);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(22, 16);
            this.lbltimer.TabIndex = 7;
            this.lbltimer.Text = "00";
            // 
            // Minesweeper
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 724);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.pnlMineField);
            this.Controls.Add(this.lblflags);
            this.Controls.Add(this.txtflag);
            this.Controls.Add(this.btnStart);
            this.Name = "Minesweeper";
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtflag;
        private System.Windows.Forms.Label lblflags;
        private System.Windows.Forms.FlowLayoutPanel pnlMineField;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbltimer;
    }
}

