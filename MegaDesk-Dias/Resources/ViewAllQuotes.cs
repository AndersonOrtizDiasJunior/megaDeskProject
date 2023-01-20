using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Dias.Resources
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            fillTable();
        }
        
        private DeskQuote[] loadQuotes()
        {
            
            StreamReader reader = new StreamReader("data.bat");
            var lines = reader.ReadToEnd().Split('\n');
            DeskQuote[] deskQuotes = new DeskQuote[lines.Length];
            for (int i = 0;i < lines.Length; i++)
            {
                deskQuotes[i] = new DeskQuote(lines[i]);
            }
            reader.Close();
            return deskQuotes;
        }

        private void fillTable()
        {
            var quotes = loadQuotes();
            foreach (var quote in quotes)
            {
                table.Rows.Add(quote.date.ToString(),
                    quote.customerName,
                    quote.desk.width.ToString(),
                    quote.desk.depth.ToString(),
                    quote.desk.surfaceMaterial.ToString(),
                    quote.desk.numberOfDrawers.ToString(),
                    quote.rushOrder.ToString(),
                    quote.quote.ToString());
            }
        }
    }
}
