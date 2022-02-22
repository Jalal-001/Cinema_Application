using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Chairs = 50;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Button BTN = new Button
                {
                    Name = "Btn" + i,
                    Text = (i + 1).ToString(),
                    Width = 75,
                    Height = 75,
                    BackColor = Color.Yellow,
                };
                BTN.Click += Chair_Click;//Buttonlarin click ozelliklerine "Chair_Click" metodunu elave etdik.
                flowLayoutPanel1.Controls.Add(BTN);//Buttonlarin saxlanildigi panel.
            }
        }
        private void Chair_Click(object sender, EventArgs e)//Buttonlarin Click ozellikleri.
        {
            Button BTN = (Button)sender; //"Sender" Yeni object tipi bir Buttondur.
            if (BTN.BackColor == Color.Yellow)
            {
                BTN.BackColor = Color.Green;
                listBoxBusy.Items.Add(BTN.Text);
            }
            else if (BTN.BackColor == Color.Red)
            {
                MessageBox.Show("This place has already been sold.", "Information", MessageBoxButtons.OK);
            }
            else
            {
                BTN.BackColor = Color.Yellow;
                listBoxBusy.Items.Remove(BTN.Text);
            }
            Calculate();
        }
        private void BtnClear_Click(object sender, EventArgs e)//"Clear" Buttonu.
        {
            listBoxBusy.Items.Clear();
            foreach (Button Chair in flowLayoutPanel1.Controls)//"Var" tipini "Button" olaraq teyin etdik.
            {
                if (Chair.BackColor == Color.Green)
                {
                    Chair.BackColor = Color.Yellow;
                }
            }
        }
        private void BtnBuy_Click(object sender, EventArgs e)
        {
            listBoxBusy.Items.Clear();
            foreach (Button Chair in flowLayoutPanel1.Controls)
            {
                if (Chair.BackColor == Color.Green)
                {
                    Chair.BackColor = Color.Red;
                    Chairs--;
                }
            }
            Calculate();
        }
        void Calculate()
        {
            NumericBusy.Value = listBoxBusy.Items.Count;
            NumericEmpty.Value = Chairs;
            NumericSold.Value = 50 - Chairs;
        }
    }
}

