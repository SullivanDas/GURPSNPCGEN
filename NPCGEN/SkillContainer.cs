using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NPCGEN.Enums;

namespace NPCGEN
{
    class SkillContainer
    {
        private List<Skill> iqSkills = new List<Skill>();
        private List<Skill> dxSkills = new List<Skill>();
        private List<Skill> stSkills = new List<Skill>();
        private List<Skill> htSkills = new List<Skill>();
        private List<Skill> perSkills = new List<Skill>();
        private List<Skill> willSkills = new List<Skill>();
        private Dictionary<int, List<Skill>> skills = new Dictionary<int, List<Skill>>();

        public SkillContainer()
        {
            skills.Add((int)AttributeNames.IQ, iqSkills);
            skills.Add((int)AttributeNames.DX, dxSkills);
            skills.Add((int)AttributeNames.ST, stSkills);
            skills.Add((int)AttributeNames.HT, htSkills);
            skills.Add((int)AttributeNames.PER, perSkills);
            skills.Add((int)AttributeNames.WILL, willSkills);
        }

        public void AddSkill(AttributeNames aN, Skill skill)
        {
            try
            {
                skills[(int)aN].Add(skill);
                
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key not found");
                
            }
        }

        public override string ToString()
        {
            String output = "";
            foreach(KeyValuePair<int, List<Skill>> k in skills)
            {
                foreach(Skill s in k.Value)
                {
                    output += s;
                    output += " ";
                }
            }
            return output;
        }
    }
}
