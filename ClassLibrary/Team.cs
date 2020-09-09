using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Team
    {
        public Team()
        {

        }
        public Team(int teamID, string name, List<Developer> developers)
        {
            TeamID = teamID;
            Name = name;
            Developers = developers;
        }
        public int TeamID { get; set; }
        public string Name { get; set; }
        public List<Developer> Developers { get; set; }
    }
}
