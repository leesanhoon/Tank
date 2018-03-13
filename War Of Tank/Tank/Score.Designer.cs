namespace Tank
{
    partial class FormScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScore));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.highBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.highBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.diemDataSet1 = new Tank.DiemDataSet1();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter1 = new Tank.DiemDataSet1TableAdapters.TableTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoreBindingSource)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Tank.Properties.Resources.Backgroud;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(124, 9);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(162, 31);
            this.lblHighScore.TabIndex = 1;
            this.lblHighScore.Text = "Player Score";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource1;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(41, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(337, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // highBindingSource1
            // 
            this.highBindingSource1.DataMember = "High";
            // 
            // highBindingSource
            // 
            this.highBindingSource.DataMember = "High";
            // 
            // highScoreBindingSource
            // 
            this.highScoreBindingSource.DataMember = "HighScore";
            // 
            // diemDataSet
            // 
            
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            
            // 
            // tableTableAdapter
            // 
            
            // 
            // diemDataSet1
            // 
            this.diemDataSet1.DataSetName = "DiemDataSet1";
            this.diemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.diemDataSet1;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn2.HeaderText = "Score";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 282);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormScore";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.FormScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoreBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.BindingSource highScoreBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        
        private System.Windows.Forms.BindingSource highBindingSource;
        
       
        private System.Windows.Forms.BindingSource highBindingSource1;
        
        private System.Windows.Forms.BindingSource tableBindingSource;
        
        private DiemDataSet1 diemDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private DiemDataSet1TableAdapters.TableTableAdapter tableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        
    }
}