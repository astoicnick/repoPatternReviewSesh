using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DeveloperRepository
    {
        private List<Developer> _developers = new List<Developer>();
        // C
        public void CreateDeveloper(Developer developer)
        {
            _developers.Add(developer);
        }
        // R
        public List<Developer> GetAllDevelopers()
        {
            return _developers;
        }
        // R - Detail
        public Developer GetDeveloperByID(int developerID)
        {
            foreach (Developer developer in _developers)
            {
                if (developer.DeveloperID == developerID)
                {
                    return developer;
                }
            }
            return new Developer();
        }
        // U
        public void UpdateDeveloper(Developer updatedDeveloper)
        {
            foreach (Developer developer in _developers)
            {
                if (developer.DeveloperID == updatedDeveloper.DeveloperID)
                {
                    developer.Name = updatedDeveloper.Name;
                }
            }
        }
        // D
        public void DeleteDeveloper(int developerID)
        {
            foreach (Developer developer in _developers)
            {
                if (developer.DeveloperID == developerID)
                {
                    _developers.Remove(developer);
                    break;
                }
            }
        }
    }
}
