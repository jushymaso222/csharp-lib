using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DND_Info
{
    public partial class AddChar : Form
    {
        public AddChar()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void advOptions_Click(object sender, EventArgs e)
        {
            if (advanced.Visible)
            {
                advanced.Visible = false;
            }
            else
            {
                advanced.Visible = true;
            }
        }

        private void mouseHover(object sender, EventArgs e)
        {
            advOptions.ForeColor = Color.Aqua;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            advOptions.ForeColor = Color.White;
        }

        private void advOptions_MouseEnter(object sender, EventArgs e)
        {
            advOptions.ForeColor = Color.Aqua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool readyToAdd = true;
            string errorTxt = "";
            TextBox[] inputs = [textName, textDexterity, textCharisma, textConstitution, textStrength, textHp, textIntelligence, textWisdom];
            ComboBox[] inputs2 = [textArmor, textRace, textClass, textSize];
            if (inputs[0].Text.Length < 1)
            {
                readyToAdd = false;
                inputs[0].PlaceholderText = "*Required Field";
                errorTxt += "name ";
            }

            for (int i = 1; i < inputs.Length; i++)
            {
                if (inputs[i].Text.Length < 1 || !ValidationLibrary.IsANumber(inputs[i].Text))
                {
                    readyToAdd = false;
                    inputs[i].Text = "*0";
                    errorTxt += inputs[i].Name + " ";
                }
            }

            for (int i = 0; i < inputs2.Length; i++)
            {
                if (inputs2[i].Text.Length < 1)
                {
                    readyToAdd = false;
                    inputs2[i].Text = "";
                    errorTxt += inputs2[i].Name + " ";
                }
            }

            if (!sexM.Checked && !sexF.Checked && !sexN.Checked)
            {
                readyToAdd = false;
                errorTxt += "radio ";
            }

            if (readyToAdd)
            {
                Character temp = new Character();
                temp.Strength = textStrength.Text;
                temp.Dexterity = textDexterity.Text;
                temp.Constitution = textConstitution.Text;
                temp.Charisma = textCharisma.Text;
                temp.Wisdom = textWisdom.Text;
                temp.Intelligence = textIntelligence.Text;
                temp.Race = textRace.Text;
                temp.Pclass = textClass.Text;
                temp.Name = textName.Text;
                temp.Size = textSize.Text;
                temp.Armor = textArmor.Text;
                temp.HP = textHp.Text;

                if (sexM.Checked)
                {
                    temp.Sex = "M";
                } else if (sexF.Checked)
                {
                    temp.Sex = "F";
                } else if (sexN.Checked)
                {
                    temp.Sex = "N";
                }

                if (advanced.Visible)
                {
                    if (textSubrace.Text.Length > 0)
                    {
                        temp.Subrace = textSubrace.Text;
                    }
                    if (textSubclass.Text.Length > 0)
                    {
                        temp.Subclass = textSubclass.Text;
                    }
                    if (textCreature.Text.Length > 0)
                    {
                        temp.Creature = textCreature.Text;
                    }
                    if (textSkills.Text.Length > 0)
                    {
                        temp.Skills = textSkills.Text;
                    }
                    if (textProficiencies.Text.Length > 0)
                    {
                        temp.Proficiency = textProficiencies.Text;
                    }
                    if (textLanguage.Text.Length > 0)
                    {
                        temp.Language = textLanguage.Text;
                    }
                }

                MessageBox.Show(temp.AddRecord());
                this.Close();
            } else
            {
                MessageBox.Show("All fields need to filled in." + errorTxt);
            }

        }
    }
}
