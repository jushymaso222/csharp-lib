namespace DND_Info
{
    partial class ChooseID
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
            label1 = new Label();
            dataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(231, 35);
            label1.Name = "label1";
            label1.Size = new Size(326, 25);
            label1.TabIndex = 1;
            label1.Text = "Select the character you wish to update:";
            label1.Click += label1_Click;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(12, 86);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 62;
            dataGrid.ShowEditingIcon = false;
            dataGrid.Size = new Size(776, 282);
            dataGrid.TabIndex = 2;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            dataGrid.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // ChooseID
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 380);
            Controls.Add(dataGrid);
            Controls.Add(label1);
            Name = "ChooseID";
            Text = "ChooseID";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGrid;
    }
}