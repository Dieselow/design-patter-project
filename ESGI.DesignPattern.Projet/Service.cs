using System;
using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class Service
    {
        public IDao Dao;
        public IUserSession Session;

        public Service(IDao dao, IUserSession session)
        {
            Dao = dao;
            Session = session;
        }

        public List<Trip> GetTripsByUser(User user)
        {
            List<Trip> tripList = new List<Trip>();
            User loggedUser = Session.GetInstance().GetLoggedUser();
            bool isFriend = false;
            try
            {
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
                        tripList = Dao.FindTripsByUser(user);
                    }

                    return tripList;
                }
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }
            throw new UserNotLoggedInException();
        }
    }
}