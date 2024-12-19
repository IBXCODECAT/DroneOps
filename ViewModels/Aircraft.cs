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
                    Name = "Drone A",
                    Manufacturer = "DJI",
                    Model = "Mavic 3",
                    SerialNumber = "SN123456",
                    USC44809Registration = "44809-001",
                    Part107Registration = "107-001",
                    BroadcastsRemoteID = true,
                    Weight = 1.2,
                    Airworthiness = AirworthinessStatus.Airworthy,
                    Notes = "No issues reported."
                },
                new Aircraft
                {
                    Name = "Drone B",
                    Manufacturer = "Parrot",
                    Model = "Anafi",
                    SerialNumber = "SN654321",
                    USC44809Registration = "44809-002",
                    Part107Registration = "107-002",
                    BroadcastsRemoteID = false,
                    Weight = 0.32,
                    Airworthiness = AirworthinessStatus.Grounded,
                    Notes = "Battery needs replacement."
                }
            };

            AddAircraftCommand = new Command(AddAircraft);
        }

        private void AddAircraft()
        {
            Aircrafts.Add(new Aircraft
            {
                Name = "New Drone",
                Manufacturer = "Unknown",
                Model = "Unknown",
                SerialNumber = "SN000000",
                USC44809Registration = "44809-XXX",
                Part107Registration = "107-XXX",
                BroadcastsRemoteID = false,
                Weight = 0.0,
                Airworthiness = AirworthinessStatus.Grounded,
                Notes = "Newly added."
            });
        }
    }

    public class Aircraft
    {
        public required string Name { get; set; }
        public required string Manufacturer { get; set; }
        public required string Model { get; set; }
        public required string SerialNumber { get; set; }
        public required string USC44809Registration { get; set; }
        public required string Part107Registration { get; set; }
        public bool BroadcastsRemoteID { get; set; }
        public double Weight { get; set; } // in kilograms
        public AirworthinessStatus Airworthiness { get; set; }
        public required string Notes { get; set; }
    }

    public enum AirworthinessStatus
    {
        Airworthy,
        Grounded
    }
}
