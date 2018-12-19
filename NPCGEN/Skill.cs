using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGEN
{
    class Skill
    {
        public enum Difficulty { Easy, Average, Hard, VeryHard};
        private int skillBase;
        private Difficulty Diff { get; set; }
        public String Name { get; }
        public int SkillLevel { get; private set; }
        public int Points { get; set; }

        public Skill(String name, Enum diff)
        {
            Name = name;
            Diff = (Difficulty)diff;
            Points = 1;
            skillBase = 10;
            UpdateSkillLevel();
        }

        public Skill(String name, Enum diff, int points)
        {
            Name = name;
            Diff = (Difficulty) diff;
            Points = points;
            skillBase = 10;
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
                SkillLevel = skillBase - 5;
            }
            else if(Points <= 8)
            {
                SkillLevel = (int)(Math.Log(Points) / Math.Log(2)) + skillBase + diffMod;
            }
            else
            {
                SkillLevel = (((Points + 8) / 4) - 1) + skillBase + diffMod;
            }
        }

        public override string ToString()
        {
            return Name + " " + Diff + " " + Points + " " + skillBase + " " + SkillLevel;

        }

    }
}
