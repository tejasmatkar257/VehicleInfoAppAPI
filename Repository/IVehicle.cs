using Vehicle_Info_APP.Models;

namespace Vehicle_Info_APP.Repository
{
    public interface IVehicle
    {
        public string SaveVehicle(Vehicle vehicle);
        public string UpdateVehicle(Vehicle vehicle);
        public string DeleteVehicle(int Id);
        public Vehicle GetVehicle(int Id);
        public List<Vehicle> GetAllVehicle();
    }
}
