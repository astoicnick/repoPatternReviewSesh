using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TeamRepository
    {
        // Hold all of the existing Teams
        private List<Team> _teams = new List<Team>();

        // C: Have the ability to create new teams
        public void CreateTeam(Team teamToCreate)
        {
            _teams.Add(teamToCreate);
        }
        // R: Get a team by its ID
        public Team GetTeamByID(int teamID)
        {
            foreach (Team team in _teams)
            {
                if (team.TeamID == teamID)
                {
                    return team;
                }
            }
            return new Team();
        }
        // U: The Team should be able to add new developers
        // remove developers by their ID.
        public void AddDeveloperToTeam(int teamID, int developerID)
        {
            DeveloperRepository devRepo = new DeveloperRepository();
            Developer developerToAdd = devRepo.GetDeveloperByID(developerID);

            foreach (Team team in _teams)
            {
                if (team.TeamID == teamID)
                {
                    team.Developers.Add(developerToAdd);
                }
            }
        }
        public void RemoveDeveloperFromTeam(int teamID, int developerID)
        {
            DeveloperRepository devRepo = new DeveloperRepository();
            Developer developerToRemove = devRepo.GetDeveloperByID(developerID);

            foreach (Team team in _teams)
            {
                if (team.TeamID == teamID)
                {
                    team.Developers.Remove(developerToRemove);
                }
            }
        }
        public void DeleteTeamByID(int teamID)
        {
            foreach (Team team in _teams)
            {
                if (team.TeamID == teamID)
                {
                    _teams.Remove(team);
                    break;
                }
            }
        }

    }
}
