namespace PlayGameForm
{
    partial class ViewResult
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
            this.lblGame = new System.Windows.Forms.Label();
            this.lblGameScore = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.DGVNumberList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNumberList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblGame.Location = new System.Drawing.Point(279, 320);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(148, 29);
            this.lblGame.TabIndex = 1;
            this.lblGame.Text = "Game Score: ";
            // 
            // lblGameScore
            // 
            this.lblGameScore.AutoSize = true;
            this.lblGameScore.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblGameScore.Location = new System.Drawing.Point(433, 320);
            this.lblGameScore.Name = "lblGameScore";
            this.lblGameScore.Size = new System.Drawing.Size(25, 29);
            this.lblGameScore.TabIndex = 2;
            this.lblGameScore.Text = "0";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblResult.Location = new System.Drawing.Point(319, 390);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(68, 25);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            // 
            // DGVNumberList
            // 
            this.DGVNumberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNumberList.Location = new System.Drawing.Point(23, 13);
            this.DGVNumberList.Name = "DGVNumberList";
            this.DGVNumberList.RowHeadersWidth = 51;
            this.DGVNumberList.RowTemplate.Height = 24;
            this.DGVNumberList.Size = new System.Drawing.Size(765, 294);
            this.DGVNumberList.TabIndex = 4;
            // 
            // ViewResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVNumberList);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblGameScore);
            this.Controls.Add(this.lblGame);
            this.Name = "ViewResult";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ViewResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNumberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblGameScore;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView DGVNumberList;
    }
}