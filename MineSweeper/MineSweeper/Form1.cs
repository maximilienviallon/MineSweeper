using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        private Button btnAdd = new Button();
        public Form1()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(btnAdd);
            this.btnAdd.Location = new System.Drawing.Point(90, 25);

            this.btnAdd.BackColor = Color.Gray;
            this.btnAdd.Text = "Add";
            this.btnAdd.Size = new System.Drawing.Size(50, 25);
        }
    }
}
