﻿using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class UserDao : IUserDao
    {
        public List<Trip> FindTripsByUser(User user)
        {
            throw new DependendClassCallDuringUnitTestException(
                "TripDAO should not be invoked on an unit test.");
        }
    }
}
