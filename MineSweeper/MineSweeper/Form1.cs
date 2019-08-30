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
        //private Button btnAdd2 = new Button();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                Button gButtom = new Button();
                Controls.Add(gButtom);
                gButtom.Location = new System.Drawing.Point(90+25*i, 25);
                gButtom.Size = new System.Drawing.Size(25, 25);
                gButtom.BackColor = Color.LightGray;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int id = button1.TabIndex;
            textBox1.AppendText(Convert.ToString(id));
            
            //this.btnAdd.Text = "Add";
            //this.btnAdd.Size = new System.Drawing.Size(25, 25);
            //this.Controls.Add(btnAdd2);
            //this.btnAdd2.Location = new System.Drawing.Point(115, 25);
            //this.btnAdd2.Size = new System.Drawing.Size(25, 25);
        }
    }
}
