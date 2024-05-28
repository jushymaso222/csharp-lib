namespace DND_Info
{
    partial class rollDice
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
            numDie = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            dieType = new ComboBox();
            dieImage = new PictureBox();
            button1 = new Button();
            output = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)numDie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dieImage).BeginInit();
            SuspendLayout();
            // 
            // numDie
            // 
            numDie.Location = new Point(211, 19);
            numDie.Name = "numDie";
            numDie.Size = new Size(69, 31);
            numDie.TabIndex = 0;
            numDie.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 1;
            label1.Text = "Number of Dice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 2;
            label2.Text = "Die Type";
            // 
            // dieType
            // 
            dieType.BackColor = SystemColors.Control;
            dieType.DropDownStyle = ComboBoxStyle.DropDownList;
            dieType.FormattingEnabled = true;
            dieType.Items.AddRange(new object[] { "D4", "D6", "D8", "D10", "D12", "D20" });
            dieType.Location = new Point(98, 64);
            dieType.Name = "dieType";
            dieType.Size = new Size(182, 33);
            dieType.TabIndex = 3;
            dieType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dieImage
            // 
            dieImage.Image = Properties.Resources.x;
            dieImage.Location = new Point(35, 133);
            dieImage.Name = "dieImage";
            dieImage.Size = new Size(245, 245);
            dieImage.TabIndex = 4;
            dieImage.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(35, 402);
            button1.Name = "button1";
            button1.Size = new Size(245, 59);
            button1.TabIndex = 5;
            button1.Text = "Roll!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // output
            // 
            output.BackColor = SystemColors.Control;
            output.BorderStyle = BorderStyle.FixedSingle;
            output.Location = new Point(35, 479);
            output.Name = "output";
            output.Size = new Size(245, 116);
            output.TabIndex = 6;
            output.Text = "";
            // 
            // rollDice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(321, 607);
            Controls.Add(output);
            Controls.Add(button1);
            Controls.Add(dieImage);
            Controls.Add(dieType);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numDie);
            Name = "rollDice";
            Text = "rollDice";
            ((System.ComponentModel.ISupportInitialize)numDie).EndInit();
            ((System.ComponentModel.ISupportInitialize)dieImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numDie;
        private Label label1;
        private Label label2;
        private ComboBox dieType;
        private PictureBox dieImage;
        private Button button1;
        private RichTextBox output;
    }
}