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
    public partial class AddQuote : Form
    {   
        bool isDepthValid = false;
        public AddQuote()
        {
            InitializeComponent();
        }
        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            var isNumber = true;
            for (var i = 0;i< widthInput.Text.Length;i++) {
                isNumber = isNumber && System.Char.IsDigit(widthInput.Text, i);
            }
            if (!isNumber)
            {
                errorProvider1.SetError(widthInput, "Please insert a number");
                widthInput.Focus();
            } else if (widthInput.Text.Length == 0) {
                errorProvider1.SetError(widthInput, "Width cannot be empty");
                widthInput.Focus();
            } else if (int.Parse(widthInput.Text) < 24 || int.Parse(widthInput.Text) > 96)
            {
                errorProvider1.SetError(widthInput, "Please, insert a number between 24 and 96");
                widthInput.Focus();
            } else
            {
                errorProvider1.SetError(widthInput, "");
            }
        }

        private void depthInput_KeyUp(object sender, KeyEventArgs e)
        {
            var isNumber = true;
            var isControl = false;
            isDepthValid = false;
            for (var i = 0; i < depthInput.Text.Length; i++)
            {
                isNumber = isNumber && System.Char.IsDigit(depthInput.Text, i);
                isControl = isControl || System.Char.IsControl(depthInput.Text, i);
            }
            if (!isNumber || isControl)
            {
                errorProvider1.SetError(depthInput, "Please insert a number");
            }
            else if (depthInput.Text.Length == 0)
            {
                errorProvider1.SetError(depthInput, "Depth cannot be empty");
            }
            else if (int.Parse(depthInput.Text) < 24 || int.Parse(depthInput.Text) > 96)
            {
                errorProvider1.SetError(depthInput, "Please, insert a number between 24 and 96");
            }
            else
            {
                errorProvider1.SetError(depthInput, "");
                isDepthValid= true;
            }
        }

        private void validate()
        {
            if (nameInput.Text is null) {
                MessageBox.Show("Please, write the costumer name!");
                nameInput.Focus();
            }
            else if (!isDepthValid) {
                MessageBox.Show("Depth invalid, please check!");
                depthInput.Focus();
            }
            else if (materialInput.SelectedItem is null)
            {
                MessageBox.Show("Please, select the surface material!");
                materialInput.Focus();
            }
            else if (rushInput.SelectedItem is null)
            {
                MessageBox.Show("Please, select the production time material!");
                rushInput.Focus();
            } else
            {
                try
                {
                    int.Parse(widthInput.Text);
                    sendQuote();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please, enter a number for the width value!");
                    widthInput.Focus();
                }
            }
 
        }

        private void saveQuoteOnFile(DeskQuote quote)
        {
            var writer = new StreamWriter("data.bat", append: true);
            writer.WriteLine(quote);
            writer.Close();
            MessageBox.Show("Quote Saved!");
        }

        private void sendQuote()
        {
            
            int width = int.Parse(widthInput.Text);
            int depth = int.Parse(depthInput.Text);
            int drawers = (int)drawerInput.Value;
            DesktopMaterial material = (DesktopMaterial)materialInput.SelectedIndex;
            Desk desk = new Desk(width, depth, drawers, material);
            RushOrderType orderType = (RushOrderType)rushInput.SelectedIndex;
            var quote = new DeskQuote(desk, nameInput.Text, orderType);
            saveQuoteOnFile(quote);
            var displayQuote = new DisplayQuote(quote);
            clearForms();
            displayQuote.ShowDialog();
        }

        private void clearForms()
        {
            nameInput.Text = string.Empty;
            widthInput.Text = string.Empty;
            depthInput.Text = string.Empty;
            drawerInput.Value = 0;
            materialInput.SelectedIndex = -1;
            rushInput.SelectedIndex = -1;

        }
        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            validate();
        }
    }
}
