using System;
using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class Trip
    {
        private readonly string _address;
        private readonly DateTime _tipDate;

        public Trip(string address, DateTime dateTime)
        {
            _address = address;
            _tipDate = dateTime;
        }

        public override string ToString()
        {
            return $"Address :{_address}, Date: {_tipDate}";
        }
    }
}