using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Camp
    {
        private readonly int id;
        public int Longitude { get; set; }
        public int Latitude { get; set; }
        public int NumberOfPeople { get; set; }
        public int NumberOfTents { get; set; }
        public int NumberOfFlashlights { get; set; }
        private static int lastCampId = 0;

        public Camp(int longitude, int latitude, int numberOfPeople, int numberOfTents, int numberOfFlashlights)
        {
            Longitude = longitude;
            Latitude = latitude;
            NumberOfPeople = numberOfPeople;
            NumberOfTents = numberOfTents;
            NumberOfFlashlights = numberOfFlashlights;
            lastCampId++;
            id = lastCampId;
        }

        public override string ToString()
        {
            return $"Longitude: {Longitude}, Latitude: {Latitude}, Number of People: {NumberOfPeople}, Number of Tents: {NumberOfTents}, Number of Flashlights: {NumberOfFlashlights}";
        }

        public static bool operator ==(Camp a, Camp b)
        {
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return true;
            }
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            {
                return false;
            }
            return a.id == b.id;
        }
         
        public static bool operator !=(Camp a, Camp b)
        {
            return !(a == b);
        }

        public static bool operator >(Camp a, Camp b)
        {

            if(a.NumberOfPeople > b.NumberOfPeople)
            {
                return a > b;
            }
            return false;
        }

        public static bool operator <(Camp a, Camp b)
        {
            if(a.NumberOfPeople < b.NumberOfPeople)
            {
                return a < b;
            }
            return false;
        }

        public static Camp operator +(Camp a, Camp b)
        {
            return new Camp(a.Longitude + b.Longitude, a.Latitude + b.Latitude, a.NumberOfPeople + b.NumberOfPeople, a.NumberOfTents + b.NumberOfTents, a.NumberOfFlashlights + b.NumberOfFlashlights);
        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public override bool Equals(object obj)
        {
            var a = obj as Camp;
            return this.id == a.id;
        }
            
    }
}
