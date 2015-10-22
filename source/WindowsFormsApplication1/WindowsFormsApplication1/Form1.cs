using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReInitialize();
            
        }

        internal void ReInitialize()
        {
            tbDisplay.Text = "";
            tbReverse.Text = "";
            tbInput.Text = "";
            tbNoVowels.Text = "";

            cbNoVowels.Text = "No Vowels";
            cbReverse.Text = "Reverse";
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            var text = tbInput.Text;

            tbDisplay.Text = text;

            if (cbReverse.Checked == true)
                tbReverse.Text = Reverse(text);

            if (cbNoVowels.Checked == true)
                tbNoVowels.Text = noVowels(text);
        }

        private string Reverse(string text)
        {
            if (text == "")
                return "";

            var reverse = new char[text.Length];
            var counter = 0;
            for (var i = text.Length-1; i >= 0; i--)
            {
                reverse[counter++] = text[i];
            }

            return string.Join("", reverse);
        }

        private string noVowels(string text)
        {
            if (text == "")
                return "";

            var novowels = new char[text.Length];
            var lowercase = text.ToLower();
            var counter = 0;
            foreach (var letter in lowercase)
            {
                switch (letter)
                {
                    case 'a':break;
                    case 'e':break;
                    case 'i':break;
                    case 'o':break;
                    case 'u':break;
                    default:
                        novowels[counter++] = letter;
                        break;
                }
            }

            return string.Join("", novowels);
        }

        private void cbReverse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReverse.Checked)
                tbInput_TextChanged(null, new EventArgs());
            else
            {
                tbReverse.Text = "";
            }
        }

        private void cbNoVowels_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoVowels.Checked)
                tbInput_TextChanged(null, new EventArgs());
            else
            {
                tbNoVowels.Text = "";
            }
        }
    }
}
