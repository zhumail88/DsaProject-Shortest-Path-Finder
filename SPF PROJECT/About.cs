using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMap_Tutorial
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mainform = new MainPage();

            if (mainform != null && !mainform.IsDisposed)
            {
                mainform.Show();
            }

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage mainform = new MainPage();

            if (mainform != null && !mainform.IsDisposed)
            {
                mainform.Show();
            }

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(
                panel1.ClientRectangle,
                Color.FromArgb(117, 234, 213),
        Color.FromArgb(167, 186, 227),
                LinearGradientMode.Vertical);

            // Fill the panel with the gradient brush
            e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
        }
    }
}
