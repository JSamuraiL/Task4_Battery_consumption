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
                from battery in this
                where battery.type == "AA"
                orderby battery.capacity
                select battery;

            Console.WriteLine("Батарейки по возрастанию ёмкости:");
            foreach (var battery in sortingbatteries) 
            {
                Console.WriteLine($"Тип батареи: {battery.type}, ёмкость: {battery.capacity}");
            }
        }
        
    }
}
