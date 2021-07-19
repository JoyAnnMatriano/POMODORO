
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
            this.start_timer_btn = new System.Windows.Forms.Button();
            this.timer_txbx = new System.Windows.Forms.TextBox();
            this.stop_timer_btn = new System.Windows.Forms.Button();
            this.reset_timer_btn = new System.Windows.Forms.Button();
            this.back_main_btn = new System.Windows.Forms.Button();
            this.Resume_btn = new System.Windows.Forms.Button();
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
            this.title2_lbl.Location = new System.Drawing.Point(206, 275);
            this.title2_lbl.Name = "title2_lbl";
            this.title2_lbl.Size = new System.Drawing.Size(182, 24);
            this.title2_lbl.TabIndex = 1;
            this.title2_lbl.Text = "you can always find time";
            // 
            // start_btn
            // 
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Onyx", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(146, 312);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(115, 49);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit_btn.Font = new System.Drawing.Font("Onyx", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quit_btn.ForeColor = System.Drawing.Color.White;
            this.quit_btn.Location = new System.Drawing.Point(146, 367);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(115, 49);
            this.quit_btn.TabIndex = 2;
            this.quit_btn.Text = "QUIT";
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // start_timer_btn
            // 
            this.start_timer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_timer_btn.FlatAppearance.BorderSize = 3;
            this.start_timer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_timer_btn.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_timer_btn.ForeColor = System.Drawing.Color.White;
            this.start_timer_btn.Location = new System.Drawing.Point(126, 316);
            this.start_timer_btn.Name = "start_timer_btn";
            this.start_timer_btn.Size = new System.Drawing.Size(174, 54);
            this.start_timer_btn.TabIndex = 3;
            this.start_timer_btn.Text = "START";
            this.start_timer_btn.UseVisualStyleBackColor = true;
            this.start_timer_btn.Click += new System.EventHandler(this.start_timer_btn_Click);
            // 
            // timer_txbx
            // 
            this.timer_txbx.BackColor = System.Drawing.Color.RosyBrown;
            this.timer_txbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timer_txbx.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timer_txbx.ForeColor = System.Drawing.Color.White;
            this.timer_txbx.Location = new System.Drawing.Point(126, 203);
            this.timer_txbx.Multiline = true;
            this.timer_txbx.Name = "timer_txbx";
            this.timer_txbx.ReadOnly = true;
            this.timer_txbx.Size = new System.Drawing.Size(174, 34);
            this.timer_txbx.TabIndex = 4;
            this.timer_txbx.Text = "00:00:00";
            this.timer_txbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stop_timer_btn
            // 
            this.stop_timer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop_timer_btn.FlatAppearance.BorderSize = 3;
            this.stop_timer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_timer_btn.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stop_timer_btn.ForeColor = System.Drawing.Color.White;
            this.stop_timer_btn.Location = new System.Drawing.Point(126, 376);
            this.stop_timer_btn.Name = "stop_timer_btn";
            this.stop_timer_btn.Size = new System.Drawing.Size(174, 54);
            this.stop_timer_btn.TabIndex = 3;
            this.stop_timer_btn.Text = "STOP";
            this.stop_timer_btn.UseVisualStyleBackColor = true;
            this.stop_timer_btn.Click += new System.EventHandler(this.stop_timer_btn_Click);
            // 
            // reset_timer_btn
            // 
            this.reset_timer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_timer_btn.FlatAppearance.BorderSize = 3;
            this.reset_timer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_timer_btn.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reset_timer_btn.ForeColor = System.Drawing.Color.White;
            this.reset_timer_btn.Location = new System.Drawing.Point(126, 436);
            this.reset_timer_btn.Name = "reset_timer_btn";
            this.reset_timer_btn.Size = new System.Drawing.Size(174, 54);
            this.reset_timer_btn.TabIndex = 3;
            this.reset_timer_btn.Text = "RESET";
            this.reset_timer_btn.UseVisualStyleBackColor = true;
            this.reset_timer_btn.Click += new System.EventHandler(this.reset_timer_btn_Click);
            // 
            // back_main_btn
            // 
            this.back_main_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_main_btn.FlatAppearance.BorderSize = 3;
            this.back_main_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_main_btn.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_main_btn.ForeColor = System.Drawing.Color.White;
            this.back_main_btn.Location = new System.Drawing.Point(17, 28);
            this.back_main_btn.Name = "back_main_btn";
            this.back_main_btn.Size = new System.Drawing.Size(113, 28);
            this.back_main_btn.TabIndex = 3;
            this.back_main_btn.Text = "<- Main Menu";
            this.back_main_btn.UseVisualStyleBackColor = true;
            this.back_main_btn.Click += new System.EventHandler(this.main_menu);
            // 
            // Resume_btn
            // 
            this.Resume_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resume_btn.FlatAppearance.BorderSize = 3;
            this.Resume_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resume_btn.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resume_btn.ForeColor = System.Drawing.Color.White;
            this.Resume_btn.Location = new System.Drawing.Point(126, 316);
            this.Resume_btn.Name = "Resume_btn";
            this.Resume_btn.Size = new System.Drawing.Size(174, 54);
            this.Resume_btn.TabIndex = 3;
            this.Resume_btn.Text = "RESUME";
            this.Resume_btn.UseVisualStyleBackColor = true;
            this.Resume_btn.Click += new System.EventHandler(this.resume_timer_btn_Click);
            // 
            // POMODORO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(401, 557);
            this.Controls.Add(this.timer_txbx);
            this.Controls.Add(this.reset_timer_btn);
            this.Controls.Add(this.stop_timer_btn);
            this.Controls.Add(this.back_main_btn);
            this.Controls.Add(this.Resume_btn);
            this.Controls.Add(this.start_timer_btn);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.title2_lbl);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POMODORO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POMODORO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.POMODORO_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label title2_lbl;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.Button start_timer_btn;
        private System.Windows.Forms.TextBox timer_txbx;
        private System.Windows.Forms.Button stop_timer_btn;
        private System.Windows.Forms.Button reset_timer_btn;
        private System.Windows.Forms.Button back_main_btn;
        private System.Windows.Forms.Button Resume_btn;
    }
}

