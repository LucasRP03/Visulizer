using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstVisualizer
{
    public partial class Form1 : Form
    {
        int[] TheArray;
        Graphics g;
        BackgroundWorker bgw = null;
        bool Paused = false;

        public Form1()
        {
            InitializeComponent();
            PopulateDropdown();
        }

        private void PopulateDropdown()
        {


        }

        private void ExitToolStripMenuItem_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            int NumEntries = panel1.width;
            int MaxVal = panel1.Height;

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
