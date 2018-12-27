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
        private Dictionary<AttributeNames, List<Skill>> skillsDict = new Dictionary<AttributeNames, List<Skill>>();
        private int _size;
        public int Size
        {
            get
            {
                _size = iqSkills.Count + dxSkills.Count + stSkills.Count + htSkills.Count + perSkills.Count + willSkills.Count;
                return _size;
            }
        }

        public SkillContainer()
        {
            skillsDict.Add(AttributeNames.IQ, iqSkills);
            skillsDict.Add(AttributeNames.DX, dxSkills);
            skillsDict.Add(AttributeNames.ST, stSkills);
            skillsDict.Add(AttributeNames.HT, htSkills);
            skillsDict.Add(AttributeNames.PER, perSkills);
            skillsDict.Add(AttributeNames.WILL, willSkills);
        }

        public void AddSkill(AttributeNames aN, Skill skill)
        {
            try
            {
                skillsDict[aN].Add(skill);
                
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key not found");
                
            }
        }

        //if improper key is given null result - check
        public Skill GetSkill(AttributeNames aN, int listPos)
        {
            if(skillsDict.TryGetValue(aN, out List<Skill> skillList )){
                return skillList[listPos];
            }
            else
            {

            }
            return null;
        }

        public List<Skill> GetSkills(AttributeNames aN)
        {
            if(skillsDict.TryGetValue(aN, out List<Skill> skillList))
            {
                return skillList;
            }
            else
            {
                Console.WriteLine("Key Not Found");
                throw new KeyNotFoundException();
            }
        }

        public override string ToString()
        {
            String output = "";
            foreach(KeyValuePair<AttributeNames, List<Skill>> k in skillsDict)
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
