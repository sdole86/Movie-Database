
namespace Semester_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMovie
            // 
            this.dgvMovie.AllowUserToAddRows = false;
            this.dgvMovie.AllowUserToDeleteRows = false;
            this.dgvMovie.AllowUserToOrderColumns = true;
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Location = new System.Drawing.Point(12, 78);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.ReadOnly = true;
            this.dgvMovie.RowTemplate.Height = 25;
            this.dgvMovie.Size = new System.Drawing.Size(1073, 430);
            this.dgvMovie.TabIndex = 0;
            this.dgvMovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuMaintenance,
            this.mnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefresh,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.Size = new System.Drawing.Size(134, 22);
            this.mnuRefresh.Text = "Refresh List";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(134, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuMaintenance
            // 
            this.mnuMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMovie,
            this.mnuUpdateMovie,
            this.mnuDeleteMovie});
            this.mnuMaintenance.Name = "mnuMaintenance";
            this.mnuMaintenance.Size = new System.Drawing.Size(88, 20);
            this.mnuMaintenance.Text = "Maintenance";
            // 
            // mnuAddMovie
            // 
            this.mnuAddMovie.Name = "mnuAddMovie";
            this.mnuAddMovie.Size = new System.Drawing.Size(180, 22);
            this.mnuAddMovie.Text = "Add Movie";
            this.mnuAddMovie.Click += new System.EventHandler(this.mnuAddMovie_Click);
            // 
            // mnuUpdateMovie
            // 
            this.mnuUpdateMovie.Name = "mnuUpdateMovie";
            this.mnuUpdateMovie.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateMovie.Text = "Update Movie";
            this.mnuUpdateMovie.Click += new System.EventHandler(this.mnuUpdateMovie_Click);
            // 
            // mnuDeleteMovie
            // 
            this.mnuDeleteMovie.Name = "mnuDeleteMovie";
            this.mnuDeleteMovie.Size = new System.Drawing.Size(180, 22);
            this.mnuDeleteMovie.Text = "Delete Movie";
            this.mnuDeleteMovie.Click += new System.EventHandler(this.mnuDeleteMovie_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movies Master List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMovie);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Movies Master List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMaintenance;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.Label label1;
    }
}

