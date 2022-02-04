using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_吉澤先生_
{
   public class kuriage
    {
        public static int kuriage10(int i)
        {

            if (i < 0)
            {
                i = i * -1;
                if (i % 10 == 0)
                {
                    return i * -1;
                }
                else
                {
                    i = i - (i % 10) + 10;
                    return i * -1;
                }

            }
            else 
            { 
                if (i % 10 == 0)
                {
                    return i;
                }
                else
                {
                    i = i - (i % 10) + 10;
                    return i;
                }
            }
         
        }
    }
}
