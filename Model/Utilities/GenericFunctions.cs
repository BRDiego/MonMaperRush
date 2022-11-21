using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Utilities
{
    public static class GenericFunctions
    {
        public static decimal Val(object value)
        {
            try
            {
                decimal result = 0;

                decimal.TryParse(value.ToString(), out result);

                return result;

            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static bool IsDate(object value)
        {
            try
            {
                DateTime result = new DateTime();

                bool success = DateTime.TryParse(value.ToString(), out result);

                return success && result.Year > 2010;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
