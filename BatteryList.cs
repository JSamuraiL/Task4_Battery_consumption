using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class BatteryList:List<Battery>
    {
        public void SortBatteries() 
        {
            var sortingbatteries = 
                from batteries in this
                orderby batteries.сapacity
                select batteries;
        }
    }
}
