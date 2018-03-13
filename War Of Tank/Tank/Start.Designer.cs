namespace Tank
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.prbStart = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prbStart)).BeginInit();
            this.SuspendLayout();
            // 
            // prbStart
            // 
            this.prbStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prbStart.Image = global::Tank.Properties.Resources.Capture;
            this.prbStart.Location = new System.Drawing.Point(0, 0);
            this.prbStart.Name = "prbStart";
            this.prbStart.Size = new System.Drawing.Size(984, 461);
            this.prbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbStart.TabIndex = 0;
            this.prbStart.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(778, 173);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHighScore
            // 
            this.btnHighScore.Location = new System.Drawing.Point(778, 213);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(75, 23);
            this.btnHighScore.TabIndex = 2;
            this.btnHighScore.Text = "Player Score";
            this.btnHighScore.UseVisualStyleBackColor = true;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(778, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.prbStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.Text = "War Of Tank";
            ((System.ComponentModel.ISupportInitialize)(this.prbStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox prbStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnExit;
    }
}

