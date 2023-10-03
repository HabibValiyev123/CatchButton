using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int MaxX = this.ClientSize.Width - button1.Width;
            int MaxY = this.ClientSize.Height - button1.Height;
            int newX = random.Next(MaxX);
            int newY = random.Next(MaxY);

            button1.Location = new Point(newX, newY);
        }
    }
}
