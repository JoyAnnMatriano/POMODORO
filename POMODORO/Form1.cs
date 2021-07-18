﻿using System;
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
        public POMODORO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            invisibleMain();

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
