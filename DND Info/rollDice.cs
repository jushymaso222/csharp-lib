using DND_Info.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND_Info
{
    public partial class rollDice : Form
    {
        public rollDice()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image resource;
            switch (dieType.Text)
            {
                case "D4":
                    resource = Resources.d4;
                    break;
                case "D6":
                    resource = Resources.d6;
                    break;
                case "D8":
                    resource = Resources.d8;
                    break;
                case "D10":
                    resource = Resources.d10;
                    break;
                case "D12":
                    resource = Resources.d12;
                    break;
                case "D20":
                    resource = Resources.d20;
                    break;
                default:
                    resource = Resources.x;
                    break;
            }
            dieImage.Image = resource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Multiplier = Convert.ToInt32(numDie.Text);
            int sides;
            Random rnd = new Random();
            output.Text = "";
            switch (dieType.Text)
            {
                case "D4":
                    sides = 4;
                    break;
                case "D6":
                    sides = 6;
                    break;
                case "D8":
                    sides = 8;
                    break;
                case "D10":
                    sides = 10;
                    break;
                case "D12":
                    sides = 12;
                    break;
                case "D20":
                    sides = 20;
                    break;
                default:
                    sides = 0;
                    break;
            }

            Double final = 0;
            string text = "";
            for (int i = 0; i < Multiplier; i++)
            {
                int roll = rnd.Next(1, sides + 1);
                final += roll;
                text += $"Roll {i+1}: {roll}\n";
            }

            MessageBox.Show("Total Dice Roll: " + final.ToString());
            output.Text = text;
            output.Text += "\nTotal Dice Roll: " + final.ToString();
        }
    }
}
