using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DND_Info
{
    public partial class SearchHandler : Form
    {
        public SearchHandler()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Character temp = new Character();
            DataSet ds = temp.SearchLarge(searchMode.Text, textSearch.Text);

            dataGrid.DataSource = ds;
            dataGrid.DataMember = ds.Tables["Records_Temp"].ToString();
        }

        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strID = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

            MessageBox.Show(strID);
            int intID = Convert.ToInt32(strID);

            EditChar editor = new EditChar(intID, this);
            editor.Show();
        }
    }
}
