using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03
{
    public class Sponser
    {
        //Decalred the string protected so it can be used in subclass
        protected string owner = "Rakuteen";
    }
    //Inherited Sponser class 
    public class Team : Sponser
    {
        private string teamName;
        //Made Paraemeterized constructor to initialize value of teamName
        public Team(string nameOfTeam)
        {
            teamName = nameOfTeam;
        }
        //Created TeamInfo method, which return concated string of owner and teamName 
        public string TeamInfo()
        {
            return $"{owner} {teamName}";
        }
    }

}
