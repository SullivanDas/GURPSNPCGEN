using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NPCGEN.Enums;

namespace NPCGEN
{
    class AdvantageContainer
    {
        private List<Advantage> physicalAdvantages = new List<Advantage>();
        private List<Advantage> mentalAdvantages = new List<Advantage>();
        private List<Advantage> socialAdvantages = new List<Advantage>();

        private Dictionary<AdvantageCategory, List<Advantage>> advantageDict = new Dictionary<AdvantageCategory, List<Advantage>>();

        public int Size {
            get
            {
                return physicalAdvantages.Count + mentalAdvantages.Count + socialAdvantages.Count;
            }
        }

        public AdvantageContainer()
        {
            advantageDict.Add(AdvantageCategory.Mental, mentalAdvantages);
            advantageDict.Add(AdvantageCategory.Physical, physicalAdvantages);
            advantageDict.Add(AdvantageCategory.Social, socialAdvantages);
        }

        public void AddAdvantage(AdvantageCategory aC, Advantage advantage)
        {
            try
            {
                advantageDict[aC].Add(advantage);

            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key not found");

            }
        }

        public Advantage GetAdvantage(AdvantageCategory aC, int listPos)
        {
            if (advantageDict.TryGetValue(aC, out List<Advantage> advantageList))
            {
                return advantageList[listPos];
            }
            else
            {
                Console.WriteLine("Key not found");
            }
            return null;
        }

        public List<Advantage>GetAdvantages(AdvantageCategory aC)
        {
            if (advantageDict.TryGetValue(aC, out List<Advantage> advantageList))
            {
                return advantageList;
            }
            else
                throw new KeyNotFoundException();
        }

        public override string ToString()
        {
            String output = "";
            foreach(KeyValuePair<AdvantageCategory, List<Advantage>> k in advantageDict)
            {
                foreach (Advantage a in k.Value)
                {
                    output += a;
                    output += " ";
                }
            }
            return output;
        }
    }
}
