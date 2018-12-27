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
        public AttributeNames SkillType { get; set; }

        private Difficulty Diff { get; set; }
        public String Name { get; }
        public int SkillLevel { get { UpdateSkillLevel(); return _skillLevel; } private set { _skillLevel = value; } }
        public int Points { get; set; }
        public int TechLevel { get; set; }
        public NPC Npc { get; set; }

        public Skill(String name, Difficulty diff, AttributeNames type, int tech)
        {
            Name = name;
            Diff = diff;
            SkillType = type;
            TechLevel = tech;
            Points = 0;
        }

        public Skill(String name, Difficulty diff, AttributeNames type, int tech, int points)
        {
            Name = name;
            Diff = diff;
            SkillType = type;
            TechLevel = tech;
            Points = points;
            
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
                SkillLevel = Npc.GetAttribute(SkillType).Level - 5;
            }
            else if(Points <= 8)
            {
                SkillLevel = (int)(Math.Log(Points) / Math.Log(2)) + Npc.GetAttribute(SkillType).Level + diffMod;
            }
            else
            {
                SkillLevel = (((Points + 8) / 4) - 1) + Npc.GetAttribute(SkillType).Level + diffMod;
            }
        }

        public override string ToString()
        {
            return Name + " " + Diff + " " + Points + " " + SkillLevel;

        }

    }
}
