namespace DND_Info
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            createChar = new Button();
            editChar = new Button();
            searchChar = new Button();
            rollDie = new Button();
            SuspendLayout();
            // 
            // createChar
            // 
            createChar.BackColor = SystemColors.ControlDark;
            createChar.FlatStyle = FlatStyle.Flat;
            createChar.Location = new Point(178, 43);
            createChar.Name = "createChar";
            createChar.Size = new Size(201, 84);
            createChar.TabIndex = 0;
            createChar.Text = "Create New Character";
            createChar.UseVisualStyleBackColor = false;
            createChar.Click += createChar_Click_1;
            // 
            // editChar
            // 
            editChar.BackColor = SystemColors.ControlDark;
            editChar.FlatStyle = FlatStyle.Flat;
            editChar.Location = new Point(178, 164);
            editChar.Name = "editChar";
            editChar.Size = new Size(201, 84);
            editChar.TabIndex = 1;
            editChar.Text = "Edit Character";
            editChar.UseVisualStyleBackColor = false;
            editChar.Click += editChar_Click_1;
            // 
            // searchChar
            // 
            searchChar.BackColor = SystemColors.ControlDark;
            searchChar.FlatStyle = FlatStyle.Flat;
            searchChar.Location = new Point(178, 291);
            searchChar.Name = "searchChar";
            searchChar.Size = new Size(201, 84);
            searchChar.TabIndex = 2;
            searchChar.Text = "Search Characters";
            searchChar.UseVisualStyleBackColor = false;
            searchChar.Click += searchChar_Click;
            // 
            // rollDie
            // 
            rollDie.BackColor = SystemColors.ControlDark;
            rollDie.FlatStyle = FlatStyle.Flat;
            rollDie.Location = new Point(178, 419);
            rollDie.Name = "rollDie";
            rollDie.Size = new Size(201, 84);
            rollDie.TabIndex = 3;
            rollDie.Text = "Roll Dice";
            rollDie.UseVisualStyleBackColor = false;
            rollDie.Click += rollDie_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(563, 553);
            Controls.Add(rollDie);
            Controls.Add(searchChar);
            Controls.Add(editChar);
            Controls.Add(createChar);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button createChar;
        private Button editChar;
        private Button searchChar;
        private Button rollDie;
    }
}
