using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNameGeneratorLibrary;
using static NPCGEN.Enums;

namespace NPCGEN
{
    class RandomNPC
    {
        Random rand = new Random();
        DataWriterReader dwr;
        SkillContainer skills;
        AdvantageContainer advantages;
        AdvantageContainer disadvantages;
        PointDistribution pointDistribution;
        NPC npc;

        private class PointDistribution
        {
            public int SkillPoints { get; set; }
            public int AttributePoints { get; set; }
            public int AdvantagePoints { get; set; }
            
            public PointDistribution()
            {
                SkillPoints = 0;
                AttributePoints = 0;
                AdvantagePoints = 0;
            }

            public PointDistribution(int skill, int attribute, int advantage)
            {
                SkillPoints = skill;
                AttributePoints = attribute;
                AdvantagePoints = advantage;
            }
            public static PointDistribution operator +(PointDistribution p1, PointDistribution p2)
            {
                return new PointDistribution(p1.SkillPoints + p2.SkillPoints, p1.AttributePoints + p2.AttributePoints, p1.AdvantagePoints + p2.AdvantagePoints);
            }

            public override string ToString()
            {
                return SkillPoints + " " + AttributePoints + " " + AdvantagePoints;
            }
        }

        public RandomNPC()
        {
            dwr = new DataWriterReader();
            skills = dwr.GetSkillContainer();
            advantages = dwr.GetAdvantageContainer();
            disadvantages = dwr.GetDisadvantageContainer();
        }

        public NPC GetRandomNPC(int points, int tl, bool exotic, bool supernatural)
        {
            
            PersonNameGenerator generator = new PersonNameGenerator();
            int disadPoints = GetDisadPoints(points);
            int totalPoints = disadPoints + points;
            int age = rand.Next(14, 81);
            pointDistribution = DistributePoints(totalPoints);
            string name = generator.GenerateRandomFirstName();

            npc = new NPC(name, age, tl);
            AddSkills();
            AddAdvantages(exotic, supernatural);
            AddAttributes();
            AddDisadvantages(disadPoints, exotic, supernatural);
            return npc;
        }

        private void AddDisadvantages(int disadPoints, bool exotic, bool supernatural)
        {
            if(npc != null)
            {
                int points = disadPoints;
                int failCount = 0;
                List<Advantage> a = new List<Advantage>();
                while(points > 0)
                {
                    try
                    {
                        Advantage newAdvantage = GetNewDisadvantage(a);

                        if ((newAdvantage.Type.Equals(AdvantageType.Exotic) && !exotic) || (newAdvantage.Type.Equals(AdvantageType.Supernatural) && !supernatural))
                        {
                            continue;
                        }

                        
                        
                        if((points + newAdvantage.Points) > 0)
                        {
                            failCount = 0;
                            points += newAdvantage.Points;
                            npc.AddAdvantage(newAdvantage);
                            a.Add(newAdvantage);
                        }
                        else
                        {
                            failCount++;
                            if (failCount == 3)
                                break;
                        }
                    }
                    catch(KeyNotFoundException)
                    {

                    }
                }
            }
        }

        private Advantage GetNewDisadvantage(List<Advantage> a)
        {
            Array enumValues = Enum.GetValues(typeof(AdvantageCategory));
            AdvantageCategory advantageCategory = (AdvantageCategory)Enum.Parse(typeof(AdvantageCategory), rand.Next(enumValues.Length-1).ToString());
            try
            {
                List<Advantage> advantageList = disadvantages.GetAdvantages(advantageCategory);
                
                Advantage newDisadvantage = advantageList[rand.Next(0, advantageList.Count)];

                int count = 0;
                while (a.Contains(newDisadvantage))
                {
                    newDisadvantage = advantageList[rand.Next(0, advantageList.Count)];
                    count++;
                    if (count == disadvantages.Size)
                        break;
                }

                return newDisadvantage;
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException();
            }
        }

        private void AddAttributes()
        {
            int points = pointDistribution.AttributePoints;
            Array enumValues = Enum.GetValues(typeof(AttributeNames));
            
            while (points > 0)
            {
                AttributeNames attributeName = (AttributeNames)Enum.Parse(typeof(AttributeNames), rand.Next(enumValues.Length).ToString());
                points -= npc.GetAttribute(attributeName).Scale;
                if(points > 0)
                {
                    npc.SetAttribute(attributeName, IncreaseAttributeLevel(attributeName));
                }
            }
        }

