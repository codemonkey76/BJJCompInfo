using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BJJCompetitionInfo
{
    public class BJJCompetitor
    {
        string name;
        string id;
        string academy;
        compbracket brackets;

        public string Name { get { return name; } set { name = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Academy { get { return academy; } set { academy = value; } }
        public compbracket Brackets { get { return brackets; } set { brackets = value; } } 
        public string DisplayName {  get { return name + " (#" + id + ")"; } }
        public bool HasBracket(string bracketName)
        {
            if (brackets.category1 == bracketName || brackets.category2 == bracketName || brackets.category3 == bracketName || brackets.category4 == bracketName)
                return true;
            
                return false;
        }
        public BJJCompetitor()
        {

        }
        public BJJCompetitor(string s)
        {
            string pattern = @"(?<CompetitorName>[^\(]+) \((?<AcademyName>[^\)]+)\) \#(?<CompetitorID>\d+)";
            Match m = Regex.Match(s, pattern);

            this.name = m.Groups["CompetitorName"].Value;
            this.academy = m.Groups["AcademyName"].Value;
            this.id = m.Groups["CompetitorID"].Value;
        }
    }
}
