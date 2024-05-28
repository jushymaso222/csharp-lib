using System.CodeDom.Compiler;

namespace DND_Info
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void createChar_Click(object sender, EventArgs e)
        {
            AddChar temp = new AddChar();
            temp.Show();
        }

        private void editChar_Click(object sender, EventArgs e)
        {
            ChooseID choose = new ChooseID();
            choose.Show();
        }

        private void editChar_Click_1(object sender, EventArgs e)
        {
            ChooseID choose = new ChooseID();
            choose.Show();
        }

        private void searchChar_Click(object sender, EventArgs e)
        {
            SearchHandler search = new SearchHandler();
            search.Show();
        }

        private void createChar_Click_1(object sender, EventArgs e)
        {
            AddChar temp = new AddChar();
            temp.Show();
        }

        private void rollDie_Click(object sender, EventArgs e)
        {
            rollDice die = new rollDice();
            die.Show();
        }
    }
}
