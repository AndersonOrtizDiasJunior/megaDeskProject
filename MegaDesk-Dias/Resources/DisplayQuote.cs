using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Dias.Resources
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();
            showQuote(quote);
        }


        private void showQuote(DeskQuote quote)
        {
            nameInput.Text = quote.customerName;
            widthInput.Text = quote.desk.width.ToString();
            depthInput.Text = quote.desk.depth.ToString();
            drawerInput.Text = quote.desk.numberOfDrawers.ToString();
            materialInput.Text = quote.desk.surfaceMaterial.ToString();
            rushInput.Text = quote.rushOrder.ToString();
            dateInput.Text = quote.date.ToString();
            quoteInput.Text = $"${quote.quote},00";
        }
    }
}
