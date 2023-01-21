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
using static System.Windows.Forms.LinkLabel;

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
            try{
                StreamReader reader = new StreamReader("data.bin");
                var lines = reader.ReadToEnd().Split('\n');
                DeskQuote[] deskQuotes = new DeskQuote[lines.Length-1];
                for (int i = 0; i < lines.Length-1; i++)
                {
                    deskQuotes[i] = new DeskQuote(lines[i]);
                }
                reader.Close();
                return deskQuotes;
            } catch { return new DeskQuote[0]; }
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
                    quote.rushName(),
                    $"${quote.quote},00");
            }
        }
    }
}
