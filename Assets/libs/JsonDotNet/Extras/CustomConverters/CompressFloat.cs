using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


   public  static class CompressFloat
    {



        public static short Encode(this double value)
        {
            int cnt = 0;
            while (value != Math.Floor(value))
            {
                value *= 10.0;
                cnt++;
            }
            return (short)((cnt << 12) + (int)value);
        }

        public static double Decode(this short value)
        {
            int cnt = value >> 12;
            double result = value & 0xfff;
            while (cnt > 0)
            {
                result /= 10.0;
                cnt--;
            }
            return result;
        }
    }

