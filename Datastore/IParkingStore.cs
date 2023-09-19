using ParkeringService.Models;

namespace ParkeringService.Datastore
{
    public interface IParkingStore
    {
        Parking GetParkingList(string numberplate);
        void Save(Parking parking);
    }
}
