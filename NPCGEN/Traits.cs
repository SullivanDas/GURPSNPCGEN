using System;

namespace Traits
{
    public class Advantage{

        public String name { get { return name; } }
        public String description { get { return description; } }
        public int points { get { return points; } }


        public Advantage(String n, String d, int p)
        {
            name = n;
            description = d;
            points = p;

        }
    }
}
