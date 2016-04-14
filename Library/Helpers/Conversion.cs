using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itera.Fagdag.November.Helpers
{
    public static class Conversion
    {
        public static short ToInt16(this object obj)
        {
            try
            {
                var val = Convert.ToInt16(obj.ToString());
                return val;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int ToInt32(this object obj)
        {
            try
            {
                var val = Convert.ToInt32(obj.ToString());
                return val;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static long ToInt64(this object obj)
        {
            try
            {
                var val = Convert.ToInt64(obj.ToString());
                return val;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}