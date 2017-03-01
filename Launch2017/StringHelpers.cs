using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launch2017
{
    public class StringHelpers
    {
        public string Depluralize(string value)
        {
            string retval = value;

            if (value.EndsWith("ies"))
            {
                retval = value.Substring(0, value.Length - 3) + 'y';
            }
            else if (value.EndsWith("es"))
            {
                retval = value.Substring(0, value.Length - 1);
            }
            else if (value.EndsWith("s"))
            {
                retval = value.Substring(0, value.Length - 1);
            }
            return retval.ToLowerInvariant();
        }

        public string Pluralize(string value)
        {
            string retval = value;

            if (value.EndsWith("y"))
            {
                retval = value.Substring(0, value.Length - 1) + "ies";
            }
            else if (value.EndsWith("s"))
            {
                retval = value + "es";
            }
            else
            {
                retval = value + "s";
            }
            return retval;
        }
    }    
}
