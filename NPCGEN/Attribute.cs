using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NPCGEN.Enums;

namespace NPCGEN
{
    class Attribute
    {
        
        private int _points;
        protected int _level;
        private int _baseStat;

        public String Name { get; }
        public int Scale { get; }
        
        public int Points { get { return _points; } set { _points = value; UpdateLevel(); } }
        public virtual int Level { get { return _level; } set { _level = value; } }
        public int BaseStat { get { return _baseStat; } set { _baseStat = value; UpdateLevel(); } }
        
        public Attribute(String n, PointScale pS, int p)
        {
            
            Name = n;
            Scale = (int)pS;
            Points = p;
            BaseStat = 10;
            UpdateLevel();
        }

        protected void UpdateLevel()
        {
            int levelScale = Points / Scale;
            Level = levelScale + BaseStat;
        }

        public override string ToString()
        {
            return Name + " " + Scale + " " + Points + " " + Level;
        }
    }
}
