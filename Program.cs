// See https://aka.ms/new-console-template for more information

using Task4;

try 
{
    var BatteryList = new BatteryList 
    {
        new Battery {type = "AA", capacity = 200},
        new Battery {type = "AAA", capacity = 300},
        new Battery {type = "AAA", capacity = 100},
        new Battery {type = "AA", capacity = 500},
        new Battery {type = "AAA", capacity = 400},
    };

    foreach (Battery battery in BatteryList ) 
    {
        if ( battery.type == null) { throw new ArgumentNullException(nameof(battery.type)); };
        if ( ( battery.type != "AA") && ( battery.type != "AAA")){ throw new ArgumentOutOfRangeException(nameof(battery.type)); };
        if ( battery.capacity <= 0) { throw new ArgumentOutOfRangeException(nameof(battery.capacity)); };
    }

    BatteryList.SortBatteries();
}

catch (ArgumentNullException e) { Console.WriteLine(e.Message); }
catch (ArgumentOutOfRangeException e) { Console.WriteLine(e.Message); }
catch (Exception e) { Console.WriteLine(e.Message); }

