using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public interface IDao
    {
        public List<Trip> FindTripsByUser(User user);
    }
}