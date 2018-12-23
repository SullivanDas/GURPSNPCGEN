using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static NPCGEN.Enums;

namespace NPCGEN
{
    class DataWriterReader
    {
        private AdvantageContainer advantageContainer = new AdvantageContainer();
        private SkillContainer skillContainer = new SkillContainer();
        private XDocument advantages;
        private XDocument skills;

        public DataWriterReader()
        {
            Initialize();
        }

        private void Initialize()
        {
            LoadSkills("../../skills.xml");
            LoadAdvantages("../../advantages.xml");
            FillSkills();
            FillAdvantages();
        }

        private void LoadSkills(string file)
        {
            try
            {
                skills = XDocument.Load(file);
            }
            catch (FileNotFoundException)
            {
                using(XmlWriter writer = XmlWriter.Create(file))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("skills");

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Accounting");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Acrobatics");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Acting");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Administration");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Alchemy");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Animal Handling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Anthropology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Archaeology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Architecture");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Area Knowledge");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Armoury");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Artillery");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Artist");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Astronomy");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Autohypnosis");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Accounting");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Beam Weapons");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Bicycling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Bioengineering");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Biology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Blind Fighting");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Blowpipe");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Boating");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Body Control");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Body Language");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Body Sense");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Bolas");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Bow");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Boxing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Brainwashing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Brawling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Breaking Blow");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Breath Control");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Camoflage");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Carousing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Carpentry");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Cartography");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Chemistry");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Climbing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Cloak");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Computer Hacking");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Computer Operation");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Computer Programming");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Connoisseur");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Cooking");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Counterfeiting");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Crewman");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Criminology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Crossbow");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Cryptography");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Current Affairs");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Dancing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Detect Lies");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Diagnosis");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Diplomacy");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Disguise");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Dreaming");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Driving");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Dropping");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Economics");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Electrician");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Electronics Operation");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Electronics Repair");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Engineer");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Enthrallment");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Captivate");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Persuade");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Suggest");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Sway Emotions");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Environment suit");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Erotic Art");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Escape");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Esoteric Medicine");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Exorcism");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Expert Skill");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Explosives");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Falconry");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Farming");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Fast-Draw");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Fast-Talk");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteEndElement();
                    writer.Flush();
                }
                skills = XDocument.Load(file);
            }
        }

        private void LoadAdvantages(string file)
        {
            try
            {
                advantages = XDocument.Load(file);
                
            }
            catch (FileNotFoundException)
            {
                using (XmlWriter writer = XmlWriter.Create(file))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("advantages");
                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("360 vision");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("absulute direction");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("3D Spatial Sense");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Absulute Timing");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Chronolocation");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("acute senses");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Altered Time Rate");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "100");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Legal Alternate Identity");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Illegal Alternate Identity");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Ambidexterity");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("amphibious");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Animal Empathy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Attractive Appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Handsome Appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "12");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Very Handsome Appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "16");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Transcendent Appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                advantages = XDocument.Load(file);
            }

        }
        
        private void FillSkills()
        {
            try
            {
                foreach (XElement element in skills.Descendants("skill"))
                {

                    if (element.Element("name").HasAttributes)
                    {
                        
                        String name = element.Element("name").Value;
                        Difficulty diff = (Difficulty)Enum.Parse(typeof(Difficulty), element.Element("level").Value);
                        AttributeNames type = (AttributeNames)Enum.Parse(typeof(AttributeNames), element.Element("name").Attribute("type").Value);

                        Skill skill = new Skill(name, diff, type);
                        skillContainer.AddSkill(type, skill);
                    }

                }


            }
            catch (FileLoadException)
            {

            }
        }

        private  void FillAdvantages()
        {
            try
            {
                foreach (XElement element in advantages.Descendants("advantage"))
                {
                    
                    if (element.Element("name").HasAttributes)
                    {
                        AdvantageCategory type = (AdvantageCategory)Enum.Parse(typeof(AdvantageCategory), element.Element("name").Attribute("type").Value);
                        String name = element.Element("name").Value;
                        int points = int.Parse(element.Element("points").Value);

                        Advantage advantage = new Advantage(name, points);
                        advantageContainer.AddAdvantage(type, advantage);
                    }
                    
                }

            }
            catch (NullReferenceException)
            {
                
            }
        }

        public AdvantageContainer GetAdvantageContainer() { return advantageContainer; }
        public SkillContainer GetSkillContainer() { return skillContainer; }
    }
}
