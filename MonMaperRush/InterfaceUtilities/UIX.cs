using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Utilities;

namespace MonMaperRush.InterfaceUtilities
{
    internal static class UIX
    {
        internal enum DisplayInteraction
        {
            Information = 0,
            Question = 1,
            Confirmation = 2,
            Critical = 3,
            Exclamation
        }

        internal static DialogResult Alert(string message, DisplayInteraction interaction, string title = "MonMaper", string error = "")
        {
            if (string.IsNullOrEmpty(title))
                title = "MonMaper";

            switch (interaction)
            {
                case DisplayInteraction.Exclamation:
                    return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                case DisplayInteraction.Question:
                    return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                case DisplayInteraction.Confirmation:
                    return MessageBox.Show(message, title, MessageBoxButtons.OKCancel,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                case DisplayInteraction.Information:
                    return MessageBox.Show(message, title, MessageBoxButtons.OK,MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                case DisplayInteraction.Critical:
                    return MessageBox.Show(message.Replace(":","") + ":" + Environment.NewLine + Environment.NewLine + error, title, MessageBoxButtons.OK,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                default:
                    return DialogResult.None;
            }
        }
        internal static string FormatMonetary(object value)
        {
            try
            {
                return GenericFunctions.Val(value).ToString("###,###,##0.00");
            }
            catch (Exception)
            {
                return "";
            }
        }

        internal static string DisplayDate(DateTime value)
        {
            return value.ToString("dd/MM/yyyy");
        }

        public static void MonetaryTextBox(object? sender, EventArgs e)
        {
            if (sender == null)
                return;

            TextBox control = (TextBox)sender;

            control.Text = FormatMonetary(control.Text);
        }

        public static void DateTextBox(object? sender, EventArgs e)
        {
            if (sender == null)
                return;

            TextBox control = (TextBox)sender;

            if (string.IsNullOrEmpty(control.Text))
                return;

            if (!GenericFunctions.IsDate(control.Text))
            {
                control.Text = "";
                Alert("Data inválida!",DisplayInteraction.Exclamation);
                return;
            }

            control.Text = DateTime.Parse(control.Text).ToString("dd/MM/yyyy");
        }
    }
}
