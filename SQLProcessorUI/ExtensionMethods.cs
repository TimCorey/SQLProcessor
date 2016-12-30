using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProcessorUI
{
    public static class ExtensionMethods
    {
        public static string NullSafeString(this object value)
        {
            string output = "";

            if (value != null)
            {
                output = value.ToString();
            }

            return output;
        }

        public static void AppendColoredText(this RichTextBox box, string text, Color color)
        {
            // Color the text
            box.SelectionColor = color;

            // Adds the text to the text box
            box.AppendText(text);
        }
    }
}
