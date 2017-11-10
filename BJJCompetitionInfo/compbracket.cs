using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJJCompetitionInfo
{
    public class compbracket
    {
        string _name;
        string _id;
        string _category1;
        string _category2;
        string _category3;
        string _category4;
        string _details1;
        string _details2;
        string _details3;
        string _details4;

        public string name { get { return _name; } set { _name = value; } }
        public string id { get { return _id; } set { _id = value; } }
        public string category1 { get { return _category1; } set { _category1 = value; } }
        public string category2 { get { return _category2; } set { _category2 = value; } }
        public string category3 { get { return _category3; } set { _category3 = value; } }
        public string category4 { get { return _category4; } set { _category4 = value; } }
        public string details1 { get { return _details1; } set { _details1 = value; } }
        public string details2 { get { return _details2; } set { _details2 = value; } }
        public string details3 { get { return _details3; } set { _details3 = value; } }
        public string details4 { get { return _details4; } set { _details4 = value; } }
        public List<string> ToList()
        {
            List<string> bracketList = new List<string>();
            if (_category1 == "") return bracketList;
            bracketList.Add(_category1);
            if (_category2 == "") return bracketList;
            bracketList.Add(_category2);
            if (_category3 == null) return bracketList;
            bracketList.Add(_category3);
            if (_category4 == null) return bracketList;
            bracketList.Add(_category4);
            return bracketList;
        }
    }
}
