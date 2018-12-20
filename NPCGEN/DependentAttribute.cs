using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NPCGEN.Enums;

namespace NPCGEN
{
    class ParentAttribute : Attribute
    {
        private Attribute child;
        private Attribute child2;

        public ParentAttribute(String n, PointScale pS, int p, Attribute c) 
            : base(n, pS, p)
        {
            child = c;
            child.BaseStat = Level;
        }

        public ParentAttribute(String n, PointScale pS, int p, Attribute c, Attribute c2)
            : base(n, pS, p)
        {
            child = c;
            child2 = c2;
            child.BaseStat = Level;
            if (child2 != null)
                child2.BaseStat = Level;
        }

        public override int Level
        {
            get => base.Level;
            set{
                _level = value;

                if (child != null)
                {
                    child.BaseStat = Level;
                }
                if (child2 != null)
                    child2.BaseStat = Level;
            }
        }

    }
}
