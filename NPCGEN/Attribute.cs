using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGEN
{
    class Attribute
    {
        public enum PointScale { Two = 2, Three = 3, Five = 5, Ten = 10, Twenty = 20};
        public String Name { get; }
        public int Scale { get; }
        public int Points { get; set; }
        public int Level { get; private set; }
        
        public Attribute(String n, PointScale pS, int p)
        {
            Name = n;
            Scale = (int)pS;
            Points = p;
            UpdateLevel();
        }

        private void UpdateLevel()
        {
            int levelScale = Points / Scale;
            Level = levelScale + 10;
        }

        public override string ToString()
        {
            return Name + " " + Scale + " " + Points + " " + Level;
        }
    }
}
