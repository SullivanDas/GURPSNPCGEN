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
        private int Age { get; }
        private int Points { get; }

        public NPC(String n, int a, int p)
        {
            Name = n;
            Age = a;
            Points = p;
            InitializeAttributes();
        }

        private void InitializeAttributes()
        {
            
            attributes[(int)AttributeNames.DX] = new Attribute("DX", Attribute.PointScale.Twenty, 0);
            attributes[(int)AttributeNames.HP] = new Attribute("HP", Attribute.PointScale.Two, 0);
            attributes[(int)AttributeNames.WILL] = new Attribute("WILL", Attribute.PointScale.Five, 0);
            attributes[(int)AttributeNames.PER] = new Attribute("PER", Attribute.PointScale.Five, 0);
            attributes[(int)AttributeNames.FP] = new Attribute("FP", Attribute.PointScale.Three, 0);
            attributes[(int)AttributeNames.ST] = new ParentAttribute("ST", Attribute.PointScale.Ten, 0, attributes[(int)AttributeNames.HP]);
            attributes[(int)AttributeNames.HT] = new ParentAttribute("HT", Attribute.PointScale.Ten, 0, attributes[(int)AttributeNames.FP]);
            attributes[(int)AttributeNames.IQ] = new ParentAttribute("IQ", Attribute.PointScale.Twenty, 0, attributes[(int)AttributeNames.PER], attributes[(int)AttributeNames.WILL]);

        }

        public void AddSkill(Skill s)
        {
            skills.Add(s);
        }

        public void SetAttribute(AttributeNames aN, int points)
        {
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

            return output + " " + Name + " " + Age + " " + Points;
        }
    }
}
