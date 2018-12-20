using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NPCGEN.Enums;

namespace NPCGEN
{
    class Skill
    {
        
        private int _skillLevel;
        public Attribute SkillType { get; set; }

        private Difficulty Diff { get; set; }
        public String Name { get; }
        public int SkillLevel { get { UpdateSkillLevel(); return _skillLevel; } private set { _skillLevel = value; } }
        public int Points { get; set; }

        public Skill(String name, Difficulty diff, Attribute type)
        {
            Name = name;
            Diff = diff;
            SkillType = type;
            Points = 1;
            UpdateSkillLevel();
        }

        public Skill(String name, Difficulty diff, Attribute type, int points)
        {
            Name = name;
            Diff = diff;
            SkillType = type;
            Points = points;
            
            UpdateSkillLevel();
        }

        private void UpdateSkillLevel()
        {
            
            int diffMod = 0;
            switch (Diff)
            {
                case Difficulty.Easy:
                    diffMod = 0;
                    break;

                case Difficulty.Average:
                    diffMod = -1;
                    break;

                case Difficulty.Hard:
                    diffMod = -2;
                    break;

                case Difficulty.VeryHard:
                    diffMod = -3;
                    break;

            }

            // maintain the relationship skillLevel = 2^points when points is less than 8 relationship provided by gurps rules
            if(Points == 0)
            {
                SkillLevel = SkillType.Level - 5;
            }
            else if(Points <= 8)
            {
                SkillLevel = (int)(Math.Log(Points) / Math.Log(2)) + SkillType.Level + diffMod;
            }
            else
            {
                SkillLevel = (((Points + 8) / 4) - 1) + SkillType.Level + diffMod;
            }
        }

        public override string ToString()
        {
            return Name + " " + Diff + " " + Points + " " + SkillType.Level + " " + SkillLevel + " " + SkillType.Name;

        }

    }
}
