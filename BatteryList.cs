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
                orderby batteries.capacity
                select batteries;

            Console.WriteLine("Батарейки по возрастанию:");
            foreach (var battery in sortingbatteries) 
            {
                Console.WriteLine($"Тип батареи: {battery.type}, ёмкость: {battery.capacity}");
            }
        }
        
    }
}
