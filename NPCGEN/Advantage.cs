using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGEN
{
    class Advantage
    {

        public String name { get; }
        public String description { get; }
        public int points { get; }

        public Advantage()
        {
            name = "";
            description = "";
            points = 0;
        }

        public Advantage(String n, String d, int p)
        {
            name = n;
            description = d;
            points = p;

        }

        public override string ToString()
        {
            String output = name + " " + description + " " + points;
            return output;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Advantage)) return false;

            Advantage other = (Advantage)obj;
            return name.Equals(other.name) && points == other.points;
        }

        public override int GetHashCode()
        {
            var hashCode = -323037219;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(description);
            hashCode = hashCode * -1521134295 + points.GetHashCode();
            return hashCode;
        }
    }
}
