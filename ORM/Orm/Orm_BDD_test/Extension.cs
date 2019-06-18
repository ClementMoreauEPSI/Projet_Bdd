using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm_BDD_test
{
    static class Extension
    {
        
        
            public static TimeSpan ParseTime(this string input)
            {
                var tab = input.Split(':');

                if (tab.Count() < 3)
                {
                    throw new Exception("Le format de chaine d'entrée n'est pas correct");
                }

                return new TimeSpan(0, int.Parse(tab[0]), int.Parse(tab[1]), int.Parse(tab[2]), 0);
            }

            public static string ToTimeString(this TimeSpan time)
            {
                return time.ToString(@"hh\:mm\:ss");
            }
        
    }
}
