using Microsoft.EntityFrameworkCore;
using Vehicle_Info_APP.Data;
using Vehicle_Info_APP.Models;

namespace Vehicle_Info_APP.Repository
{
    public class VehicleRepo : IVehicle
    {
        private DataContext _DataContext;
        public VehicleRepo(DataContext VehicleDb)
        {
            _DataContext = VehicleDb;
        }
        public string DeleteVehicle(int Id)
        {
            string msg = "";
            Vehicle deleteVehicle = _DataContext.Vehicles.Find(Id);
            if (deleteVehicle != null)
            {
                _DataContext.Vehicles.Remove(deleteVehicle);
                _DataContext.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

        public List<Vehicle> GetAllVehicle()
        {
            List<Vehicle> vehicles = _DataContext.Vehicles.ToList();
            return vehicles;
        }

        public Vehicle GetVehicle(int Id)
        {
            Vehicle vehicle = _DataContext.Vehicles.Find(Id);
            return vehicle;
        }

        public string SaveVehicle(Vehicle vehicle)
        {
            _DataContext.Vehicles.Add(vehicle);
            _DataContext.SaveChanges();
            return "Saved";
        }

        public string UpdateVehicle(Vehicle vehicle)
        {
            _DataContext.Entry(vehicle).State = EntityState.Modified;
            _DataContext.SaveChanges();
            return "Updated";
        }
    }
}
