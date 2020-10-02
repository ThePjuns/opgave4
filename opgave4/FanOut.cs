﻿using System;

namespace opgave4
{
    public class FanOut
    {
        public int Id { get; set; }
        private string _name;
        private double _temp;
        private double _fugt;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 2)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Not Valid");
                }
            }
        }

        public double Temp
        {
            get { return _temp; }
            set
            {
                if (value < 15)
                {
                    throw new System.ArgumentException("Temp er for lav");
                }
                else if (value > 25)
                {
                    throw new System.ArgumentException("Temp er for høj");
                }
                else
                {
                    _temp = value;
                }
            }
        }

        public double Fugt
        {
            get { return _fugt; }
            set
            {
                if (value < 30)
                {
                    throw new System.ArgumentException("For lidt fugt");
                }
                else if (value > 80)
                {
                    throw new System.ArgumentException("For meget fugt");
                }
                else
                {
                    _fugt = value;
                }
            }
        }

        public FanOut()
        {

        }

        public FanOut(int id, string name, double temp, double fugt)
        {
            Id = id;
            Name = name;
            Temp = temp;
            Fugt = fugt;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Temp: {Temp}, Fugt: {Fugt}";
        }
    }
}

