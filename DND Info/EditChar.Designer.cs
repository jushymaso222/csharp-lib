namespace DND_Info
{
    partial class EditChar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label20 = new Label();
            textArmor = new ComboBox();
            textHp = new TextBox();
            label18 = new Label();
            label19 = new Label();
            textSize = new ComboBox();
            advanced = new Panel();
            textLanguage = new RichTextBox();
            textProficiencies = new RichTextBox();
            textSkills = new RichTextBox();
            label17 = new Label();
            label15 = new Label();
            label16 = new Label();
            textCreature = new ComboBox();
            label14 = new Label();
            textSubclass = new TextBox();
            label13 = new Label();
            textSubrace = new TextBox();
            label12 = new Label();
            label11 = new Label();
            textClass = new ComboBox();
            label10 = new Label();
            textRace = new ComboBox();
            sexN = new RadioButton();
            sexM = new RadioButton();
            sexF = new RadioButton();
            label9 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            textIntelligence = new TextBox();
            label7 = new Label();
            textWisdom = new TextBox();
            label6 = new Label();
            textCharisma = new TextBox();
            label5 = new Label();
            textConstitution = new TextBox();
            label4 = new Label();
            textDexterity = new TextBox();
            label3 = new Label();
            textStrength = new TextBox();
            label2 = new Label();
            textName = new TextBox();
            label1 = new Label();
            deleteButton = new Button();
            advanced.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(675, 400);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 40;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = SystemColors.ControlDarkDark;
            label20.ForeColor = SystemColors.Control;
            label20.Location = new Point(150, 403);
            label20.Name = "label20";
            label20.Size = new Size(63, 25);
            label20.TabIndex = 39;
            label20.Text = "Armor";
            // 
            // textArmor
            // 
            textArmor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textArmor.BackColor = SystemColors.ControlLight;
            textArmor.DropDownStyle = ComboBoxStyle.DropDownList;
            textArmor.FormattingEnabled = true;
            textArmor.Items.AddRange(new object[] { "Light", "Medium", "Heavy" });
            textArmor.Location = new Point(234, 399);
            textArmor.Name = "textArmor";
            textArmor.Size = new Size(132, 33);
            textArmor.TabIndex = 38;
            // 
            // textHp
            // 
            textHp.BackColor = SystemColors.ControlLight;
            textHp.BorderStyle = BorderStyle.FixedSingle;
            textHp.Location = new Point(52, 400);
            textHp.Name = "textHp";
            textHp.Size = new Size(86, 31);
            textHp.TabIndex = 37;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.ControlDarkDark;
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(496, 136);
            label18.Name = "label18";
            label18.Size = new Size(43, 25);
            label18.TabIndex = 35;
            label18.Text = "Size";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(11, 400);
            label19.Name = "label19";
            label19.Size = new Size(35, 25);
            label19.TabIndex = 36;
            label19.Text = "HP";
            // 
            // textSize
            // 
            textSize.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textSize.BackColor = SystemColors.ControlLight;
            textSize.DropDownStyle = ComboBoxStyle.DropDownList;
            textSize.FormattingEnabled = true;
            textSize.Items.AddRange(new object[] { "Tiny", "Small", "Medium", "Large", "Huge", "Gargantuan" });
            textSize.Location = new Point(551, 133);
            textSize.Name = "textSize";
            textSize.Size = new Size(239, 33);
            textSize.TabIndex = 34;
            // 
            // advanced
            // 
            advanced.BackColor = SystemColors.ControlDark;
            advanced.Controls.Add(textLanguage);
            advanced.Controls.Add(textProficiencies);
            advanced.Controls.Add(textSkills);
            advanced.Controls.Add(label17);
            advanced.Controls.Add(label15);
            advanced.Controls.Add(label16);
            advanced.Controls.Add(textCreature);
            advanced.Controls.Add(label14);
            advanced.Controls.Add(textSubclass);
            advanced.Controls.Add(label13);
            advanced.Controls.Add(textSubrace);
            advanced.Controls.Add(label12);
            advanced.Location = new Point(14, 223);
            advanced.Name = "advanced";
            advanced.Size = new Size(776, 156);
            advanced.TabIndex = 33;
            // 
            // textLanguage
            // 
            textLanguage.Location = new Point(451, 100);
            textLanguage.Name = "textLanguage";
            textLanguage.Size = new Size(308, 32);
            textLanguage.TabIndex = 21;
            textLanguage.Text = "";
            // 
            // textProficiencies
            // 
            textProficiencies.Location = new Point(451, 62);
            textProficiencies.Name = "textProficiencies";
            textProficiencies.Size = new Size(308, 32);
            textProficiencies.TabIndex = 20;
            textProficiencies.Text = "";
            // 
            // textSkills
            // 
            textSkills.Location = new Point(451, 22);
            textSkills.Name = "textSkills";
            textSkills.Size = new Size(308, 32);
            textSkills.TabIndex = 19;
            textSkills.Text = "";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(324, 99);
            label17.Name = "label17";
            label17.Size = new Size(97, 25);
            label17.TabIndex = 18;
            label17.Text = "Languages";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(324, 62);
            label15.Name = "label15";
            label15.Size = new Size(109, 25);
            label15.TabIndex = 17;
            label15.Text = "Proficiencies";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.Control;
            label16.Location = new Point(324, 25);
            label16.Name = "label16";
            label16.Size = new Size(51, 25);
            label16.TabIndex = 16;
            label16.Text = "Skills";
            // 
            // textCreature
            // 
            textCreature.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textCreature.BackColor = SystemColors.ControlLight;
            textCreature.DropDownStyle = ComboBoxStyle.DropDownList;
            textCreature.FormattingEnabled = true;
            textCreature.Items.AddRange(new object[] { "Aberration", "Beast", "Celestial", "Construct", "Dragon", "Elemental", "Fey", "Fiend", "Giant", "Humanoid", "Monstrosity", "Ooze", "Plant", "Undead" });
            textCreature.Location = new Point(84, 96);
            textCreature.Name = "textCreature";
            textCreature.Size = new Size(225, 33);
            textCreature.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(3, 99);
            label14.Name = "label14";
            label14.Size = new Size(78, 25);
            label14.TabIndex = 15;
            label14.Text = "Creature";
            // 
            // textSubclass
            // 
            textSubclass.Location = new Point(84, 59);
            textSubclass.Name = "textSubclass";
            textSubclass.Size = new Size(225, 31);
            textSubclass.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(3, 62);
            label13.Name = "label13";
            label13.Size = new Size(80, 25);
            label13.TabIndex = 13;
            label13.Text = "Subclass";
            // 
            // textSubrace
            // 
            textSubrace.Location = new Point(84, 22);
            textSubrace.Name = "textSubrace";
            textSubrace.Size = new Size(225, 31);
            textSubrace.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(3, 25);
            label12.Name = "label12";
            label12.Size = new Size(75, 25);
            label12.TabIndex = 0;
            label12.Text = "Subrace";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ControlDarkDark;
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(496, 97);
            label11.Name = "label11";
            label11.Size = new Size(52, 25);
            label11.TabIndex = 32;
            label11.Text = "Class";
            // 
            // textClass
            // 
            textClass.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textClass.BackColor = SystemColors.ControlLight;
            textClass.DropDownStyle = ComboBoxStyle.DropDownList;
            textClass.FormattingEnabled = true;
            textClass.Items.AddRange(new object[] { "Artificer", "Barbarian", "Bard", "Blood Hunter", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorceror", "Warlock", "Wizard" });
            textClass.Location = new Point(551, 94);
            textClass.Name = "textClass";
            textClass.Size = new Size(239, 33);
            textClass.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlDarkDark;
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(496, 55);
            label10.Name = "label10";
            label10.Size = new Size(49, 25);
            label10.TabIndex = 30;
            label10.Text = "Race";
            // 
            // textRace
            // 
            textRace.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textRace.BackColor = SystemColors.ControlLight;
            textRace.DropDownStyle = ComboBoxStyle.DropDownList;
            textRace.FormattingEnabled = true;
            textRace.Items.AddRange(new object[] { "Aarakocra", "Aasimar", "Air Genesai", "Astral Elf", "Autognome", "Bugbear", "Centaur", "Changeling", "Deep Gnome", "Dragonborn", "Duergar", "Dwarf", "Earth Genesai", "Eladrin", "Elf", "Fairy", "Feral Tiefling", "Firbolg", "Fire Genesai", "Giff", "Githyanki", "Githzerai", "Gnome", "Goblin", "Goliath", "Grung", "Hadozee", "Half-Elf", "Half-Orc", "Halfling", "Harengon", "Hobgoblin", "Human", "Kalashtar", "Kenku", "Kobold", "Leonin", "Lizardfolk", "Loxodon", "Minotaur", "Orc", "Owlin", "Plasmoid", "Satyr", "Sea Elf", "Shadar-Kai", "Shifter", "Simic Hybrid", "Tabaxi", "Thri-Kreen", "Tiefling", "Tortle", "Triton", "Vedalken", "Verdan", "Warforged", "Water Genesai", "Yuan-Ti" });
            textRace.Location = new Point(551, 52);
            textRace.Name = "textRace";
            textRace.Size = new Size(239, 33);
            textRace.TabIndex = 29;
            // 
            // sexN
            // 
            sexN.AutoSize = true;
            sexN.ForeColor = SystemColors.Control;
            sexN.Location = new Point(662, 17);
            sexN.Name = "sexN";
            sexN.Size = new Size(50, 29);
            sexN.TabIndex = 28;
            sexN.TabStop = true;
            sexN.Text = "N";
            sexN.UseVisualStyleBackColor = true;
            // 
            // sexM
            // 
            sexM.AutoSize = true;
            sexM.ForeColor = SystemColors.Control;
            sexM.Location = new Point(610, 17);
            sexM.Name = "sexM";
            sexM.Size = new Size(53, 29);
            sexM.TabIndex = 27;
            sexM.TabStop = true;
            sexM.Text = "M";
            sexM.UseVisualStyleBackColor = true;
            // 
            // sexF
            // 
            sexF.AutoSize = true;
            sexF.ForeColor = SystemColors.Control;
            sexF.Location = new Point(558, 17);
            sexF.Name = "sexF";
            sexF.Size = new Size(46, 29);
            sexF.TabIndex = 26;
            sexF.TabStop = true;
            sexF.Text = "F";
            sexF.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ControlDarkDark;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(497, 19);
            label9.Name = "label9";
            label9.Size = new Size(39, 25);
            label9.TabIndex = 25;
            label9.Text = "Sex";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textIntelligence);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textWisdom);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textCharisma);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textConstitution);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textDexterity);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textStrength);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 163);
            panel1.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(204, 10);
            label8.Name = "label8";
            label8.Size = new Size(39, 25);
            label8.TabIndex = 15;
            label8.Text = "ASI";
            // 
            // textIntelligence
            // 
            textIntelligence.BackColor = SystemColors.ControlLight;
            textIntelligence.BorderStyle = BorderStyle.FixedSingle;
            textIntelligence.Location = new Point(350, 112);
            textIntelligence.Name = "textIntelligence";
            textIntelligence.Size = new Size(86, 31);
            textIntelligence.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(230, 114);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 13;
            label7.Text = "Intelligence";
            // 
            // textWisdom
            // 
            textWisdom.BackColor = SystemColors.ControlLight;
            textWisdom.BorderStyle = BorderStyle.FixedSingle;
            textWisdom.Location = new Point(350, 75);
            textWisdom.Name = "textWisdom";
            textWisdom.Size = new Size(86, 31);
            textWisdom.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(230, 77);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 11;
            label6.Text = "Wisdom";
            // 
            // textCharisma
            // 
            textCharisma.BackColor = SystemColors.ControlLight;
            textCharisma.BorderStyle = BorderStyle.FixedSingle;
            textCharisma.Location = new Point(350, 38);
            textCharisma.Name = "textCharisma";
            textCharisma.Size = new Size(86, 31);
            textCharisma.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(230, 40);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 9;
            label5.Text = "Charisma";
            // 
            // textConstitution
            // 
            textConstitution.BackColor = SystemColors.ControlLight;
            textConstitution.BorderStyle = BorderStyle.FixedSingle;
            textConstitution.Location = new Point(123, 112);
            textConstitution.Name = "textConstitution";
            textConstitution.Size = new Size(86, 31);
            textConstitution.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(3, 114);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 7;
            label4.Text = "Constitution";
            // 
            // textDexterity
            // 
            textDexterity.BackColor = SystemColors.ControlLight;
            textDexterity.BorderStyle = BorderStyle.FixedSingle;
            textDexterity.Location = new Point(123, 75);
            textDexterity.Name = "textDexterity";
            textDexterity.Size = new Size(86, 31);
            textDexterity.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(3, 77);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 5;
            label3.Text = "Dexterity";
            // 
            // textStrength
            // 
            textStrength.BackColor = SystemColors.ControlLight;
            textStrength.BorderStyle = BorderStyle.FixedSingle;
            textStrength.Location = new Point(123, 38);
            textStrength.Name = "textStrength";
            textStrength.Size = new Size(86, 31);
            textStrength.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 3;
            label2.Text = "Strength";
            // 
            // textName
            // 
            textName.BackColor = SystemColors.ControlLight;
            textName.BorderStyle = BorderStyle.FixedSingle;
            textName.Location = new Point(93, 17);
            textName.MaxLength = 60;
            textName.Name = "textName";
            textName.Size = new Size(383, 31);
            textName.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 22;
            label1.Text = "Name";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ForeColor = SystemColors.Control;
            deleteButton.Location = new Point(551, 400);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(112, 34);
            deleteButton.TabIndex = 41;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // EditChar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(button1);
            Controls.Add(label20);
            Controls.Add(textArmor);
            Controls.Add(textHp);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(textSize);
            Controls.Add(advanced);
            Controls.Add(label11);
            Controls.Add(textClass);
            Controls.Add(label10);
            Controls.Add(textRace);
            Controls.Add(sexN);
            Controls.Add(sexM);
            Controls.Add(sexF);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(textName);
            Controls.Add(label1);
            Name = "EditChar";
            Text = "EditChar";
            advanced.ResumeLayout(false);
            advanced.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label20;
        private ComboBox textArmor;
        private TextBox textHp;
        private Label label18;
        private Label label19;
        private ComboBox textSize;
        private Panel advanced;
        private RichTextBox textLanguage;
        private RichTextBox textProficiencies;
        private RichTextBox textSkills;
        private Label label17;
        private Label label15;
        private Label label16;
        private ComboBox textCreature;
        private Label label14;
        private TextBox textSubclass;
        private Label label13;
        private TextBox textSubrace;
        private Label label12;
        private Label label11;
        private ComboBox textClass;
        private Label label10;
        private ComboBox textRace;
        private RadioButton sexN;
        private RadioButton sexM;
        private RadioButton sexF;
        private Label label9;
        private Panel panel1;
        private Label label8;
        private TextBox textIntelligence;
        private Label label7;
        private TextBox textWisdom;
        private Label label6;
        private TextBox textCharisma;
        private Label label5;
        private TextBox textConstitution;
        private Label label4;
        private TextBox textDexterity;
        private Label label3;
        private TextBox textStrength;
        private Label label2;
        private TextBox textName;
        private Label label1;
        private Button deleteButton;
    }
}