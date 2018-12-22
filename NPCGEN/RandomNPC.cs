using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGEN
{
    class RandomNPC
    {
        Random rand = new Random();

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

        public NPC GetRandomNPC(int points)
        {
            
            int disadPoints = GetDisadPoints(points);
            int totalPoints = disadPoints + points;
            NPC npc = new NPC("bob", 12);

            return npc;
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
