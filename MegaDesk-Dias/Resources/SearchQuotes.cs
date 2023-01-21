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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private DeskQuote[] loadQuotes()
        {
            try
            {
                StreamReader reader = new StreamReader("data.bin");
                var lines = reader.ReadToEnd().Split('\n');
                DeskQuote[] deskQuotes = new DeskQuote[lines.Length - 1];
                for (int i = 0; i < lines.Length-1; i++)
                {
                    deskQuotes[i] = new DeskQuote(lines[i]);
                }
                reader.Close();
                return deskQuotes;
            }
            catch { return new DeskQuote[0]; }
        }

        private void fillTable(string material)
        {
            table.Rows.Clear();
            var quotes = loadQuotes();
            foreach (var quote in quotes)
            {
                if (quote.desk.surfaceMaterial.ToString() == material.ToLower())
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

        private void materialInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTable(materialInput.SelectedItem.ToString());
        }
    }
}
