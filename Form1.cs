using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _代码示例_进度条100自动弹出新窗体
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                Form2 f = new Form2();
                f.Show();
            }
        }
    }
}