        private int IncreaseAttributeLevel(AttributeNames attributeName)
        {
            return npc.GetAttribute(attributeName).Scale + npc.GetAttribute(attributeName).Points;
        }

        private void AddAdvantages(bool exotic, bool supernatural)
        {
            if(npc != null)
            {
                int points = pointDistribution.AdvantagePoints;
                int failCount = 0;
                List<Advantage> a = new List<Advantage>();
                while (points > 0)
                {
                    try
                    {
                        
                        Advantage newAdvantage = GetNewAdvantage(a);
                        
                        if((newAdvantage.Type.Equals(AdvantageType.Exotic) && !exotic) || (newAdvantage.Type.Equals(AdvantageType.Supernatural) && !supernatural))
                        {
                            continue;
                        }

                        
                        if ((points - newAdvantage.Points) > 0)
                        {
                            failCount = 0;
                            points -= newAdvantage.Points;
                            npc.AddAdvantage(newAdvantage);
                            a.Add(newAdvantage);
                        }
                        else
                        {
                            failCount++;
                            if (failCount == 3)
                            {
                                break;
                            }
                        }

                    }
                    catch (KeyNotFoundException)
                    {

                    }
                    catch (NullReferenceException)
                    {
                        break;
                    }

                }
            }
        }

        private Advantage GetNewAdvantage(List<Advantage> a) 
        {
            Array enumValues = Enum.GetValues(typeof(AdvantageCategory));
            AdvantageCategory advantageCategory = (AdvantageCategory)Enum.Parse(typeof(AdvantageCategory), rand.Next(enumValues.Length).ToString());
            try
            {
                List<Advantage> advantageList = advantages.GetAdvantages(advantageCategory);

                Advantage newAdvantage = advantageList[rand.Next(0, advantageList.Count)];

                int count = 0;
                while (a.Contains(newAdvantage))
                {
                    newAdvantage = advantageList[rand.Next(0, advantageList.Count)];
                    count++;

                    if (count == (advantages.Size * 10))
                    {
                        throw new NullReferenceException();
                    }

                }

                return newAdvantage;
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException();
            }
        }

        private void AddSkills()
        {
            if(npc != null)
            {
                int points = pointDistribution.SkillPoints;
                List<Skill> s = new List<Skill>();
                while (points > 0)
                {

                    try
                    {
                        Skill newSKill = GetNewSkill(s);
                        int skillPoints = NumberOfSkillPoints();
                        newSKill.Points = skillPoints;
                        points -= skillPoints;
                        if (points > 0)
                        {
                            newSKill.Npc = npc;
                            if (!(newSKill.TechLevel > npc.TechLevel))
                            {
                                npc.AddSkill(newSKill);
                                s.Add(newSKill);
                            }
                        }
                     
                    }
                    catch (KeyNotFoundException)
                    {

                    }
                    catch (Exception)
                    {
                        

                    }
                    
                    
                }
            }
        }

        private Skill GetNewSkill(List<Skill> s)
        {
            Array enumValues = Enum.GetValues(typeof(AttributeNames));
            AttributeNames attributeName = (AttributeNames)Enum.Parse(typeof(AttributeNames), rand.Next(enumValues.Length).ToString());
            try
            {
                List<Skill> skillList = skills.GetSkills(attributeName);

                if(skillList.Count == 0)
                {
                    throw new Exception("No skills of type");
                }
                Skill newSkill = skillList[rand.Next(0, skillList.Count)];

                int count = 0;
                while (s.Contains(newSkill))
                {
                    newSkill = skillList[rand.Next(0, skillList.Count)];
                    count++;
                    if (count == skills.Size)
                        break;

                }
                    

                return newSkill;
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException();
            }
            
        }

        private int NumberOfSkillPoints()
        {
            bool shouldStop = false;
            int skillPoints = 1;
            int successPercent = 0;
            int n = 0;

            while (!shouldStop)
            {
                successPercent += (int)(GetGeometricProbabilityOfX(0.35, n) * 100);
                int randNext = rand.Next(0, 101);
                if (randNext < successPercent)
                    shouldStop = true;

                if (n < 4)
                    skillPoints = (int)Math.Pow(2, n);
                else
                    skillPoints = 8 + (4 * n);

                n++;
            }

            return skillPoints;
            
        }

