using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    {   
        //creating variables
        Stopwatch stopwatch = new Stopwatch();
        List<int> bombList = new List<int>();
        List<int> idList = new List<int>();
        int m = 0;
        
        //initializing the grid and placing mines
        public Form1()
        {
            InitializeComponent();
            Button gButtom;
            Random random = new Random();
            for (int i = 0; i < 25; i++)
            {
                idList.Add(i + 1);
            }
            for (int j = 0; j < 5; j++)
            {
                int randomNumber = random.Next(1, 26);
                while (bombList.Contains(randomNumber))
                {
                    randomNumber = random.Next(1, 26);
                }
                bombList.Add(randomNumber);


                for (int i = 0; i < 5; i++)
                {
                    gButtom = new Button();
                    Controls.Add(gButtom);
                    gButtom.Location = new System.Drawing.Point(90 + i * 25, 25 + j * 25);
                    gButtom.Size = new System.Drawing.Size(25, 25);
                    gButtom.BackColor = Color.LightGray;
                    gButtom.Click += new System.EventHandler(this.Button_Click);
                }
                gButtom = new Button();
                gButtom.Location = new System.Drawing.Point(90, 25 + j * 25);
            }

        }

        //reset button handler
        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);          
        }

        //Dynamic event handler
        public void Button_Click(object sender, EventArgs e)
        {

            int k = 0;
            Button btn = sender as Button;
            // timer for score
             if (stopwatch.ElapsedMilliseconds == 0)
            {
                stopwatch.Start();
            }
            int id = btn.TabIndex;
            if (idList.Contains(id))
            {
                idList.Remove(id);
                m++;
            }
            double idDouble = btn.TabIndex;
            //List for neighboring mines
            List<int> surroundList = new List<int>();

            //logic for finding neighboring mines (Instead of using 2D array, we used the TabIndex of each individual button)
            surroundList.Add(id - 5);
            surroundList.Add(id + 5);
            if(idDouble % 5 != 0)
            {
            surroundList.Add(id - 4);
            surroundList.Add(id + 6);
            surroundList.Add(id + 1);
            }

            // we be sorry for the empty if statement:D
            if (idDouble == 1 || idDouble == 6 || idDouble == 11 || idDouble == 16 || idDouble == 21)
            {
            }
            else
            {
                surroundList.Add(id - 6);
                surroundList.Add(id - 1);
                surroundList.Add(id + 4);
            }

            //comparing lists to define specific amount of neighboring bombs
            foreach (int bomb in bombList)
            {
                if (surroundList.Contains(bomb))
                {
                    k++;
                }
            }
            btn.Text = Convert.ToString(k);

            //Winning & losing conditions
            if (bombList.Contains(id))
            {
                MessageBox.Show("DEAD");
                
            }
            else if(m == 20)
            {
                MessageBox.Show("YOU WON in: " + Convert.ToString(stopwatch.ElapsedMilliseconds / 1000) + " seconds!");
                stopwatch.Stop();
            }
            
        }
    }
}
