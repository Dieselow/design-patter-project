using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class Service
    {
        /*public List<Trip> GetTripsByUser(User user)
        {
            List<Trip> tripList = new List<Trip>();
            User loggedUser = UserSession.GetInstance().GetLoggedUser();
            bool isFriend = false;
            if (loggedUser != null)
            {
                foreach (User friend in user.GetFriends())
                {
                    if (friend.Equals(loggedUser))
                    {
                        isFriend = true;
                        break;
                    }
                }
                if (isFriend)
                {
                    tripList = DAO.FindTripsByUser(user);
                }
                return tripList;
            }
            else
            {
                throw new UserNotLoggedInException();
            }
        }*/

        public List<Trip> GetTripsByUser(User user)
        {
            return user.GetTrips();
        }

        public List<Trip> GetUserFriendsTrips(User user)
        {
            var result = new List<Trip>();
            var friends = user.GetFriends();
            friends.ForEach(friend => { friend.GetTrips().ForEach(trip => { result.Add(trip); }); });
            return result;
        }
    }
}