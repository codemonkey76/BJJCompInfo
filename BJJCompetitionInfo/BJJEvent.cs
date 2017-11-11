using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;


namespace BJJCompetitionInfo
{
    public class BJJEvent : INotifyPropertyChanged
    {
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public BindingList<string> GetAcademyList()
        {
            BindingList<string> academyList = new BindingList<string>();
            foreach (BJJCompetitor competitor in Competitors)
            {
                if (!academyList.Contains(competitor.Academy))
                    academyList.Add(competitor.Academy);                
            }
            return academyList;
        }
        public BindingList<BJJCompetitor> GetCompetitorsByAcademy(string Academy)
        {
            BindingList<BJJCompetitor> competitorList = new BindingList<BJJCompetitor>();
            foreach (BJJCompetitor competitor in Competitors)
            {
                if (competitor.Academy==Academy)
                    competitorList.Add(competitor);
            }
               return competitorList;
        }
        string name;
        string id;
        string baseURL = "http://bjjcomp.com/";
        public BindingList<BJJCompetitor> Competitors;
        public string Name { get { return name; } set { name = value; NotifyPropertyChanged(); } }
        public string URL { get { return name.Split(new char[] { '(' })[0].Trim().Replace(' ', '-'); } }
        public string ID { get { return id; } }
        public event PropertyChangedEventHandler PropertyChanged;
        public BJJEvent(string name)
        {
            this.name = name;
            this.id = GetID(this.baseURL + this.URL);
            this.Competitors = new BindingList<BJJCompetitor>();
        }
        public void AddCompetitors(string s)
        {
            string[] people = s.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < people.Length; i++)
            {
                BJJCompetitor competitor = new BJJCompetitor(people[i]);
                if (!this.Competitors.Any(item => item.Id==competitor.Id))
                    this.Competitors.Add(competitor);
            }
        }
        string GetID(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string s = sr.ReadToEnd();
            sr.Close();
            string pattern = @"var eventId='(?<ID>\d+)';";
            string m = Regex.Match(s, pattern).Groups["ID"].Value;
            return m;
        }
    }
}
