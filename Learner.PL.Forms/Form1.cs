﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learner.PL.Forms
{
    public partial class Form1 : Form
    {
        fSetting setting;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_startLearn_Click(object sender, EventArgs e)
        {

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            setting = new fSetting();
            setting.ShowDialog();
        }
    }
}
