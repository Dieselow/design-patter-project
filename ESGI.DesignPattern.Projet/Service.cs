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
            var emptyTripList = new List<Trip>();
            var loggedUser = _session.GetLoggedUser();
            try
            {
                if (loggedUser == null) throw new UserNotLoggedInException();
                
                foreach (var friend in user.GetFriends())
                {
                    if (friend.Equals(loggedUser)) return _dao.FindTripsByUser(user);
                }
            }catch(Exception exception)
            {
                Console.Write(exception.Message);
            }

            return emptyTripList;
        }
    }
}