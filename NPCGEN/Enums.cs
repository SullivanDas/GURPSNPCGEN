using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGEN
{
    class Enums
    {
        public enum PointScale { Two = 2, Three = 3, Five = 5, Ten = 10, Twenty = 20 };
        public enum Difficulty { Easy, Average, Hard, VeryHard };
        public enum AttributeNames { ST, DX, IQ, HT, HP, WILL, PER, FP };
        public enum AdvantageCategory { Mental, Physical, Social };
        public enum AdvantageType { Exotic, Supernatural, Mundane };

    }
}
