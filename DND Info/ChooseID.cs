using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DND_Info
{
    public partial class ChooseID : Form
    {
        public ChooseID()
        {
            InitializeComponent();

            Character temp = new Character();
            DataSet ds = temp.SearchSmall();

            dataGrid.DataSource = ds;
            dataGrid.DataMember = ds.Tables["Records_temp"].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strID = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

            int intID = Convert.ToInt32(strID);

            EditChar editor = new EditChar(intID, this);
            editor.Show();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
