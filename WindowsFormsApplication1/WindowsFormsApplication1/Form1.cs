using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа мои утилиты содержит ряд небольших программ,\n которые могут пригодиться в жизни.\n А главное - научить меня основам программирования на С#.\n Автор Маслов Константин Игоревич/n NotCopyright", "О программе");
        }
    }
}
