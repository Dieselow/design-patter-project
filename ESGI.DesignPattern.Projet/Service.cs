using System;
using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class Service
    {
        private readonly IUserDao _dao;
        private readonly IUserSession _session;

        public Service(IUserDao dao, IUserSession session)
        {
            _dao = dao;
            _session = session;
        }

        public List<Trip> GetTripsByUser(User user)
        {
            List<Trip> tripList = new List<Trip>();
            User loggedUser = _session.GetInstance().GetLoggedUser();
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
                        tripList = _dao.FindTripsByUser(user);
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