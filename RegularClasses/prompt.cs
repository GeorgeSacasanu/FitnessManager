using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularClasses
{
    public static class prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            bool returned = false;
            Form prompt = new Form();
            prompt.Width = 400;
            prompt.Height = 170;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            textLabel.AutoSize = true;
            TextBox input = new TextBox() { Left = 50, Top = 50, Width = 300 };
            Button confirmation = new Button() { Text = "OK", Left = 250, Width = 100, Top = 90 };
            confirmation.Click += (sender, e) => 
            {
                if(Regex.IsMatch(input.Text, @"^[0-9a-zA-Z ':-]+$") == false)
                {
                    MessageBox.Show("Only letters, space and hyphen characters are allowed!");
                }
                else
                {
                    prompt.Close();
                    returned = true;
                }
                
            };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(input);
            prompt.ShowDialog();
            if(returned)
            {
                return (String)input.Text;
            }
            return null;  
        }
    }
}
