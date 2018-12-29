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
        private AdvantageContainer disadvantageContainer = new AdvantageContainer();
        private XDocument advantages;
        private XDocument skills;
        private XDocument disads;

        public DataWriterReader()
        {
            Initialize();
        }

        private void Initialize()
        {

            LoadSkills("../../skills.xml");
            LoadAdvantages("../../advantages.xml");
            LoadDisads("../../disads.xml");
            FillSkills();
            FillAdvantages();
            FillDisads();
            
        }

        private void LoadDisads(string file)
        {
            try
            {
                disads = XDocument.Load(file);
            }
            catch (FileNotFoundException)
            {
                using (XmlWriter writer = XmlWriter.Create(file))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("disadvantages");
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("absent mindedness");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Addiction");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

             
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("alcoholism");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();
                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("amnesia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("total amnesia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Horrific Appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "24");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();
                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("monstrous appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("hideous appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "16");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("ugly appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "8");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("unattractive appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "-4");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("bad back");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("severe bad back");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("bad grip");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();


                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("bad sight");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("bad smell");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("bad temper");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Berserk");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();


                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("bestial");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("blindnesss");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "50");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();


                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("bloodlust");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("bully");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Callous");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

              
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("cannot Learn");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Cammot speak");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

            
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("charitable");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("chronic depression");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

              
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("clueless");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("code of honor");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("cold blooded");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Colorblindness");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Combat Paralysis");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Compulsive Carousing");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Compulsive Gambling");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Compulsive Lying");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();
                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Confused");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Cowardice");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

             
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Curious");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Cursed");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "75");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();
                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Deafness");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Decreased Time Rate");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "100");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Minor Delusion");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Major Delusion");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Severe Delusion");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Common Dependancy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Occasional Depnndancy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Rare Dependancy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Very Common Dependency");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Minor Bad Destiny");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Major Disadvantage Destiny");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Great Disadvantage");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                  
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Disturbing Voice");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

               
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Divine Curse");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

          
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Rare Draining");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                  
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Occasional Draining");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

               
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Common Draining");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Dread");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

               
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Dyslexia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Dwarfism");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Easy to Kill");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Easy to Read");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Electrical");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

              
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Epilepsy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Extra Sleep");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Fanaticism");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Fat");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Fearfulness");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Mild Flashbacks");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Severe Flashbacks");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Crippling flashbacks");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Brittle");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Combustable");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Explosive");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                  
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Flammable");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Unnatural");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "50");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Frightens Animals");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("G-Intolerance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Gluttony");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Greed");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();
                    
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Guilt Complex");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                   
                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Gullibility");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Gullibility");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Ham-fisted");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Severe Ham-Fisted");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Hard of Hearing");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Hemophilia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Hidebound");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Horizontal");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Hunchback");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Impulsiveness");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Increased consumption");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Incurious");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("indecisive");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Infectious Attack");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Innumerate");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Insomniac");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Severe Insomniac");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Intolerance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Invertebrate");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Jealousy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Killjoy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Kleptomania");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Klutz");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Total Klutz");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Crippled Legs");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Missing Legs");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Laziness");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Lecherousness");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Lifebane");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Light Sleeper");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Loner");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Low Empathy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Low Pain Threshold");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Low Self Image");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Lunacy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Magic Susceptibility");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "3");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Manic-Depressive");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Megalomania");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Miserliness");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Missing Finger");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Missing Thumb");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Motion Sickness");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Mundane Background");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Mild Neurological Disorder");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Severe Neurological Disorder");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "35");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Crippling Neurological Disorder");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "55");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Night Blindness");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Nightmares");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("No Depth Perception");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("No Fine Manipulators");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("No Manipulators");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "50");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("No Legs (Tracked)");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("No Legs (Sessile)");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "50");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("No Sense of Humor");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("No sense of Smell/Taste");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Nocturnal");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Noisy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Non-Iconographic");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Numb");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Oblivious");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Obsession");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("On the Edge");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("One Arm");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("One Eye");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("One Hand");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Overconfidence");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Relectant Killer");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Cannot Harm Innocents");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Cannot Kill");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Self Defense Pacifism");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Total Pacifism");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Phantom Voices Annoying");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Disturbing Phantom Voices");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Diabolical Phantom voices");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Autophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Hemophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Ailurophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Demophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Scotophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Necrophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Mysophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Cynophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Claustrophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Pyrophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Acrophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Entomophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Brontophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Technophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Teratophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Thalassophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Agoraphobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Herpetophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Coitophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Aichmophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Arachnaphobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Xenophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Heliophobia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Post-Combat Shakes");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Pyromania");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Quadriplegic");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "80");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("disadvantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Reprogrammable");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();
                }
                disads = XDocument.Load(file);
            }
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
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Acrobatics");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Acting");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Administration");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Alchemy");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "3");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Animal Handling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Anthropology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Archaeology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Architecture");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Area Knowledge");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Armoury");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Artillery");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Artist");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Astronomy");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "3");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Autohypnosis");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Beam Weapons");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "9");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Bicycling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Bioengineering");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "8");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Biology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Blind Fighting");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Blowpipe");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Boating");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Body Control");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Body Language");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Body Sense");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Bolas");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Bow");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Boxing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Brainwashing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Brawling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Breaking Blow");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Breath Control");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Camoflage");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Carousing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Carpentry");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Cartography");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Chemistry");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Climbing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Cloak");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Computer Hacking");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "7");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Computer Operation");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "7");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Computer Programming");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "7");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Connoisseur");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Cooking");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Counterfeiting");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Crewman");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Criminology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Crossbow");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "3");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Cryptography");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "2");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Current Affairs");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Dancing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Detect Lies");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Diagnosis");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Diplomacy");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Disguise");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Dreaming");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Driving");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Dropping");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Economics");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Electrician");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Electronics Operation");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Electronics Repair");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Engineer");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Enthrallment");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Captivate");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Persuade");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Suggest");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Sway Emotions");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Environment suit");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "7");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Erotic Art");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Escape");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Esoteric Medicine");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Exorcism");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Expert Skill");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "3");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Explosives");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Falconry");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Farming");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Fast-Draw");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Fast-Talk");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Filch");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Finance");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Fire Eating");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("First Aid");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Fishing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Flight");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Flying Leap");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Forced Entry");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Forensics");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "7");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Forgery");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Fortune-Telling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Forward Observer");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Free Fall");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Freight Handling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Gambling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Games");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Gardening");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Garrote");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Geography");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "2");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Geology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "2");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Gesture");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Group Performance");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Gunner");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Guns");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Hazardous Materials");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "7");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Heraldry");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Herb Lore");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Hidden Lore");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Hiking");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("History");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "2");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Hobby Skill");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Holdout");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Housekeeping");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "2");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Hypnotism");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Immovable Stance");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Intelligence Analysis");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Interrogation");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Intimidation");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Invisibility Art");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Jeweler");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Judo");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Jumping");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Karate");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Kiai");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Knot-Tying");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Lance");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Lasso");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Law");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Leadership");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Leatherworking");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Lifting");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Light Walk");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Linguistics");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "2");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Lip Reading");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Liquid Projector");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "9");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Literature");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "3");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Lockpicking");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Machinist");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Makeup");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Market Analysis");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "2");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Masonry");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Mathmatics");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "2");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Mechanic");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Meditation");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Main-Gauche");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Rapier");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Saber");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Smallsword");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Flail");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Two-Handed Flail");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Axe/Mace");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Two-Handed Axe/Mace");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Polearm");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Spear");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Staff");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Broadsword");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Force Sword");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "10");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Jitte/Sai");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Knife");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Shortsword");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Two-Handed Sword");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Force Whip");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "10");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Kusari");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Monowire wHip");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "10");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Whip");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Tonfa");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Mental Strength");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Merchant");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Metallurgy");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Meteorology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Mimicry");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Mind Block");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Mount");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Musical Composition");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Musical Influence");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Musical Instrument");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Naturalist");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Navigation Sea");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Navigation Air");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Navigation Land");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Navigation Space");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "9");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Navigation Hyperspace");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "10");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Net");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Observation");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Occultism");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Packing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Paleontology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "7");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Panhandling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Parachuting");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Parry Missile Weapons");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Performance");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Pharmacy");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Philosophy");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Photography");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Physician");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Physics");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Physiology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Pickpocket");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Piloting");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Poetry");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Poisons");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Politics");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "WILL");
                    writer.WriteString("Power Blow");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Pressure Points");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Pressure Secrets");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Professional Skill");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "3");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Bartender");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "2");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Propaganda");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Prospecting");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "2");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Psychology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Public Speaking");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Push");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Religious Ritual");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Research");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Riding");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Ritual Magic");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Running");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Savoir-Faire");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Scrounging");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Scuba");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Search");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Sewing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Sex Appeal");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Shadowing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Shield");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Shiphandling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "3");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Singing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Skating");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "3");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Skiing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "3");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Sleight of Hand");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Sling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Smith");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Smuggling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Sociology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "4");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Soldier");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Spear Throw");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Speed Reading");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "1");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Sports");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Stage Combat");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Stealth");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Strategy");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Streetwise");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Submarine");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Sumo Wrestling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Surgery");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Survival");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "HT");
                    writer.WriteString("Swimming");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Symbol Drawing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Tactics");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Teaching");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Teamster");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Thaumatology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Theology");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Throwing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Throwing Art");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Thrown Weapon");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Tracking");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Traps");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Net");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Typing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Easy");
                    writer.WriteElementString("TL", "6");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "PER");
                    writer.WriteString("Urban Survival");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "3");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Ventriloquism");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Veterinary");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Hard");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Weird Science");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "VeryHard");
                    writer.WriteElementString("TL", "5");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "DX");
                    writer.WriteString("Wrestling");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Writing");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("skill");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "IQ");
                    writer.WriteString("Zen Archery");
                    writer.WriteEndElement();
                    writer.WriteElementString("level", "Average");
                    writer.WriteElementString("TL", "0");
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
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("absulute direction");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("3D Spatial Sense");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Absulute Timing");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Chronolocation");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteElementString("TL", "12");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("acute senses");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Altered Time Rate");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "100");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteElementString("TL", "12");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Legal Alternate Identity");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();


                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Ambidexterity");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("amphibious");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Animal Empathy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Attractive Appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "4");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Handsome Appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "12");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Very Handsome Appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "16");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Transcendent Appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();


                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Transcendent Appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Transcendent Appearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Arm DX");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "12");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Arm ST");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "3");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteElementString("TL", "0");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Binding");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Blessed");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Brachiator");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Breath-Holding");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Catfall");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Chameleon");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Channeling");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Charisma");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Claim to Hospitality");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Clairsentinence");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Claws");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Clerical Investment");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Clinging");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Combat Reflexes");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Common Sense");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Compartmentalized Mind");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "50");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Constriction Attack");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Cultural Adaptability");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Xeno Adaptability");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Damage Resistance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Danger Sense");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Daredevil");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Darkvision");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Great Destiny");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Major Destiny");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Minor Destiny");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Rare Detect");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Occasional Detect");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Common Detect");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Digital Mind");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Discriminatory Hearing");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Discriminatory Smell");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Discriminatory Taste");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Doesnt Breathe");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Doesnt Eat or Drink");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Doesnt Sleep");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Dominance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Duplication");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "35");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Eidetic Memory");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Elastic Skin");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Empath");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Enhanced block");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Enhanced Dodge");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Enhanced Parry");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Enhanced Move");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Enhanced Time Sense");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "45");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Enhanced Tracking");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Extended Lifespan");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Extra Arms");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Extra Attack");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Extra Head");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Extra Legs");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Extra Life");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Extra Mouth");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Favor");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Fearlessness");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Filter Lungs");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Fit");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Very Fit");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Flexibility");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Double Jointed");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Flight");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "40");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Gadgeteer");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Quick Gadgeteer");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "50");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Gizmos");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("G-Experience");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Gunslinger");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Growth");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Hard to Kill");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Hard to Subdue");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Healing");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Hermaphromorph");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("High Manual Dexterity");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("High Pain THreshold");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Higher Purpose");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Hyperspecrtral Vision");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Illuminated");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Improbed G-Tolerance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Indomitable");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Infravision");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Intuition");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Invisibility");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "40");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Jumper");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "100");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Language Talent");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Local Legal Enforcement");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("National Legal Enforcmeent");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Global Legal Enforcment");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Limited Legal Immunity");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Legal Immunity");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Total Legal Immunity");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Less Sleep");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Lifting ST");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "3");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Lightning Calculator");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Longevity");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Luck");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Extraordinary Luck");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Ridiculous Luck");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Magery");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Magic Resistance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Mana Damper");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Mana Enhancer");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "50");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Medium");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Metabolism Control");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Microscopic Vision");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Mimicry");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Mind Control");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "50");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Mind Probe");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Mind Reading");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Mind Shield");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "4");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("SIngle Mindlink");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Group Mindlink");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Neutralize");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "50");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Night Vision");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "1");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Nictitating Membrane");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "1");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Obscure");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Oracle");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Parabolic Hearing");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Perfect Balance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Penetrating Vision");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Peripheral Vision");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Very Common Permeation");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "40");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Common Permeation");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Occasional Permeation");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Rare Permeation");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Plant Empathy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Possession");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "100");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Digital");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Power Investiture");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Precognition");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Pressure Support");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Protected Sense");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Psi Static");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Psychometry");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Passive Racial Memory");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Active Racial Memory");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "40");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Rapid Healing");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Very Rapid Healing");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Rapier Wit");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Reawakened");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Recovery");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Reduced Consumption");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Slow Regeneration");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Regeneration");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Fast Regeneration");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "50");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Very Fast Regeneration");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "100");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Extreme Regeneration");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "150");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Regrowth");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "40");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Common Resistance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Occasional Resistance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Rare Resistance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Scanning Sense");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Sealed");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Security Clearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Medium Security Clearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("High Security Clearance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("See Invisible");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Sensitive Touch");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Serendipity");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Shadow Form");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "50");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Shrinking");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Signature Gear");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "1");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Silence");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("SingleMinded");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Slippery");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Snatcher");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "80");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Social Chameleon");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Social Regard");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Speak Underwater");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Speak With Animals");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "25");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Speak With Plants");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Speacial Rapport");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Spines");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "3");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Spirit Empathy");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Stretching");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "6");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Striker");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Striking ST");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Subsonic Hearing");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Subsonic Speech");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Super CLimbing");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Super Luck");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "100");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Supernatural Durability");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "150");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Small Talent");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Medium Talent");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Large Talent");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Sharp Teeth");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "1");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Fangs");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "2");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Telecommunication");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Telekinesis");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Telescopic Vision");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Temperature Control");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Temperature Tolerance");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "1");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Temporal Inertia");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Terrain Adaptation");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Terror");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Trained By a Master");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("True Faith");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Tunneling");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Ultrahearing");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Ultrasonic Speech");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Ultravision");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Unaging");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Unfazeable");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Universal Digestion");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Unkillable");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "50");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Vacuum Support");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Vampiric Bite");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "30");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Versatile");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "5");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Vibration Sense");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Visualization");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Voice");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Walk on Air");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Walk on Liquid");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "15");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Warp");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Exotic");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Physical");
                    writer.WriteString("Weapon Master");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "40");
                    writer.WriteElementString("category", "Mundane");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Mental");
                    writer.WriteString("Wild Talent");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "20");
                    writer.WriteElementString("category", "Supernatural");
                    writer.WriteEndElement();
                    writer.Flush();

                    writer.WriteStartElement("advantage");
                    writer.WriteStartElement("name");
                    writer.WriteAttributeString("type", "Social");
                    writer.WriteString("Zeroed");
                    writer.WriteEndElement();
                    writer.WriteElementString("points", "10");
                    writer.WriteElementString("category", "Mundane");
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
        
        private void FillDisads()
        {
            try
            {
                foreach (XElement element in disads.Descendants("disadvantage"))
                {
                    
                    if (element.Element("name").HasAttributes)
                    {
                        AdvantageCategory type = (AdvantageCategory)Enum.Parse(typeof(AdvantageCategory), element.Element("name").Attribute("type").Value);
                        AdvantageType category = (AdvantageType)Enum.Parse(typeof(AdvantageType), element.Element("category").Value);
                        String name = element.Element("name").Value;
                        int points = int.Parse(element.Element("points").Value ) * -1;

                        Advantage advantage = new Advantage(name, points, category);
                        disadvantageContainer.AddAdvantage(type, advantage);
                    }

                }

            }
            catch (NullReferenceException)
            {

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
                        int tech = int.Parse(element.Element("TL").Value);

                        Skill skill = new Skill(name, diff, type, tech );
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
                        AdvantageType category = (AdvantageType)Enum.Parse(typeof(AdvantageType), element.Element("category").Value);
                        String name = element.Element("name").Value;
                        int points = int.Parse(element.Element("points").Value);

                        Advantage advantage = new Advantage(name, points, category);
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
        public AdvantageContainer GetDisadvantageContainer() { return disadvantageContainer; }
    }
}
