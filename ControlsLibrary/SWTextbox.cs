using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsLibrary
{
    public class SWTextbox : TextBox
    {
        public SWTextbox()
        {
            this.Enter += new System.EventHandler(this.SWTextbox_Enter);
            this.Leave += new System.EventHandler(this.SWTextbox_Leave);
            this.TextChanged += new System.EventHandler(this.SWTextbox_TextChanged);
            this.ResumeLayout(false);
        }


        public enum ContentType
        {
            Nombre,
            Text,
            CodiStarWars
        }

        public ContentType DadaPermesa { get; set; }
        public bool AllowEmpty { get; set; }
        public bool IsForeignKey { get; set; }
        public string LinkedControlName { get; set; }
        private TextBox linkedControl;


        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            ValidateContent();
        }

        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
        }

        private void SWTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LinkedControlName))
            {
                Control control = this.Parent?.Controls[LinkedControlName];
                if (control is TextBox linkedTextBox)
                {
                    linkedControl = linkedTextBox;
                    linkedTextBox.Text = this.Text;
                }
            }
        }

        private void ValidateContent()
        {
            bool isValid;

            if (string.IsNullOrEmpty(this.Text))
            {
                if (!AllowEmpty)
                {
                    this.Focus();
                }
            }
            else
            {
                if (DadaPermesa == ContentType.Nombre)
                {
                    isValid = ValidateNombre(this.Text);

                    
                }
                else if (DadaPermesa == ContentType.CodiStarWars)
                {
                    isValid = ValidateCodiStarWars(this.Text);
                }
                else
                {
                    isValid = ValidateText(this.Text);
                }

                if (isValid)
                {
                    linkedControl.Text = "CODI VALID";
                }
                else
                {
                    linkedControl.Text = "ERROR CODI";
                }
            }
            
        }

        private bool ValidateNombre(string text)
        {
            return int.TryParse(text, out _);
        }

        private bool ValidateCodiStarWars(string text)
        {
            string pattern = @"[BCDFGHJKLMNPQRSTVWXYZ]{4}-\d{3}/[13579][AEIOU]$";
            return Regex.IsMatch(text, pattern);
        }

        private bool ValidateText(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z\s]+$");

        }


    }
}
