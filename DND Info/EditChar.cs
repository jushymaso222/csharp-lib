using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND_Info
{
    public partial class EditChar : Form
    {
        public int _id;
        public Form previous;

        public EditChar()
        {
            InitializeComponent();
        }

        public EditChar(int intID, Form pre = null)
        {
            InitializeComponent();

            _id = intID;
            if (pre != null) 
            {
                previous = pre;
            }
            

            Character temp = new Character();
            SqlDataReader dr = temp.FindRecord(intID);

            while (dr.Read())
            {
                textName.Text = dr["Name"].ToString();
                textStrength.Text = dr["Strength"].ToString();
                textDexterity.Text = dr["Dexterity"].ToString();
                textConstitution.Text = dr["Constitution"].ToString();
                textCharisma.Text = dr["Charisma"].ToString();
                textWisdom.Text = dr["Wisdom"].ToString();
                textIntelligence.Text = dr["Intelligence"].ToString();
                textHp.Text = dr["HP"].ToString();
                textArmor.Text = dr["Armor"].ToString();
                textRace.Text = dr["Race"].ToString();
                textSize.Text = dr["Size"].ToString();
                textClass.Text = dr["Class"].ToString();
                textSubclass.Text = dr["Subclass"].ToString();
                textSubrace.Text = dr["Subrace"].ToString();
                textCreature.Text = dr["Creature"].ToString();
                textSkills.Text = dr["Skills"].ToString();
                textProficiencies.Text = dr["Proficiencies"].ToString();
                textLanguage.Text = dr["Language"].ToString();
                string sex = dr["Sex"].ToString();

                switch (sex)
                {
                    case "M":
                        sexM.Checked = true;
                        break;
                    case "F":
                        sexF.Checked = true;
                        break;
                    case "N":
                        sexN.Checked = true; 
                        break;
                }
            }
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
                }
                else if (sexF.Checked)
                {
                    temp.Sex = "F";
                }
                else if (sexN.Checked)
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

                MessageBox.Show(temp.UpdateRecord(_id));
                this.Close();
            }
            else
            {
                MessageBox.Show("All fields need to filled in." + errorTxt);
            }
        }

        public static DialogResult ConfirmationBox(ref string userResponse)
        {
            Form form = new Form();
            form.Text = "Confirmation Dialog";

            Label message = new Label();
            message.Text = "Are you sure you want to delete?";
            message.SetBounds(36, 36, 372, 13);
            message.AutoSize = true;

            Button buttonYes = new Button();
            buttonYes.Text = "Yes";
            buttonYes.DialogResult = DialogResult.Yes;
            buttonYes.SetBounds(150, 160, 150, 60);
            buttonYes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            Button buttonNo = new Button();
            buttonNo.Text = "No";
            buttonNo.DialogResult = DialogResult.No;
            buttonNo.SetBounds(310, 160, 150, 60);
            buttonNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { message, buttonYes, buttonNo });
            form.AcceptButton = buttonYes;

            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                userResponse = "Yes";
            }

            if (dialogResult == DialogResult.No)
            {
                userResponse = "No";
            }

            return dialogResult;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult[] results = { DialogResult.Yes, DialogResult.No };
            string userResponse = "";

            if (results.Contains(ConfirmationBox(ref userResponse)))
            {
                if (userResponse == "Yes")
                {
                    Character temp = new Character();
                    MessageBox.Show(temp.DeleteRecord(_id));

                    this.Close();
                    previous.Close();
                }
            }
        }
    }
}
