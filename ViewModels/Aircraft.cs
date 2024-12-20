using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DroneOps.ViewModels
{
    public class AircraftListViewModel
    {
        public ObservableCollection<Aircraft> Aircrafts { get; set; }
        public ICommand AddAircraftCommand { get; }

        public AircraftListViewModel()
        {
            Aircrafts = new ObservableCollection<Aircraft>
            {
                new Aircraft
                {
                    Owner = "Nathan Schmitt",
                    Manufacturer = "DJI",
                    Model = "Mavic 3",
                    SerialNumber = "1581F5YH000000000000",
                    Registration = "FAXXXXXX",
                    BroadcastsRemoteID = true,
                    Weight = 1.2,
                    Airworthiness = AirworthinessStatus.Airworthy
                },
                new Aircraft
                {
                    Owner = "Bob Builder",
                    Manufacturer = "Parrot",
                    Model = "Anafi",
                    SerialNumber = "1581F5YHFFFFFFFFFFFF",
                    Registration = "FAXXXXXX",
                    BroadcastsRemoteID = false,
                    Weight = 0.32,
                    Airworthiness = AirworthinessStatus.Grounded
                }
            };

            AddAircraftCommand = new Command(AddAircraft);
        }

        private void AddAircraft()
        {
            Aircrafts.Add(new Aircraft
            {
                Owner = "John Doe",
                Manufacturer = "Unkown",
                Model = "Unknown",
                SerialNumber = "1581F5YHCCCCCCCCCCCC",
                Registration = "FAXXXXXX",
                BroadcastsRemoteID = false,
                Weight = 0.0,
                Airworthiness = AirworthinessStatus.Grounded
            });
        }
    }

    public class Aircraft
    {
        public required string Owner { get; set; }
        public required string Manufacturer { get; set; }
        public required string Model { get; set; }
        public required string SerialNumber { get; set; }
        public required string Registration { get; set; }
        public bool BroadcastsRemoteID { get; set; }
        public double Weight { get; set; } // in kilograms
        public AirworthinessStatus Airworthiness { get; set; }
    }

    public enum AirworthinessStatus
    {
        Airworthy,
        Grounded
    }
}
