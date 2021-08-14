using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;

namespace POMODORO
{
    public partial class POMODORO : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int left,
            int top,
            int right,
            int bottom,
            int width,
            int height
            );

        System.Timers.Timer t;
        int h, m, s;

        public POMODORO()
        {
            InitializeComponent();
            start_timer_btn.Visible = false;
            timer_txbx.Visible = false;
            stop_timer_btn.Visible = false;
            reset_timer_btn.Visible = false;
            back_main_btn.Visible = false;
            pick_color.Visible = false;
            invisibleColors();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000; //1second
            t.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60) //add 1 to minute //reset seconds to zero
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60) // add 1 to hour // reset minutes to zero
                {
                    m = 0;
                    h += 1;
                }
                timer_txbx.Text = string.Format("{0}:{1}:{2}",
                                                h.ToString().PadLeft(2, '0'),
                                                m.ToString().PadLeft(2, '0'),
                                                s.ToString().PadLeft(2, '0'));
            }));
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            invisibleMain();
            visibleSecondForm();

        }

        private void start_timer_btn_Click(object sender, EventArgs e)
        {
            t.Start();
            
            if (start_timer_btn.Text == "START")
            {
                start_timer_btn.Text = "RESUME";
            }
            start_timer_btn.Text = "START";
        }

        private void POMODORO_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }

        private void stop_timer_btn_Click(object sender, EventArgs e)
        {
            t.Stop();
            start_btn.Visible = false;
        }

        private void reset_timer_btn_Click(object sender, EventArgs e)
        {
            timer_txbx.Text = "00:00:00";
            s = 0;
            m = 0;
            h = 0;
        }

        private void main_menu(object sender, EventArgs e)
        {
            visibleMain();
            invisibleSecondForm();
        }

        private void invisibleMain()
        {
            title_lbl.Visible = false;
            title2_lbl.Visible = false;

            start_btn.Visible = false;
            quit_btn.Visible = false;
        }

        private void visibleMain()
        {
            title_lbl.Visible = true;
            title2_lbl.Visible = true;
            start_btn.Visible = true;
            quit_btn.Visible = true;
        }

        private void resume_timer_btn_Click(object sender, EventArgs e)
        {
            t.Start();
            start_btn.Visible = false;
        }

        private void pick_color_click(object sender, EventArgs e)
        {
            visibleColors();
        }

        private void color1_Click(object sender, EventArgs e)
        {

        }

        private void invisibleSecondForm()
        {
            start_timer_btn.Visible = false;
            timer_txbx.Visible = false;
            stop_timer_btn.Visible = false;
            reset_timer_btn.Visible = false;
            back_main_btn.Visible = false;

            //colors pick
            pick_color.Visible = false;
            invisibleColors();
        }
        private void visibleSecondForm()
        {
            start_timer_btn.Visible = true;
            timer_txbx.Visible = true;
            stop_timer_btn.Visible = true;
            reset_timer_btn.Visible = true;
            back_main_btn.Visible = true;
            pick_color.Visible = true;
        }

        private void invisibleColors()
        {
            color1.Visible = false;
            color2.Visible = false;
            color3.Visible = false;
            color4.Visible = false;
            color5.Visible = false;
            color6.Visible = false;
            color7.Visible = false;
            color8.Visible = false;
            color8.Visible = false;
            color9.Visible = false;
            color10.Visible = false;
            color11.Visible = false;
            color12.Visible = false;
            color13.Visible = false;
            color14.Visible = false;
        }

        private void visibleColors()
        {
            color1.Visible = true;
            color2.Visible = true;
            color3.Visible = true;
            color4.Visible = true;
            color5.Visible = true;
            color6.Visible = true;
            color7.Visible = true;
            color8.Visible = true;
            color8.Visible = true;
            color9.Visible = true;
            color10.Visible = true;
            color11.Visible = true;
            color12.Visible = true;
            color13.Visible = true;
            color14.Visible = true;
        }
    }
}
