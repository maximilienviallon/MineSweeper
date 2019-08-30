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
        //public static Button gButtom { get; set; }
        List<int> bombList = new List<int>();
        //private Button btnAdd2 = new Button();
        public Form1()
        {
            InitializeComponent();
            Button gButtom;
            Random random = new Random();
           
            for (int j = 0; j < 5; j++)
            {
                int randomNumber = random.Next(1, 26);
                bombList.Add(randomNumber);


                for (int i = 0; i < 5; i++)
                {
                    gButtom = new Button();
                    Controls.Add(gButtom);
                    gButtom.Location = new System.Drawing.Point(90 + i * 25, 25+j*25);
                    gButtom.Size = new System.Drawing.Size(25, 25);
                    gButtom.BackColor = Color.LightGray;
                    gButtom.Click += new System.EventHandler(this.Button_Click);
                }
                gButtom = new Button();
                gButtom.Location = new System.Drawing.Point(90, 25+j*25);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //int id = button1.TabIndex;
            //textBox1.AppendText(Convert.ToString(sender));

            
            //this.btnAdd.Text = "Add";
            //this.btnAdd.Size = new System.Drawing.Size(25, 25);
            //this.Controls.Add(btnAdd2);
            //this.btnAdd2.Location = new System.Drawing.Point(115, 25);
            //this.btnAdd2.Size = new System.Drawing.Size(25, 25);
        }
        
        public void Button_Click(object sender, EventArgs e)
        {
            int k = 0;
            Button btn = sender as Button;
            List<int> test = sender as List<int>;
            int id = btn.TabIndex;
            List<int> surroundList = new List<int>();
            surroundList.Add(id - 6);
            surroundList.Add(id - 5);
            surroundList.Add(id - 4);
            surroundList.Add(id - 1);
            surroundList.Add(id + 1);
            surroundList.Add(id + 4);
            surroundList.Add(id + 5);
            surroundList.Add(id + 6);
            //foreach (int item in surroundList)
            {
              //  MessageBox.Show(Convert.ToString(item));
            }
            //foreach (int item in bombList)
            {
              //  MessageBox.Show(" The lucky 5 numbers should be: "+ Convert.ToString(item));
            }
            foreach (int bomb in bombList)
            {
                if (surroundList.Contains(bomb))
                {
                    k++;
                }
            }
            btn.Text = Convert.ToString(k);
            //id = ((Button)sender).TabIndex;
            //MessageBox.Show("works");
            MessageBox.Show(Convert.ToString(btn.TabIndex));
        }
        private int Compare_To_Bomb (int bombAmount)
        {
            
            return bombAmount;
        }
    }
}