        private int GetDisadPoints(int totalPoints)
        {
            const int distributionSize = 50;
            const int bounds = 10;
            double average = totalPoints / 4;
            List<int> pointDistribution = new List<int>();

            //generates nomral probability density graph based on the normal density funciton f(x) = 1/sqrt(2PI) * e^-(x^2)/2
            for (int i = 0; i < distributionSize; i++)
            {
                int x = rand.Next((int)average-bounds, (int)average + bounds + 1);

                double probabilityOfX = GetNormalProbabilityOfX(x, average);

                for(int j = 0; j < (probabilityOfX * 10); j++)
                    pointDistribution.Add(x);
            }

            // uses generated normal probability density graph to make the uniform results of Random.next() to be normal
            int disadsPointsInt = pointDistribution[rand.Next(0, pointDistribution.Count)];

            //disads only come in intervals of 5 must round to 5
            disadsPointsInt = (int)(Math.Round(disadsPointsInt / 5.0) * 5);
            return disadsPointsInt;
        }
        
        private double GetNormalProbabilityOfX(int x, double average)
        {
            return (((1) / Math.Sqrt(8 * Math.PI)) * (Math.Pow(Math.E, -Math.Pow((x - average), 2) / 8)));
        }

        private double GetGeometricProbabilityOfX(double successPercent, int n)
        {
            return successPercent * Math.Pow(1 - successPercent, n - 1);
        }

        private PointDistribution DistributePoints(int totalPoints)
        {
            PointDistribution pointDistribution = new PointDistribution();
            int remainingPoints = totalPoints;

            pointDistribution.SkillPoints = GetSkillPoints(remainingPoints);
            remainingPoints -= pointDistribution.SkillPoints;

            if (remainingPoints == 0)
            {
                pointDistribution.AdvantagePoints = 0;
                pointDistribution.AttributePoints = 0;
                return pointDistribution;
            }

            pointDistribution.AttributePoints = GetAttributePoints(remainingPoints);
            remainingPoints -= pointDistribution.AttributePoints;

            if (remainingPoints == 0)
            {
                pointDistribution.AdvantagePoints = 0;
                return pointDistribution;
            }

            pointDistribution.AdvantagePoints = GetAdvantagePoints(remainingPoints);
            remainingPoints -= pointDistribution.AdvantagePoints;

            return pointDistribution + DistributePoints(remainingPoints);
        }

        private int GetSkillPoints(int totalPoints)
        {
            bool shouldStop = false;
            int skillPoints = 0;
            int successPercent = 0;
            int n = 0;
            while (!shouldStop)
            {
                successPercent += (int)(GetGeometricProbabilityOfX(0.04, n) * 100);
                int randNext = rand.Next(0, 101);
                if ( randNext < successPercent)
                    shouldStop = true;

                skillPoints++;
                n++;
            }

            if (skillPoints > totalPoints)
                return totalPoints;

            return skillPoints;
        }

        private int GetAttributePoints(int totalPoints)
        {
            double probabilityOfSuccess = rand.Next(1, 11) / 100.0;
            bool shouldStop = false;
            int attributePoints = GetBaseAttributePoints(totalPoints);
            int successPercent = 0;
            int n = 0;

            while (!shouldStop)
            {
                successPercent += (int)(GetGeometricProbabilityOfX(probabilityOfSuccess, n) * 100); 
                int randNext = rand.Next(0, 101);
                if (randNext < successPercent)
                    shouldStop = true;

                attributePoints+=5;
                n++;
            }

            while (attributePoints > totalPoints)
            {
                attributePoints -= 5;
            }


            return attributePoints;
        }
        
        private int GetBaseAttributePoints(int totalPoints)
        {
            int attributePoints = totalPoints / 4;
            attributePoints /= 2;
            attributePoints = (int)Math.Round(attributePoints / 5.0) * 5;

            return attributePoints;
        }

        private int GetAdvantagePoints(int totalPoints)
        {
            double probabilityOfSuccess = rand.Next(5, 31) / 100.0;
            bool shouldStop = false;
            int advantagePoints = 5;
            int successPercent = 0;
            int n = 0;

            while (!shouldStop)
            {
                successPercent += (int)(GetGeometricProbabilityOfX(probabilityOfSuccess, n) * 100);
                int randNext = rand.Next(0, 101);
                if (randNext < successPercent)
                    shouldStop = true;

                advantagePoints += 5;
                n++;
            }

            while (advantagePoints > totalPoints)
            {
                advantagePoints -= 5;
            }

            return advantagePoints;
        }
    }
}
