using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BJJCompetitionInfo
{
    public class BJJComp
    {
        public BindingList<BJJEvent> Events;

        public BJJComp()
        {
            Events = new BindingList<BJJEvent>();
        }
        public static BJJComp Load(string filename)
        {
            if (File.Exists(filename))
                return JsonConvert.DeserializeObject<BJJComp>(File.ReadAllText("BJJComps.json"));
            else
                return new BJJComp();
        }
        public void Save(string filename)
        {
            string s = JsonConvert.SerializeObject(this);
            File.WriteAllText(filename, s);
        }
    }

}
