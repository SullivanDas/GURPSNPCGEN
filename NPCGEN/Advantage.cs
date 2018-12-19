﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGEN
{
    class Advantage
    {

        public String Name { get; }
        public String Description { get; }
        public int Points { get; }

        public Advantage()
        {
            Name = "";
            Description = "";
            Points = 0;
        }

        public Advantage(String n, String d, int p)
        {
            Name = n;
            Description = d;
            Points = p;

        }

        public override string ToString()
        {
            String output = Name + " " + Description + " " + Points;
            return output;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Advantage)) return false;

            Advantage other = (Advantage)obj;
            return Name.Equals(other.Name) && Points == other.Points;
        }

        public override int GetHashCode()
        {
            var hashCode = -323037219;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + Points.GetHashCode();
            return hashCode;
        }
    }
}