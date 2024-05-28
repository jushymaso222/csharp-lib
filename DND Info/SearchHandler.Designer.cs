namespace DND_Info
{
    partial class SearchHandler
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
            dataGrid = new DataGridView();
            textSearch = new TextBox();
            searchMode = new ComboBox();
            label1 = new Label();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(12, 213);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 62;
            dataGrid.Size = new Size(776, 225);
            dataGrid.TabIndex = 0;
            dataGrid.CellContentDoubleClick += dataGrid_CellContentDoubleClick;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(12, 135);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(394, 31);
            textSearch.TabIndex = 1;
            // 
            // searchMode
            // 
            searchMode.DropDownStyle = ComboBoxStyle.DropDownList;
            searchMode.FormattingEnabled = true;
            searchMode.Items.AddRange(new object[] { "Class", "Race", "Name", "Subclass", "Subrace" });
            searchMode.Location = new Point(224, 85);
            searchMode.Name = "searchMode";
            searchMode.Size = new Size(182, 33);
            searchMode.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(126, 88);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 3;
            label1.Text = "Search By:";
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.ActiveCaption;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Location = new Point(676, 132);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 34);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // SearchHandler
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(searchButton);
            Controls.Add(label1);
            Controls.Add(searchMode);
            Controls.Add(textSearch);
            Controls.Add(dataGrid);
            Name = "SearchHandler";
            Text = "SearchHandler";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private TextBox textSearch;
        private ComboBox searchMode;
        private Label label1;
        private Button searchButton;
    }
}