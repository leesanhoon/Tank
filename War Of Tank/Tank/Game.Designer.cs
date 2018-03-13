namespace Tank
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.prbBullet = new System.Windows.Forms.PictureBox();
            this.prbPlayer = new System.Windows.Forms.PictureBox();
            this.prbEnemy4 = new System.Windows.Forms.PictureBox();
            this.prbEnemy3 = new System.Windows.Forms.PictureBox();
            this.prbEnemy2 = new System.Windows.Forms.PictureBox();
            this.prbEnemy1 = new System.Windows.Forms.PictureBox();
            this.prbBackground = new System.Windows.Forms.PictureBox();
            this.playtimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreText = new System.Windows.Forms.Label();
            this.bulletTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prbBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbEnemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbEnemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // prbBullet
            // 
            this.prbBullet.BackColor = System.Drawing.Color.Transparent;
            this.prbBullet.Image = global::Tank.Properties.Resources.bullet_bill_preview;
            this.prbBullet.Location = new System.Drawing.Point(485, 189);
            this.prbBullet.Name = "prbBullet";
            this.prbBullet.Size = new System.Drawing.Size(15, 15);
            this.prbBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbBullet.TabIndex = 6;
            this.prbBullet.TabStop = false;
            // 
            // prbPlayer
            // 
            this.prbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.prbPlayer.Image = global::Tank.Properties.Resources.tanks_1;
            this.prbPlayer.Location = new System.Drawing.Point(471, 210);
            this.prbPlayer.Name = "prbPlayer";
            this.prbPlayer.Size = new System.Drawing.Size(40, 40);
            this.prbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbPlayer.TabIndex = 5;
            this.prbPlayer.TabStop = false;
            // 
            // prbEnemy4
            // 
            this.prbEnemy4.BackColor = System.Drawing.Color.Transparent;
            this.prbEnemy4.Image = global::Tank.Properties.Resources.tanks_112;
            this.prbEnemy4.Location = new System.Drawing.Point(0, 210);
            this.prbEnemy4.Name = "prbEnemy4";
            this.prbEnemy4.Size = new System.Drawing.Size(40, 40);
            this.prbEnemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbEnemy4.TabIndex = 4;
            this.prbEnemy4.TabStop = false;
            // 
            // prbEnemy3
            // 
            this.prbEnemy3.BackColor = System.Drawing.Color.Transparent;
            this.prbEnemy3.Image = global::Tank.Properties.Resources.tanks_111;
            this.prbEnemy3.Location = new System.Drawing.Point(471, 421);
            this.prbEnemy3.Name = "prbEnemy3";
            this.prbEnemy3.Size = new System.Drawing.Size(40, 40);
            this.prbEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbEnemy3.TabIndex = 3;
            this.prbEnemy3.TabStop = false;
            // 
            // prbEnemy2
            // 
            this.prbEnemy2.BackColor = System.Drawing.Color.Transparent;
            this.prbEnemy2.Image = global::Tank.Properties.Resources.tanks_11;
            this.prbEnemy2.Location = new System.Drawing.Point(944, 210);
            this.prbEnemy2.Name = "prbEnemy2";
            this.prbEnemy2.Size = new System.Drawing.Size(40, 40);
            this.prbEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbEnemy2.TabIndex = 2;
            this.prbEnemy2.TabStop = false;
            // 
            // prbEnemy1
            // 
            this.prbEnemy1.BackColor = System.Drawing.Color.Transparent;
            this.prbEnemy1.Image = global::Tank.Properties.Resources.tanks_11111;
            this.prbEnemy1.Location = new System.Drawing.Point(471, 0);
            this.prbEnemy1.Name = "prbEnemy1";
            this.prbEnemy1.Size = new System.Drawing.Size(40, 40);
            this.prbEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbEnemy1.TabIndex = 1;
            this.prbEnemy1.TabStop = false;
            // 
            // prbBackground
            // 
            this.prbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prbBackground.Image = global::Tank.Properties.Resources.Backgroud;
            this.prbBackground.Location = new System.Drawing.Point(0, 0);
            this.prbBackground.Name = "prbBackground";
            this.prbBackground.Size = new System.Drawing.Size(984, 461);
            this.prbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbBackground.TabIndex = 0;
            this.prbBackground.TabStop = false;
            // 
            // playtimer
            // 
            this.playtimer.Enabled = true;
            this.playtimer.Interval = 20;
            this.playtimer.Tick += new System.EventHandler(this.playtimer_Tick);
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.Transparent;
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(25, 15);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(25, 25);
            this.ScoreText.TabIndex = 7;
            this.ScoreText.Text = "0";
            // 
            // bulletTimer
            // 
            this.bulletTimer.Enabled = true;
            this.bulletTimer.Interval = 20;
            
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.prbBullet);
            this.Controls.Add(this.prbPlayer);
            this.Controls.Add(this.prbEnemy4);
            this.Controls.Add(this.prbEnemy3);
            this.Controls.Add(this.prbEnemy2);
            this.Controls.Add(this.prbEnemy1);
            this.Controls.Add(this.prbBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGame";
            this.Text = "War Of Tank";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            
            ((System.ComponentModel.ISupportInitialize)(this.prbBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbEnemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbEnemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox prbBackground;
        private System.Windows.Forms.PictureBox prbEnemy1;
        private System.Windows.Forms.PictureBox prbEnemy2;
        private System.Windows.Forms.PictureBox prbEnemy3;
        private System.Windows.Forms.PictureBox prbEnemy4;
        private System.Windows.Forms.PictureBox prbPlayer;
        private System.Windows.Forms.PictureBox prbBullet;
        private System.Windows.Forms.Timer playtimer;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer bulletTimer;
    }
}