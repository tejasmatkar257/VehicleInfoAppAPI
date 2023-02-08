using Vehicle_Info_APP.Models;
using Vehicle_Info_APP.Repository;

namespace Vehicle_Info_APP.Services
{
    public class VehicleService
    {
        public IVehicle _VehicleRepository;

        public VehicleService(IVehicle vehicleRepository)
        {
            _VehicleRepository = vehicleRepository;
        }

        public string SaveVehicle(Vehicle vehicle)
        {
            return _VehicleRepository.SaveVehicle(vehicle);
        }

        public string DeleteVehicle(int id)
        {
            return _VehicleRepository.DeleteVehicle(id);
        }

        public string UpdateVehicle(Vehicle vehicle)
        {
            return _VehicleRepository.UpdateVehicle(vehicle);
        }

        public Vehicle GetVehicle(int id)
        {
            return _VehicleRepository.GetVehicle(id);
        }

        public List<Vehicle> GetAllVehicle()
        {
            return _VehicleRepository.GetAllVehicle();
        }
    }
}
