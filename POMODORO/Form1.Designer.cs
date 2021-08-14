
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
            this.pick_color = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Button();
            this.color3 = new System.Windows.Forms.Button();
            this.color4 = new System.Windows.Forms.Button();
            this.color5 = new System.Windows.Forms.Button();
            this.color6 = new System.Windows.Forms.Button();
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
            this.start_timer_btn.Location = new System.Drawing.Point(126, 302);
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
            this.stop_timer_btn.Location = new System.Drawing.Point(126, 367);
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
            this.back_main_btn.Size = new System.Drawing.Size(128, 28);
            this.back_main_btn.TabIndex = 3;
            this.back_main_btn.Text = "<- Main Menu";
            this.back_main_btn.UseVisualStyleBackColor = true;
            this.back_main_btn.Click += new System.EventHandler(this.main_menu);
            // 
            // pick_color
            // 
            this.pick_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pick_color.FlatAppearance.BorderSize = 3;
            this.pick_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pick_color.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pick_color.ForeColor = System.Drawing.Color.White;
            this.pick_color.Location = new System.Drawing.Point(17, 62);
            this.pick_color.Name = "pick_color";
            this.pick_color.Size = new System.Drawing.Size(128, 28);
            this.pick_color.TabIndex = 3;
            this.pick_color.Text = "Pick a color ->";
            this.pick_color.UseVisualStyleBackColor = true;
            this.pick_color.Click += new System.EventHandler(this.pick_color_click);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.RosyBrown;
            this.color1.FlatAppearance.BorderSize = 3;
            this.color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color1.ForeColor = System.Drawing.Color.White;
            this.color1.Location = new System.Drawing.Point(151, 62);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(27, 28);
            this.color1.TabIndex = 5;
            this.color1.UseVisualStyleBackColor = false;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.DimGray;
            this.color2.FlatAppearance.BorderSize = 3;
            this.color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.color2.Location = new System.Drawing.Point(184, 62);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(27, 28);
            this.color2.TabIndex = 5;
            this.color2.UseVisualStyleBackColor = false;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // color3
            // 
            this.color3.BackColor = System.Drawing.Color.Maroon;
            this.color3.FlatAppearance.BorderSize = 3;
            this.color3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.color3.Location = new System.Drawing.Point(217, 62);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(27, 28);
            this.color3.TabIndex = 5;
            this.color3.UseVisualStyleBackColor = false;
            this.color3.Click += new System.EventHandler(this.color3_Click);
            // 
            // color4
            // 
            this.color4.BackColor = System.Drawing.Color.SandyBrown;
            this.color4.FlatAppearance.BorderSize = 3;
            this.color4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.color4.Location = new System.Drawing.Point(250, 62);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(27, 28);
            this.color4.TabIndex = 5;
            this.color4.UseVisualStyleBackColor = false;
            this.color4.Click += new System.EventHandler(this.color4_Click);
            // 
            // color5
            // 
            this.color5.BackColor = System.Drawing.Color.Navy;
            this.color5.FlatAppearance.BorderSize = 3;
            this.color5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.color5.Location = new System.Drawing.Point(283, 62);
            this.color5.Name = "color5";
            this.color5.Size = new System.Drawing.Size(27, 28);
            this.color5.TabIndex = 5;
            this.color5.UseVisualStyleBackColor = false;
            this.color5.Click += new System.EventHandler(this.color5_Click);
            // 
            // color6
            // 
            this.color6.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.color6.FlatAppearance.BorderSize = 3;
            this.color6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.color6.Location = new System.Drawing.Point(316, 62);
            this.color6.Name = "color6";
            this.color6.Size = new System.Drawing.Size(27, 28);
            this.color6.TabIndex = 5;
            this.color6.UseVisualStyleBackColor = false;
            this.color6.Click += new System.EventHandler(this.color6_Click);
            // 
            // POMODORO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(401, 557);
            this.Controls.Add(this.color6);
            this.Controls.Add(this.color5);
            this.Controls.Add(this.color4);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.timer_txbx);
            this.Controls.Add(this.reset_timer_btn);
            this.Controls.Add(this.stop_timer_btn);
            this.Controls.Add(this.pick_color);
            this.Controls.Add(this.back_main_btn);
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
        private System.Windows.Forms.Button pick_color;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.Button color3;
        private System.Windows.Forms.Button color4;
        private System.Windows.Forms.Button color5;
        private System.Windows.Forms.Button color6;
    }
}

