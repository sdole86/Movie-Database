﻿
namespace Semester_Project
{
    partial class AddMovieForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.directorBox = new System.Windows.Forms.TextBox();
            this.rottenTomatoBox = new System.Windows.Forms.TextBox();
            this.earningsBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Movie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Movie Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Director:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rotten Tomatos Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Box Office Earnings";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(136, 82);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(549, 23);
            this.titleBox.TabIndex = 10;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(136, 111);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(189, 23);
            this.yearBox.TabIndex = 11;
            // 
            // directorBox
            // 
            this.directorBox.Location = new System.Drawing.Point(136, 140);
            this.directorBox.Name = "directorBox";
            this.directorBox.Size = new System.Drawing.Size(189, 23);
            this.directorBox.TabIndex = 13;
            // 
            // rottenTomatoBox
            // 
            this.rottenTomatoBox.Location = new System.Drawing.Point(136, 169);
            this.rottenTomatoBox.Name = "rottenTomatoBox";
            this.rottenTomatoBox.Size = new System.Drawing.Size(189, 23);
            this.rottenTomatoBox.TabIndex = 14;
            // 
            // earningsBox
            // 
            this.earningsBox.Location = new System.Drawing.Point(496, 169);
            this.earningsBox.Name = "earningsBox";
            this.earningsBox.Size = new System.Drawing.Size(189, 23);
            this.earningsBox.TabIndex = 15;
            // 
            // genreBox
            // 
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(564, 111);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(121, 23);
            this.genreBox.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(4, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 61);
            this.panel1.TabIndex = 17;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(606, 20);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(132, 20);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(24, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 272);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.earningsBox);
            this.Controls.Add(this.rottenTomatoBox);
            this.Controls.Add(this.directorBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddMovieForm";
            this.Text = "AddMovieForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox directorBox;
        private System.Windows.Forms.TextBox rottenTomatoBox;
        private System.Windows.Forms.TextBox earningsBox;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
    }
}