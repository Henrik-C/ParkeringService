using ParkeringService.Models;

namespace ParkeringService.Datastore
{
    public class ParkingStore : IParkingStore
    {
        private static readonly List<Parking> ListDatabase = new List<Parking>();


        public Parking GetParkingList(string numberplate)
        {
            return ListDatabase.FirstOrDefault(x => x.Numberplate == numberplate);
        }


        public void Save(Parking parking)
        {
            ListDatabase.Add(parking);
        }

        public void Delete(string numberplate)
        {
            ListDatabase.RemoveAll(x => x.Numberplate == numberplate);
        }
    }
}
