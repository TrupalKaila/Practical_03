using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03
{
    public class Sponser
    {
        protected string owner = "Rakuteen";
    }
    public class Team : Sponser
    {
        private string teamName;
        public Team(string nameOfTeam)
        {
            teamName = nameOfTeam;
        }
        public string TeamInfo()
        {
            return $"{owner} {teamName}";
        }
    }

}
