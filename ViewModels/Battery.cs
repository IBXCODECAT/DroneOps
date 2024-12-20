using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DroneOps.ViewModels;

public class BatteryListViewModel
{
    public ObservableCollection<Battery> Batteries { get; set; }
    public ICommand AddBatteryCommand { get; }
    public ICommand EditBatteryCommand { get; }
    public ICommand DeleteBatteryCommand { get; }

    public BatteryListViewModel()
    {
        Batteries = new ObservableCollection<Battery>
        {
            new Battery
            {
                Owner = "Nathan Schmitt",
                Manufacturer = "DJI",
                Model = "Mavic 3",
                SerialNumber = "1581F5YH000000000000",
                Capacity = 12,
                Cycles = 1,
                LastRecordedCharge = 12,
                LastUse = DateTime.Now,
                Airworthiness = AirworthinessStatus.Airworthy
            },
            new Battery
            {
                Owner = "Bob Builder",
                Manufacturer = "Parrot",
                Model = "Anafi",
                SerialNumber = "1581F5YHFFFFFFFFFFFF",
                Capacity = 12,
                Cycles= 43,
                LastRecordedCharge = 15,
                LastUse = DateTime.Now,
                Airworthiness = AirworthinessStatus.Grounded
            }
        };

        AddBatteryCommand = new Command(AddBattery);
        EditBatteryCommand = new Command(EditBattery);
        DeleteBatteryCommand = new Command(DeleteBattery);
    }

    private void AddBattery()
    {
        Batteries.Add(new Battery
        {
            Owner = "John Doe",
            Manufacturer = "Unkown",
            Model = "Unknown",
            SerialNumber = "1581F5YHCCCCCCCCCCCC",

            Capacity = 120,
            Cycles = 0,
            LastRecordedCharge = 100,
            LastUse = DateTime.Now,
            Airworthiness = AirworthinessStatus.Grounded
        });
    }

    private void EditBattery()
    {
        Batteries[0].Owner = "John Doe";
        Batteries[0].Manufacturer = "Unkown";
        Batteries[0].Model = "Unknown";
        Batteries[0].SerialNumber = "1581F5YHCCCCCCCCCCCC";
        Batteries[0].Capacity = 120;
        Batteries[0].Cycles = 0;
        Batteries[0].LastRecordedCharge = 100;
        Batteries[0].LastUse = DateTime.Now;
        Batteries[0].Airworthiness = AirworthinessStatus.Grounded;
    }

    private void DeleteBattery()
    {
        Batteries.RemoveAt(0);
    }
}

public class Battery
{
    public required string Owner { get; set; }
    public required string Manufacturer { get; set; }
    public required string Model { get; set; }
    public required string SerialNumber { get; set; }

    public int Capacity { get; set; }

    public int Cycles { get; set; }

    public byte LastRecordedCharge { get; set; }

    public DateTime LastUse { get; set; }

    public AirworthinessStatus Airworthiness { get; set; }

}
