using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
