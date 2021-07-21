using System;
using System.Collections.Generic;
using NUnit.Framework;
using Xunit;
using Assert = Xunit.Assert;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class Tests
    {
        private Service _userService;
        private List<Trip> _trips;
        private User _user;
        private User _userFriend;

        [SetUp]
        public void Setup()
        {
            _userService = new Service();
            _trips = new List<Trip> {new("15 rue des picardes", DateTime.Now)};
            _user = new User("Louis");
            _userFriend = new User("Pedro");
            _userFriend.AddTrip(new Trip("74 rue nationale", DateTime.Now));
            _trips.ForEach(trip => { _user.AddTrip(trip); });
            _user.AddFriend(_userFriend);
        }

        [Test]
        public void userTripsShouldBeEqualToTestListOfTrips()
        {
            var result = _userService.GetTripsByUser(_user);
            Assert.Equal(result, _trips);
        }

        [Test]
        public void userFriendsShouldContainerOnlyOneObject()
        {
            Assert.Single(_userService.GetUserFriendsTrips(_user));
        }
    }
}