using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGEN
{
    class Attributes
    {
        public class Attribute
        {
            private int valueA = 10;
            private int defualt = 10;
            public String Name { get; }
            public int ValueA
            {
                get { return valueA; }
                set
                {
                    valueA = value;
                    
                    _points = (valueA - defualt) * _scale;
                }
            }

            private int _scale;
            private int _points;


            public Attribute(String n, int pS)
            {
                Name = n;
                _scale = pS;
                defualt = 10;
                valueA = defualt;
            }

            public override string ToString()
            {
                String output = Name + " " + ValueA + " " + _scale;
                return output;
            }
        }

        public enum MainAttributeNames { ST, DX, IQ, HT };
        public enum SecondaryAttributeNames { HP, WILL, PER, FP };
        public enum PointScale { TWO = 2, THREE = 3, FIVE = 5, TEN = 10, TWENTY = 20 };

        private PointScale pS;
        private Attribute[] mainAttributes = { new Attribute("ST", (int)PointScale.TEN), new Attribute("DX", (int)PointScale.TWENTY), new Attribute("IQ", (int)PointScale.TWENTY), new Attribute("HT", (int)PointScale.TEN) };
        private Attribute[] secondaryAttributes = { new Attribute("HP", (int)PointScale.TWO), new Attribute("WILL", (int)PointScale.FIVE), new Attribute("PER", (int)PointScale.FIVE), new Attribute("FP", (int)PointScale.THREE) };


        public Enum getPointScale()
        {
            return pS;
        }

        public Attribute GetST() { return mainAttributes[(int)MainAttributeNames.ST]; }
        public Attribute getDX() { return mainAttributes[(int)MainAttributeNames.DX]; }
        public Attribute getIQ() { return mainAttributes[(int)MainAttributeNames.IQ]; }
        public Attribute getHT() { return mainAttributes[(int)MainAttributeNames.HT]; }
        public Attribute getHP() { return secondaryAttributes[(int)SecondaryAttributeNames.HP]; }
        public Attribute getWILL() { return secondaryAttributes[(int)SecondaryAttributeNames.WILL]; }
        public Attribute getPER() { return secondaryAttributes[(int)SecondaryAttributeNames.PER]; }
        public Attribute getFP() { return secondaryAttributes[(int)SecondaryAttributeNames.FP]; }

        public void setST(int v)
        {
            mainAttributes[(int)MainAttributeNames.ST].ValueA = v;
            setHP(secondaryAttributes[(int)SecondaryAttributeNames.HP].ValueA + (v - 10));
        }

        public void setDX(int v)
        {
            mainAttributes[(int)MainAttributeNames.DX].ValueA = v;
        }

        public void setIQ(int v)
        {
            mainAttributes[(int)MainAttributeNames.IQ].ValueA = v;
            setWILL(secondaryAttributes[(int)SecondaryAttributeNames.WILL].ValueA + (v - 10));
            setPER(secondaryAttributes[(int)SecondaryAttributeNames.PER].ValueA + (v - 10));
        }

        public void setHT(int v)
        {
            mainAttributes[(int)MainAttributeNames.ST].ValueA = v;
            setFP(secondaryAttributes[(int)SecondaryAttributeNames.FP].ValueA + (v - 10));
        }

        public void setHP(int v)
        {
            secondaryAttributes[(int)SecondaryAttributeNames.HP].ValueA = v;

        }

        public void setWILL(int v)
        {
            secondaryAttributes[(int)SecondaryAttributeNames.WILL].ValueA = v;

        }

        public void setPER(int v)
        {
            secondaryAttributes[(int)SecondaryAttributeNames.PER].ValueA = v;

        }

        public void setFP(int v)
        {
            secondaryAttributes[(int)SecondaryAttributeNames.FP].ValueA = v;

        }

        public override string ToString()
        {
            String output = "";
            foreach(Attribute in )
        }
    }
}

