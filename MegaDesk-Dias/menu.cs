using MegaDesk_Dias.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Dias
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void quoteBtn_Click(object sender, EventArgs e)
        {
            var quoteForm = new AddQuote();
            quoteForm.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            var viewQuotes = new ViewAllQuotes();
            viewQuotes.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var searchQuotes = new SearchQuotes();
            searchQuotes.ShowDialog();
        }
    }
}
