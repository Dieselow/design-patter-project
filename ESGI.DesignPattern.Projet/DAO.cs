using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class UserDao : IDao
    {
        public List<Trip> FindTripsByUser(User user)
        {
            throw new DependendClassCallDuringUnitTestException(
                "TripDAO should not be invoked on an unit test.");
        }
    }
}
