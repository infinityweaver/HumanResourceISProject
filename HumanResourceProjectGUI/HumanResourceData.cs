using HumanResourceDataProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HumanResourceProjectGUI
{
    [Serializable]
    public class HumanResourceData
    {
        public HumanResourceAdministrator Administrator { get; set; }
        public List<HumanResource> AllHumanResources { get; set; }

        public HumanResourceData()
        {
            this.Administrator = new HumanResourceAdministrator();
            this.AllHumanResources = new List<HumanResource>();
        }

        public void Save()
        {
            FileStream f = File.OpenWrite(AppDomain.CurrentDomain.BaseDirectory + "master.data");
            XmlSerializer x = new(this.GetType());
            x.Serialize(f, this);
            f.Close();
        }

        public void Load()
        {
            if(!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "master.data"))
                this.Save();
            else
            {
                FileStream f = File.OpenRead(AppDomain.CurrentDomain.BaseDirectory + "master.data");
                XmlSerializer x = new(this.GetType());
                HumanResourceData? h = x.Deserialize(f) as HumanResourceData;
                if(h != null)
                {
                    this.Administrator = h.Administrator;
                    this.AllHumanResources = h.AllHumanResources;
                }
            }
        }
    }
}
