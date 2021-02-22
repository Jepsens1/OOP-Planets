using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Planets
{
    class Planet
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double mass;

        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }
        private double diameter;

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        private double density;

        public double Density
        {
            get { return density; }
            set { density = value; }
        }
        private double gravity;

        public double Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }
        private TimeSpan rotationPeriod;

        public TimeSpan RotationPeriod
        {
            get { return rotationPeriod; }
            set { rotationPeriod = value; }
        }

        private TimeSpan lengthofday;

        public TimeSpan LengthOfDay
        {
            get { return lengthofday; }
            set { lengthofday = value; }
        }
        private double distanceFromSun;

        public double DistanceFromSun
        {
            get { return distanceFromSun; }
            set { distanceFromSun = value; }
        }
        private TimeSpan orbitalPeriod;

        public TimeSpan OrbitalPeriod
        {
            get { return orbitalPeriod; }
            set { orbitalPeriod = value; }
        }
        private double orbitalVelocity;

        public double OrbitalVelocity
        {
            get { return orbitalVelocity; }
            set { orbitalVelocity = value; }
        }
        private double meanTemperature;

        public double MeanTemperature
        {
            get { return meanTemperature; }
            set { meanTemperature = value; }
        }
        private int numberOfMoons;

        public int NumberOfMoons
        {
            get { return numberOfMoons; }
            set { numberOfMoons = value; }
        }
        private bool ringSystem;

        public bool RingSystem
        {
            get { return ringSystem; }
            set { ringSystem = value; }
        }
        public Planet(string name,double mass, double diameter, double density,double gravity, TimeSpan rotation, TimeSpan lengthDay,double distance, TimeSpan Period, double OrbitalVelocity, double Temp, int moons, bool RSystem)
        {
            Name = name;
            Mass = mass;
            Diameter = diameter;
            Density = density;
            Gravity = gravity;
            RotationPeriod = rotation;
            LengthOfDay = lengthDay;
            DistanceFromSun = distance;
            OrbitalPeriod = Period;
            MeanTemperature = Temp;
            NumberOfMoons = moons;
            RingSystem = RSystem;
        }
        












    }
}
