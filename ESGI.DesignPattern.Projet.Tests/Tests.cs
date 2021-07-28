using System;
using System.Collections.Generic;
using NUnit.Framework;
using Xunit;
using Assert = Xunit.Assert;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class TestUserSession : IUserSession
    {
        public User User;

        public TestUserSession(User user)
        {
            User = user;
        }

        public bool IsUserLoggedIn(User user)
        {
            return true;
        }

        public User GetLoggedUser()
        {
            return User;
        }
    }

    public class TestDao : IUserDao
    {
        public List<Trip> FindTripsByUser(User user)
        {
            return user.GetTrips();
        }
    }
    public class Tests
    {
        private Service _userService;
        private List<Trip> _trips;
        private User _user;
        private User _userFriend;

        [SetUp]
        public void Setup()
        {
            _trips = new List<Trip> {new("15 rue des picardes", DateTime.Now)};
            _user = new User("Louis");
            _userFriend = new User("Pedro");
            _userFriend.AddTrip(new Trip("74 rue nationale", DateTime.Now));
            _trips.ForEach(trip => { _user.AddTrip(trip); });
            _user.AddFriend(_userFriend);
            _user.AddFriend(_user);
            _userService = new Service(new TestDao(),new TestUserSession(_user));
        }

        [Test]
        public void userTripsShouldBeEqualToTestListOfTrips()
        {
            var result = _userService.GetTripsByUser(_user);
            Assert.Equal(result,_trips);
        }

        [Test]
        public void userTripsShouldOnlyContainOneTrip()
        {
            Assert.Single(_userService.GetTripsByUser(_user));
        }
    }
}