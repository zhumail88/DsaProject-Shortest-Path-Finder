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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            AddUnderlineToLabel(label1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Create a linear gradient brush
            LinearGradientBrush brush = new LinearGradientBrush(
                panel2.ClientRectangle,
                Color.FromArgb(117, 234, 213), 
        Color.FromArgb(167, 186, 227),      
                LinearGradientMode.Vertical);

            // Fill the panel with the gradient brush
            e.Graphics.FillRectangle(brush, panel2.ClientRectangle);
        }

        private void AddUnderlineToLabel(Label label)
        {
            // Check if the label has a Font property
            if (label.Font != null)
            {
                // Create a new Font with the Underline style
                label.Font = new Font(label.Font, FontStyle.Underline);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            // Add your code for the clear button click event if needed
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            MapPage formMenu = new MapPage();
            formMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instruction instruction = new Instruction();
            instruction.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Hide();
        }
    }
}
