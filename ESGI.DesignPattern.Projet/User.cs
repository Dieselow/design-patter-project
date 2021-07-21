using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public class User
    {
        private readonly string _name;
        private List<Trip> trips = new();
        private List<User> friends = new();

        public User(string name)
        {
            _name = name;
        }

        public List<User> GetFriends()
        {
            return friends;
        }

        public void AddFriend(User user)
        {
            friends.Add(user);
        }

        public void AddTrip(Trip trip)
        {
            trips.Add(trip);
        }

        public List<Trip> GetTrips()
        {
            return trips;
        }
    }
}
