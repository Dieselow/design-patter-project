using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class DAO
    {
        public static List<Trip> FindTripsByUser(User user)
        {
            throw new DependendClassCallDuringUnitTestException(
                        "TripDAO should not be invoked on an unit test.");
        }
    }
}
