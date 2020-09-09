using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /*
     * Your client Komodo Insurance has a number of software development teams.
    Create a Team class that allows us to hold the list of Developers on that team along with the team's name and ID.
    After this is set up, Komodo will need a Repository that will have the ability to:

    C: Have the ability to create new teams
    R: Get a team by its ID
    R: Hold all of the existing Teams
    U: The Team should be able to add new developers and remove developers by their ID.
    D: Delete a team by its ID

     */

    public class Developer
    {
        public Developer() { }
        public Developer(int developerID, string name) 
        {
            DeveloperID = developerID;
            Name = name;
        }
        public int DeveloperID { get; set; }
        public string Name { get; set; }
    }
}
