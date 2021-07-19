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

        }

        private void start_timer_btn_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void POMODORO_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }

        private void invisibleMain()
        {
            title_lbl.Visible = false;
            title2_lbl.Visible = false;

            start_btn.Visible = false;
            quit_btn.Visible = false;
        }

    }
}
