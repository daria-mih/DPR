using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// SCAN (elevator) 
    /// processes numbers on the way from the smallest number to the biggest(or reverse)
    /// changing the direction at those numbers
    /// </summary>
    public class SCAN : IProcessingBehaviour
    {
        bool GoUp;
        bool deleted;
        public SCAN(bool GoUp)
        {
            this.GoUp = GoUp;
            deleted = false;
        }

        public int Run(int current, BindingList<int> pl)
        {
            List<int> l = new List<int>();
            int returnvalue;
            foreach (int x in pl)
            {
                l.Add(x);
            }
            l.Sort();

            int closestcurrent = (l.Aggregate((x, y) => Math.Abs(x - current) < Math.Abs(y - current) ? x : y));


            if (GoUp)
            {
                if (l.IndexOf(closestcurrent) > 0)
                    returnvalue = l[l.IndexOf(closestcurrent) - 1];
                else {
                    returnvalue = l[l.IndexOf(closestcurrent)];
                    if (deleted)
                    {
                        GoUp = !GoUp;
                    }
                    deleted = !deleted;
                }
            }
            else
            {
                if (l.IndexOf(closestcurrent) < l.Count - 1)
                    returnvalue = l[l.IndexOf(closestcurrent) + 1];
                else {
                    returnvalue = l[l.IndexOf(closestcurrent)];
                    if (deleted)
                    {
                        GoUp = !GoUp;
                    }
                    deleted = !deleted;
                }
            }
            return returnvalue;
        }
    }
}
