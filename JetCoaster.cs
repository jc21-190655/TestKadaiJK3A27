using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_吉澤先生_
{
    public class JetCoaster

    {
        public static int ride(int k, int[] g, int r)
        
        {
            //index 要素
            //ridecount 残りの乗れる人数
            int index = 0;
            int totalcount = 0;
            
            for (int i =0;i < r; i++)

            {
                int ridecount = k;

                for (int j = 0; j < g.Length; j++)
                {
                    if (ridecount >=g[index] )
                    {
                        ridecount=ridecount-g[index];
                        index++;
                        index = index % g.Length;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                totalcount = totalcount + (k - ridecount);
            }


            return totalcount;

        }

     }
}

    
    

