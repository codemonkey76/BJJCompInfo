using System;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace BJJCompetitionInfo
{
    public partial class Form1 : Form
    {
        BJJComp comp;
        public Form1()
        {
            InitializeComponent();
            int year = DateTime.Now.Year;
            for (int i = year + 1; i > year - 5; i--)
                cbYears.Items.Add(i);
            cbYears.SelectedIndex = 1;
            comp = BJJComp.Load("BJJComps.json");
            lbEvents.DataSource = comp.Events;
            lbEvents.DisplayMember = "Name";
        }
       
        private void btnLoadEvents_Click(object sender, EventArgs e)
        {
            string eventsString = getData("https://bjjcomp.com/lib/searchevents.php?q=" + cbYears.SelectedItem);
            string[] eventArray = eventsString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            comp.Events.Clear();
            foreach (string evt in eventArray)
            {
                comp.Events.Add(new BJJEvent(evt));
            }
        }
        string getData(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string s = sr.ReadToEnd();
            sr.Close();
            return s;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            comp.Save("BJJComps.json");
        }

        private void btnGetCompetitors_Click(object sender, EventArgs e)
        {
            BJJEvent evt = (BJJEvent)lbEvents.SelectedItem;

            for (char c = 'a'; c <= 'z'; c++)
            {
                string s = getData("https://bjjcomp.com/lib/searchcompetitor.php?event=" + evt.ID + "&q="+c);
                evt.AddCompetitors(s);
            }
            lbCompetitors.DataSource = evt.Competitors.OrderBy(item => item.Name).ToList();
            lbCompetitors.DisplayMember = "DisplayName";
        }

        string postData(string url, string data)
        {
            WebRequest request = WebRequest.Create(url);
            var dataBytes = Encoding.ASCII.GetBytes(data);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = dataBytes.Length;
            using (var stream = request.GetRequestStream())
                stream.Write(dataBytes, 0, data.Length);

            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string s = sr.ReadToEnd();
            sr.Close();
            return s;
        }
        
        private void btnGetAllBrackets_Click(object sender, EventArgs e)
        {
            BJJEvent evt = (BJJEvent)lbEvents.SelectedItem;
            foreach (BJJCompetitor competitor in evt.Competitors)
            {
                string s = postData("https://bjjcomp.com/lib/fighterschedulequery.php", "event=" + evt.ID + "&competitorid=" + competitor.Id);
                compbracket obj = JsonConvert.DeserializeObject<compbracket>(s);
                competitor.Brackets = obj;
           
            }
        }

        private void lbCompetitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCompetitorBrackets.DataSource = ((BJJCompetitor)lbCompetitors.SelectedItem).Brackets.ToList();
        }

        private void lbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEvents.SelectedIndex >= 0)
            {
                lbCompetitors.DataSource = ((BJJEvent)lbEvents.SelectedItem).Competitors.OrderBy(item => item.Name).ToList();
                lbCompetitors.DisplayMember = "DisplayName";
            }
                
        }

        private void btnGetCompetitorsInBracket_Click(object sender, EventArgs e)
        {
            string bracketName = (string)lbCompetitorBrackets.SelectedItem;
            BindingList<BJJCompetitor> FullCompetitorList = ((BJJEvent)lbEvents.SelectedItem).Competitors;
            BindingList<BJJCompetitor> filteredCompetitors = new BindingList<BJJCompetitor>();

            foreach (BJJCompetitor c in FullCompetitorList)
            {
                if (c.HasBracket(bracketName))
                    filteredCompetitors.Add(c);
            }

            lbCompetitorsInBracket.DataSource = filteredCompetitors;
            lbCompetitorsInBracket.DisplayMember = "Name";
        }
    }
}
