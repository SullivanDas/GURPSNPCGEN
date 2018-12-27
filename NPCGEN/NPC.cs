using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NPCGEN.Enums;

namespace NPCGEN
{
    class NPC
    {
        
        private Attribute[] attributes = new Attribute[8];
        private List<Skill> skills = new List<Skill>();
        private List<Advantage> advantages = new List<Advantage>();
        public String Name { get; }
        public int Age { get; }
        public int Points { get; private set; }
        public int TechLevel { get; private set; }

        public NPC(String n, int a, int t)
        {
            Name = n;
            Age = a;
            InitializeAttributes();
            TechLevel = t;
        }

        private void InitializeAttributes()
        {
            
            attributes[(int)AttributeNames.DX] = new Attribute("DX", PointScale.Twenty, 0);
            attributes[(int)AttributeNames.HP] = new Attribute("HP", PointScale.Two, 0);
            attributes[(int)AttributeNames.WILL] = new Attribute("WILL", PointScale.Five, 0);
            attributes[(int)AttributeNames.PER] = new Attribute("PER", PointScale.Five, 0);
            attributes[(int)AttributeNames.FP] = new Attribute("FP", PointScale.Three, 0);
            attributes[(int)AttributeNames.ST] = new ParentAttribute("ST", PointScale.Ten, 0, attributes[(int)AttributeNames.HP]);
            attributes[(int)AttributeNames.HT] = new ParentAttribute("HT", PointScale.Ten, 0, attributes[(int)AttributeNames.FP]);
            attributes[(int)AttributeNames.IQ] = new ParentAttribute("IQ", PointScale.Twenty, 0, attributes[(int)AttributeNames.PER], attributes[(int)AttributeNames.WILL]);

        }

        public void AddSkill(Skill s)
        {
            Points += s.Points;
            skills.Add(s);
        }
        public void AddAdvantage(Advantage a)
        {
            Points += a.Points;
            advantages.Add(a);
        }
        public void SetAttribute(AttributeNames aN, int points)
        {
            Points += points;
            attributes[(int)aN].Points = points;
        }
        public Attribute[] GetAttributes()
        {
            return attributes;
        }
        public Attribute GetAttribute(AttributeNames aN)
        {
            return attributes[(int)aN];
        }
        public List<Skill> GetSkills()
        {
            return skills;
        }
        public List<Advantage> GetAdvantages()
        {
            return advantages;
        }

        public override string ToString()
        {
            String output = "";
            foreach(Attribute a in attributes)
            {
                output += a;
                output += " ";
            }
            foreach(Skill s in skills)
            {
                output += s;
                output += " ";
            }
            foreach(Advantage a in advantages)
            {
                output += a;
                output += " ";
            }

            return output + " " + Name + " " + Age + " " + TechLevel + " " + Points;
        }
    }
}
