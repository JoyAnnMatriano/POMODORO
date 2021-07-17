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

        int[] start_animation = { 1, 1, 1, 1};
        public POMODORO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        title_lbl.Location = new Point(title_lbl.Location.X, title_lbl.Location.Y + start_animation[i]);

                        break;
                    case 1:
                        title2_lbl.Location = new Point(title2_lbl.Location.X, title2_lbl.Location.Y + start_animation[i]);
                        break;
                    case 2:
                        start_btn.Location = new Point(start_btn.Location.X, start_btn.Location.Y + start_animation[i]);
                        break;
                    case 3:
                        quit_btn.Location = new Point(quit_btn.Location.X, quit_btn.Location.Y + start_animation[i]);
                        break;
                }
            }
        }
    }
}
