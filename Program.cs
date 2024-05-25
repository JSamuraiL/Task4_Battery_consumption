// See https://aka.ms/new-console-template for more information

using Task4;

try 
{
    var BatteryList = new BatteryList 
    {
        new Battery {type = "AA", сapacity = 200},
        new Battery {type = "AAA", сapacity = 300},
        new Battery {type = "AAA", сapacity = 100},
        new Battery {type = "AA", сapacity = 500},
        new Battery {type = "AAA", сapacity = 400},
    };

    foreach (Battery battery in BatteryList ) 
    {
        if ( battery.type == null) { throw new ArgumentNullException(nameof(battery.type)); };
        if ( (battery.type != "AA") && (  battery.type != "AAA")){ throw new ArgumentException(nameof(battery.type)); } 
    }

    BatteryList.SortBatteries();
}

catch { }
