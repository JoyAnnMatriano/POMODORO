﻿
namespace POMODORO
{
    partial class POMODORO
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
            this.title_lbl = new System.Windows.Forms.Label();
            this.title2_lbl = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.title_lbl.Font = new System.Drawing.Font("SLEMAN", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_lbl.ForeColor = System.Drawing.Color.White;
            this.title_lbl.Location = new System.Drawing.Point(1, 203);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(411, 96);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "POMODORO";
            // 
            // title2_lbl
            // 
            this.title2_lbl.AutoSize = true;
            this.title2_lbl.Font = new System.Drawing.Font("Rage Italic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title2_lbl.ForeColor = System.Drawing.Color.White;
            this.title2_lbl.Location = new System.Drawing.Point(289, 275);
            this.title2_lbl.Name = "title2_lbl";
            this.title2_lbl.Size = new System.Drawing.Size(101, 24);
            this.title2_lbl.TabIndex = 1;
            this.title2_lbl.Text = "a time to heal";
            // 
            // start_btn
            // 
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Onyx", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(146, 312);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(115, 49);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            // 
            // quit_btn
            // 
            this.quit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit_btn.Font = new System.Drawing.Font("Onyx", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quit_btn.ForeColor = System.Drawing.Color.White;
            this.quit_btn.Location = new System.Drawing.Point(146, 367);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(115, 49);
            this.quit_btn.TabIndex = 2;
            this.quit_btn.Text = "QUIT";
            this.quit_btn.UseVisualStyleBackColor = true;
            // 
            // POMODORO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(415, 557);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.title2_lbl);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POMODORO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label title2_lbl;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button quit_btn;
    }
}
