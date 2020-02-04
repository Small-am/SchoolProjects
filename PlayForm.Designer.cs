namespace PlayGameForm
{
    partial class PlayForm
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
            this.bttnRound = new System.Windows.Forms.Button();
            this.bttnView = new System.Windows.Forms.Button();
            this.lblRoundScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.bttnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnRound
            // 
            this.bttnRound.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.bttnRound.Location = new System.Drawing.Point(428, 130);
            this.bttnRound.Name = "bttnRound";
            this.bttnRound.Size = new System.Drawing.Size(137, 52);
            this.bttnRound.TabIndex = 0;
            this.bttnRound.Text = "Play Next Round";
            this.bttnRound.UseVisualStyleBackColor = true;
            this.bttnRound.Click += new System.EventHandler(this.bttnRound_Click);
            // 
            // bttnView
            // 
            this.bttnView.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.bttnView.Location = new System.Drawing.Point(428, 276);
            this.bttnView.Name = "bttnView";
            this.bttnView.Size = new System.Drawing.Size(137, 52);
            this.bttnView.TabIndex = 1;
            this.bttnView.Text = "View Result";
            this.bttnView.UseVisualStyleBackColor = true;
            this.bttnView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bttnView_MouseClick);
            // 
            // lblRoundScore
            // 
            this.lblRoundScore.AutoSize = true;
            this.lblRoundScore.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblRoundScore.Location = new System.Drawing.Point(239, 312);
            this.lblRoundScore.Name = "lblRoundScore";
            this.lblRoundScore.Size = new System.Drawing.Size(20, 22);
            this.lblRoundScore.TabIndex = 2;
            this.lblRoundScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.Location = new System.Drawing.Point(103, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numbers:";
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblNumbers.Location = new System.Drawing.Point(103, 198);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(168, 27);
            this.lblNumbers.TabIndex = 4;
            this.lblNumbers.Text = "0 0 0 0 0 0 0 0 0";
            // 
            // bttnRestart
            // 
            this.bttnRestart.Location = new System.Drawing.Point(285, 405);
            this.bttnRestart.Name = "bttnRestart";
            this.bttnRestart.Size = new System.Drawing.Size(75, 23);
            this.bttnRestart.TabIndex = 5;
            this.bttnRestart.Text = "Restart";
            this.bttnRestart.UseVisualStyleBackColor = true;
            this.bttnRestart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bttnRestart_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(103, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Round Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnRestart);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRoundScore);
            this.Controls.Add(this.bttnView);
            this.Controls.Add(this.bttnRound);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnRound;
        private System.Windows.Forms.Button bttnView;
        private System.Windows.Forms.Label lblRoundScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button bttnRestart;
        private System.Windows.Forms.Label label1;
    }
}

