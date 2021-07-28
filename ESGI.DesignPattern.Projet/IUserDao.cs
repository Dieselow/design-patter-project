using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public interface IUserDao
    {
        public List<Trip> FindTripsByUser(User user);
    }
}