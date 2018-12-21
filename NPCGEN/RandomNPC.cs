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

        public NPC GetRandomNPC(int points)
        {
            
            int disadPoints = GetDisadPoints(points);
            int totalPoints = disadPoints + points;
            NPC npc = new NPC("bob", 12);

            return npc;
        }
        
        private int GetDisadPoints(int totalPoints)
        {
            int distributionSize = 50;
            int bounds = 10;
            int average = totalPoints / 4;
            List<int> pointDistribution = new List<int>();

            //generates nomral probability density graph based on the normal density funciton f(x) = 1/sqrt(2PI) * e^-(x^2)/2
            for (int i = 0; i < distributionSize; i++)
            {
                int x = rand.Next((average-bounds), average + bounds + 1);

                double probabilityOfX = GetProbabilityOfX(x);

                for(int j = 0; j < (probabilityOfX * 10); j++)
                    pointDistribution.Add(x);
            }

            // uses generated normal probability density graph to make the uniform results of Random.next() to be normal
            int disadsPointsInt = pointDistribution[rand.Next(0, pointDistribution.Count)];

            //disads only come in intervals of 5 must round to 5
            disadsPointsInt = (int)(Math.Round(disadsPointsInt / 5.0) * 5);
            return disadsPointsInt;
        }
        
        private double GetProbabilityOfX(int x)
        {
            return (((1) / Math.Sqrt(8 * Math.PI)) * (Math.Pow(Math.E, -Math.Pow((x - (x / 4)), 2) / 8)));
        }


        private void DistributePoints(int totalPoints)
        {

        }

        private void GetSkills()
        {

        }
    }
}
